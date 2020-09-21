using Newtonsoft.Json;
using PokemonGo.Context.Models;
using PokemonGo.Context.Utilitarios;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
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
            int idPoke = AtualizarContagemPokeDex(box_NoPokemon.Text, out int? contagemPokemon, out int cp35);
            int idCity = AtualizarContagemCidade(box_Cidade.Text, out int? contagemCidade);

            int.TryParse(txt_CP.Text, out int combatPoints);
            int.TryParse(txt_HP.Text, out int healthPoints);

            PokemonBag newPokemon = new PokemonBag()
            {
                IdPokemonType = idPoke,
                CombatPoints = combatPoints,
                HealthPoints = healthPoints,
                Attack = Convert.ToInt32(nbr_Attack.Value),
                Defense = Convert.ToInt32(nbr_Defense.Value),
                Stamina = Convert.ToInt32(nbr_Stamina.Value),
                IdCidade = idCity,
                DataCaptura = dt_DataCaptura.Value,
                Evento = txt_Evento.Text,
                Sombroso = txt_Sombroso.Text,
                FastAttack = txt_Fast.Text,
                ChargeAttack = txt_Charge.Text,
            };

            if (btn_ShinySim.Checked) newPokemon.Shiny = true;
            if (btn_ShinyNao.Checked) newPokemon.Shiny = false;

            newPokemon.DisponivelTroca = CriteriosTroca(newPokemon);
            newPokemon.Transferir = CriteriosTransferencia(newPokemon, contagemCidade, contagemPokemon, cp35);

            if (combatPoints < 10)
            {
                newPokemon.IdPokemonType = 0;
                txt_CP.Text = "";
                MessageBox.Show("Valor de CP inválido!\nPor gentileza, insira um número inteiro.");
            }
            if (healthPoints < 10)
            {
                newPokemon.IdPokemonType = 0;
                txt_HP.Text = "";
                MessageBox.Show("Valor de HP inválido!\nPor gentileza, insira um número inteiro.");
            }

            try
            { 
                var newPokemonJson = JsonConvert.SerializeObject(newPokemon);
                StringContent content = new StringContent(newPokemonJson, Encoding.UTF8, "application/json");

                var httpClient = new HttpClient();
                var URL = "http://localhost:5000/Pokebag/pokemonCapturado";
                var resultRequest = httpClient.PostAsync($"{URL}", content);
                resultRequest.Wait();

                var result = resultRequest.Result.Content.ReadAsStringAsync();
                result.Wait();

                var resultBody = JsonConvert.DeserializeObject<Result<List<PokemonBag>>>(result.Result);
                MessageBox.Show(resultBody.Message);

                //Atualizar status de transferir dos anteriores dado a nova inserção 
                if (contagemCidade > 1 || contagemPokemon > 1)
                {
                    httpClient = new HttpClient();
                    URL = "http://localhost:5000/Pokebag/todosPokemonsDaBag";
                    resultRequest = httpClient.GetAsync(URL);
                    resultRequest.Wait();

                    result = resultRequest.Result.Content.ReadAsStringAsync();
                    result.Wait();

                    var data = JsonConvert.DeserializeObject<Root3>(result.Result).Data;
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
                            URL = "http://localhost:5000/Pokedex/dexDeUmPokemon";
                            resultRequest = httpClient.GetAsync($"{URL}?EspeciePokemon={pokemon.IdPokemonType}");
                            resultRequest.Wait();

                            result = resultRequest.Result.Content.ReadAsStringAsync();
                            result.Wait();

                            var dataAux = JsonConvert.DeserializeObject<Root>(result.Result).Data;
                            newTransf = CriteriosTransferencia(pokemon, contagemCidade, dataAux[0].QtdePokemon, dataAux[0].CPLvl35);
                        }
                        else if (pokemon.IdPokemonType == idPoke)
                        {
                            URL = "http://localhost:5000/Cidades/listarCidadeEspecifica";
                            resultRequest = httpClient.GetAsync($"{URL}?idCidade={pokemon.IdCidade}");
                            resultRequest.Wait();

                            result = resultRequest.Result.Content.ReadAsStringAsync();
                            result.Wait();

                            var dataAux = JsonConvert.DeserializeObject<Root2>(result.Result).Data;
                            newTransf = CriteriosTransferencia(pokemon, dataAux[0].QtdePokemons, contagemPokemon, cp35);
                        }
                        if (pokemon.Transferir != newTransf)
                        {
                            httpClient = new HttpClient();
                            URL = "http://localhost:5000/Pokebag/alterarTransferir";
                            resultRequest = httpClient.PutAsync($"{URL}?idPokemon={pokemon.Id}&novoStatus={newTransf}", null);
                            resultRequest.Wait();
                        }
                    }
                }

                //Limpar boxes
                if (!resultBody.Error)
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
            var httpClient = new HttpClient();
            var URL = "http://localhost:5000/Pokedex/dexDeUmPokemon";

            var resultRequest = httpClient.GetAsync($"{URL}?EspeciePokemon={pokemon.IdPokemonType}");
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Root>(result.Result).Data;
            List<PokeDex> lista = new List<PokeDex>();

            foreach (var especie in data)
            {
                lista.Add(especie);
            }

            if (pokemon.IndividualValue < 0.4 && pokemon.CombatPoints >= lista[0].CPLvl35) return true;
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

        private int AtualizarContagemCidade(string cidade, out int? contagemCidade)
        {
            var httpClient = new HttpClient();
            var URL = "http://localhost:5000/Cidades/listarCidades";
            var resultRequest = httpClient.GetAsync(URL);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data2 = JsonConvert.DeserializeObject<Root2>(result.Result).Data;
            List<Cidade> lista2 = new List<Cidade>();
            int idCidade = 0;
            int? auxcontagemCidade = 0;

            foreach (var city in data2)
            {
                lista2.Add(city);
                if (city.NomeCidade == cidade)
                {
                    idCidade = city.Id;
                    auxcontagemCidade = city.QtdePokemons + 1;
                }
            }

            contagemCidade = auxcontagemCidade;

            URL = "http://localhost:5000/Cidades/atualizarContagem";
            resultRequest = httpClient.PutAsync($"{URL}?idCidade={idCidade}&novaContagem={contagemCidade}", null);
            resultRequest.Wait();

            return idCidade;
        }

        private int AtualizarContagemPokeDex(string Pokemon, out int? contagemPokemon, out int cpLvl35)
        {
            var httpClient = new HttpClient();
            var URL = "http://localhost:5000/Pokedex/todosPokemonsDaDex";

            var resultRequest = httpClient.GetAsync(URL);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Root>(result.Result).Data;
            List<PokeDex> lista = new List<PokeDex>();
            contagemPokemon = 0;
            cpLvl35 = 0;
            int idPokemon = 0;

            foreach (var especie in data)
            {
                lista.Add(especie);
                if (especie.Name == Pokemon) 
                {
                    contagemPokemon = especie.QtdePokemon + 1;
                    cpLvl35 = especie.CPLvl35;
                    idPokemon = especie.Id;
                }
            }

            URL = "http://localhost:5000/Pokedex/atualizarContagem";
            resultRequest = httpClient.PutAsync($"{URL}?idPokemon={idPokemon}&novaContagem={contagemPokemon}", null);
            resultRequest.Wait();

            return idPokemon;
        }
        private void CarregaListaPokemon()
        {
            var httpClient = new HttpClient();
            var URL = "http://localhost:5000/Pokedex/todosPokemonsDaDex";
            var resultRequest = httpClient.GetAsync(URL);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Root>(result.Result).Data;

            foreach (var pokemon in data)
            {
                box_NoPokemon.Items.Add(pokemon.Name);
            }
        }
        private void CarregaListaCidade()
        {
            var httpClient = new HttpClient();
            var URL = "http://localhost:5000/Cidades/listarCidades";
            var resultRequest = httpClient.GetAsync(URL);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Root2>(result.Result).Data;

            foreach (var cidade in data)
            {
                box_Cidade.Items.Add(cidade.NomeCidade);
            }
        }
        private class Root
        {
            public List<PokeDex> Data { get; set; }
        }
        private class Root2
        {
            public List<Cidade> Data { get; set; }
        }
        private class Root3
        {
            public List<PokemonBag> Data { get; set; }
        }
    }
}

