using PokemonGo.Context.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PokemonGo.Forms
{
    public partial class FormInserirPokeBag : Form
    {
        public FormInserirPokeBag()
        {
            InitializeComponent();
            CarregaListaPokemon();
            CarregaListaCidade();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            int? contagemPokemon = 0;
            int cp35 = 0;
            int? contagemCidade = 0;
            int idPoke = 0;
            int idCity = 0;

            int.TryParse(txt_CP.Text, out int combatPoints);
            int.TryParse(txt_HP.Text, out int healthPoints);


            PokemonBag newPokemon = new PokemonBag()
            {
                CombatPoints = combatPoints,
                HealthPoints = healthPoints,
                Attack = Convert.ToInt32(nbr_Attack.Value),
                Defense = Convert.ToInt32(nbr_Defense.Value),
                Stamina = Convert.ToInt32(nbr_Stamina.Value),
                DataCaptura = dt_DataCaptura.Value,
                Evento = txt_Evento.Text,
                Sombroso = txt_Sombroso.Text,
                FastAttack = txt_Fast.Text,
                ChargeAttack = txt_Charge.Text,
                Shiny = false
            };

            if (btn_ShinySim.Checked) newPokemon.Shiny = true;
            if (btn_ShinyNao.Checked) newPokemon.Shiny = false;

            if (combatPoints < 10)
            {
                newPokemon.IdPokemonType = 0;
                txt_CP.Text = "";
                MessageBox.Show("Valor de CP inválido!\nPor gentileza, insira um número inteiro maior que 9.");
            }
            if (healthPoints < 10)
            {
                newPokemon.IdPokemonType = 0;
                txt_HP.Text = "";
                MessageBox.Show("Valor de HP inválido!\nPor gentileza, insira um número inteiro maior que 9.");
            }
            else 
            {
                idPoke = AtualizarContagemPokeDex(box_NoPokemon.Text, ref contagemPokemon, ref cp35);
                idCity = AtualizarContagemCidade(box_Cidade.Text, ref contagemCidade);

                newPokemon.IdPokemonType = idPoke;
                newPokemon.IdCidade = idCity;

                newPokemon.DisponivelTroca = CriteriosTroca(newPokemon);
                newPokemon.Transferir = CriteriosTransferencia(newPokemon, contagemCidade, contagemPokemon, cp35);
            }

            try
            { 
                var URL = "http://localhost:5000/Pokebag/pokemonCapturado";
                var consumir = new ConsumeAPI<PokemonBag>();
                var resultBody = consumir.ConsumePostAPI(URL, newPokemon);
                
                MessageBox.Show(resultBody.Item1);

                //Atualizar status de transferir dos anteriores dado a nova inserção 
                if (contagemCidade > 1 || contagemPokemon > 1)
                {
                    URL = "http://localhost:5000/Pokebag/todosPokemonsDaBag";
                    var data = consumir.ConsumeGetAPI(URL);
                    List<PokemonBag> lista = new List<PokemonBag>();

                    foreach (var pokemon in data)
                    {
                        bool newTransf = pokemon.Transferir;
                        if (pokemon.IdCidade == idCity && pokemon.IdPokemonType == idPoke)
                        {
                            newTransf = CriteriosTransferencia(pokemon, contagemCidade, contagemPokemon, cp35);
                        }
                        else if (pokemon.IdCidade == idCity)
                        {
                            URL = $"http://localhost:5000/Pokedex/dexDeUmPokemon?EspeciePokemon={pokemon.IdPokemonType}";
                            var consumirAux = new ConsumeAPI<PokeDex>();
                            var dataAux = consumirAux.ConsumeGetAPI(URL);
                            
                            newTransf = CriteriosTransferencia(pokemon, contagemCidade, dataAux[0].QtdePokemon, dataAux[0].CPLvl35);
                        }
                        else if (pokemon.IdPokemonType == idPoke)
                        {
                            URL = $"http://localhost:5000/Cidades/listarCidadeEspecifica?idCidade={pokemon.IdCidade}";
                            var consumirAux = new ConsumeAPI<Cidade>();
                            var dataAux = consumirAux.ConsumeGetAPI(URL);
                            
                            newTransf = CriteriosTransferencia(pokemon, dataAux[0].QtdePokemons, contagemPokemon, cp35);
                        }
                        if (pokemon.Transferir != newTransf)
                        {
                            URL = $"http://localhost:5000/Pokebag/alterarTransferir?idPokemon={pokemon.Id}&novoStatus={newTransf}";
                            consumir.ConsumePutAPI(URL);
                        }
                    }
                }

                //Limpar boxes
                if (!resultBody.Item2)
                {
                    btn_ShinyNao.Checked = false;
                    btn_ShinySim.Checked = false;
                    box_Cidade.Text = "";
                    box_NoPokemon.Text = "";
                    txt_CP.Text = "";
                    txt_HP.Text = "";
                    nbr_Attack.Text = "";
                    nbr_Defense.Text = "";
                    nbr_Stamina.Text = "";
                    txt_Evento.Text = "";
                    txt_Sombroso.Text = "";
                    txt_Fast.Text = "";
                    txt_Charge.Text = "";
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private bool CriteriosTroca(PokemonBag pokemon)
        {
            var URL = $"http://localhost:5000/Pokedex/dexDeUmPokemon?EspeciePokemon={pokemon.IdPokemonType}";
            var consumir = new ConsumeAPI<PokeDex>();
            var data = consumir.ConsumeGetAPI(URL);
            
            if (pokemon.IndividualValue < 0.4 && pokemon.CombatPoints >= data[0].CPLvl35) return true;
            else return false;
        }

        private bool CriteriosTransferencia(PokemonBag pokemon, int? contagemCidade, int? contagemPokemon, int cp35)
        {
            if (pokemon.Shiny) return false;
            if (pokemon.Sombroso != "") return false;
            if (pokemon.Evento != "") return false;

            if (pokemon.IndividualValue >= 0.85) return false;
            else if (pokemon.CombatPoints >= cp35) return false;

            if (contagemPokemon == 1) return false;
            if (contagemCidade == 1) return false;

            return true;
        }

        private int AtualizarContagemCidade(string cidade, ref int? contagemCidade)
        {
            var URL = "http://localhost:5000/Cidades/listarCidades";

            var consumir = new ConsumeAPI<Cidade>();
            var data = consumir.ConsumeGetAPI(URL);
            
            int idCidade = 0;
            contagemCidade = 0;

            foreach (var city in data)
            {
                if (city.NomeCidade == cidade)
                {
                    idCidade = city.Id;
                    contagemCidade = city.QtdePokemons + 1;
                }
            }

            URL = $"http://localhost:5000/Cidades/atualizarContagem?idCidade={idCidade}&novaContagem={contagemCidade}";
            consumir.ConsumePutAPI(URL);

            return idCidade;
        }

        private int AtualizarContagemPokeDex(string Pokemon, ref int? contagemPokemon, ref int cpLvl35)
        {
            var URL = "http://localhost:5000/Pokedex/todosPokemonsDaDex";
            var consumir = new ConsumeAPI<PokeDex>();
            var data = consumir.ConsumeGetAPI(URL);
            
            contagemPokemon = 0;
            cpLvl35 = 0;
            int idPokemon = 0;

            foreach (var especie in data)
            {
                if (especie.Name == Pokemon) 
                {
                    contagemPokemon = especie.QtdePokemon + 1;
                    cpLvl35 = especie.CPLvl35;
                    idPokemon = especie.Id;
                }
            }
            
            URL = $"http://localhost:5000/Pokedex/atualizarContagem?idPokemon={idPokemon}&novaContagem={contagemPokemon}";
            consumir.ConsumePutAPI(URL);

            return idPokemon;
        }
        private void CarregaListaPokemon()
        {
            var URL = "http://localhost:5000/Pokedex/todosPokemonsDaDex";
            var consumir = new ConsumeAPI<PokeDex>();
            var data = consumir.ConsumeGetAPI(URL); 

            foreach (var pokemon in data)
            {
                box_NoPokemon.Items.Add(pokemon.Name);
            }
        }
        private void CarregaListaCidade()
        {
            var URL = "http://localhost:5000/Cidades/listarCidades";
            var consumir = new ConsumeAPI<Cidade>();
            var data = consumir.ConsumeGetAPI(URL);

            foreach (var cidade in data)
            {
                box_Cidade.Items.Add(cidade.NomeCidade);
            }
        }
    }
}

