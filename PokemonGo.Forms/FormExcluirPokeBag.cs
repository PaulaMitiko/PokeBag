using PokemonGo.Context.Models;
using System;
using System.Windows.Forms;

namespace PokemonGo.Forms
{
    public partial class FormExcluirPokeBag : Form
    {
        public FormExcluirPokeBag()
        {
            InitializeComponent();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                int idPokemon = Convert.ToInt32(txt_IdPokemon.Text);
                var URL = $"http://localhost:5000/Pokebag/pokemonTransferido?idPokemon={idPokemon}";
                var consumir = new ConsumeAPI<PokemonBag>();
                var resultBody = consumir.ConsumeDeleteAPI(URL);

                MessageBox.Show(resultBody.Message);
             
                int idCidade = resultBody.Data[0].IdCidade;
                int idPokeDex = resultBody.Data[0].IdPokemonType;

                if (!resultBody.Error)
                {
                    AtualizarContagemCidade(idCidade, out int? contagemCidade);
                    AtualizarContagemPokeDex(idPokeDex, out int? contagemPokemon, out int cpLvl35);

                    if (contagemCidade == 1 || contagemPokemon == 1)
                    {
                        URL = "http://localhost:5000/Pokebag/todosPokemonsDaBag";
                        var dataAux = consumir.ConsumeGetAPI(URL);

                        foreach (var pokemon in dataAux)
                        {
                            bool newTransf = pokemon.Transferir;
                            if (pokemon.IdCidade == idCidade && pokemon.IdPokemonType == idPokeDex)
                            {
                                newTransf = CriteriosTransferencia(pokemon, contagemCidade, contagemPokemon, cpLvl35);
                            }
                            else if (pokemon.IdCidade == idCidade)
                            {
                                URL = $"http://localhost:5000/Pokedex/dexDeUmPokemon?EspeciePokemon={pokemon.IdPokemonType}";
                                var consumirAux = new ConsumeAPI<PokeDex>();
                                var dataAux2 = consumirAux.ConsumeGetAPI(URL);

                                newTransf = CriteriosTransferencia(pokemon, contagemCidade, dataAux2[0].QtdePokemon, dataAux2[0].CPLvl35);
                            }
                            else if (pokemon.IdPokemonType == idPokeDex)
                            {
                                URL = $"http://localhost:5000/Cidades/listarCidadeEspecifica?idCidade={pokemon.IdCidade}";
                                var consumirAux = new ConsumeAPI<Cidade>();
                                var dataAux2 = consumirAux.ConsumeGetAPI(URL);

                                newTransf = CriteriosTransferencia(pokemon, dataAux2[0].QtdePokemons, contagemPokemon, cpLvl35);
                            }
                            if (pokemon.Transferir != newTransf)
                            {
                                URL = $"http://localhost:5000/Pokebag/alterarTransferir?idPokemon={pokemon.Id}&novoStatus={newTransf}";
                                consumir.ConsumePutAPI(URL);
                            }
                        }
                    }
                }
                txt_IdPokemon.Text = "";
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

        private void lbl_Consultar_Click(object sender, EventArgs e)
        {
            var exibir = new FormExibirPokeBag();
            this.Hide();
            exibir.ShowDialog();
            this.Show();
        }

        private void AtualizarContagemCidade(int idCidade, out int? contagemCidade)
        {
            var URL = $"http://localhost:5000/Cidades/listarCidadeEspecifica?idCidade={idCidade}";
            var consumir = new ConsumeAPI<Cidade>();
            var data = consumir.ConsumeGetAPI(URL);
            
            contagemCidade = data[0].QtdePokemons - 1;

            URL = $"http://localhost:5000/Cidades/atualizarContagem?idCidade={idCidade}&novaContagem={contagemCidade}";
            consumir.ConsumePutAPI(URL);
        }

        private void AtualizarContagemPokeDex(int idPokemon, out int? contagemPokemon, out int cpLvl35)
        {
            var URL = $"http://localhost:5000/Pokedex/dexDeUmPokemon?EspeciePokemon={idPokemon}";
            var consumir = new ConsumeAPI<PokeDex>();
            var data = consumir.ConsumeGetAPI(URL);
            
            contagemPokemon = data[0].QtdePokemon - 1;
            cpLvl35 = data[0].CPLvl35;

            URL = $"http://localhost:5000/Pokedex/atualizarContagem?idPokemon={idPokemon}&novaContagem={contagemPokemon}";
            consumir.ConsumePutAPI(URL);
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
    }
}
