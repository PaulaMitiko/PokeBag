using Newtonsoft.Json;
using PokemonGo.Context.Models;
using PokemonGo.Context.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Text;
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
                var httpClient = new HttpClient();
                var URL = "http://localhost:5000/Pokebag/pokemonTransferido";

                int idPokemon = Convert.ToInt32(txt_IdPokemon.Text);

                var resultRequest = httpClient.DeleteAsync($"{URL}?idPokemon={idPokemon}");
                resultRequest.Wait();

                var result = resultRequest.Result.Content.ReadAsStringAsync();
                result.Wait();

                var resultBody = JsonConvert.DeserializeObject<Result<List<PokemonBag>>>(result.Result);

                MessageBox.Show(resultBody.Message);
             
                //var data = JsonConvert.DeserializeObject<ResList<PokemonBag>>(result.Result).Data;
                int idCidade = resultBody.Data[0].IdCidade;
                int idPokeDex = resultBody.Data[0].IdPokemonType;

                AtualizarContagemCidade(idCidade, out int? contagemCidade);
                AtualizarContagemPokeDex(idPokeDex, out int? contagemPokemon, out int cpLvl35);

                if (contagemCidade == 1 || contagemPokemon == 1)
                {
                    httpClient = new HttpClient();
                    URL = "http://localhost:5000/Pokebag/todosPokemonsDaBag";
                    resultRequest = httpClient.GetAsync(URL);
                    resultRequest.Wait();

                    result = resultRequest.Result.Content.ReadAsStringAsync();
                    result.Wait();

                    var dataAux = JsonConvert.DeserializeObject<Root3>(result.Result).Data;
                    List<PokemonBag> lista = new List<PokemonBag>();

                    foreach (var pokemon in dataAux)
                    {
                        bool newTransf = pokemon.Transferir;
                        if (pokemon.IdCidade == idCidade && pokemon.IdPokemonType == idPokeDex)
                        {
                            newTransf = CriteriosTransferencia(pokemon, contagemCidade, contagemPokemon, cpLvl35);
                        }
                        else if (pokemon.IdCidade == idCidade)
                        {
                            URL = "http://localhost:5000/Pokedex/dexDeUmPokemon";
                            resultRequest = httpClient.GetAsync($"{URL}?EspeciePokemon={pokemon.IdPokemonType}");
                            resultRequest.Wait();

                            result = resultRequest.Result.Content.ReadAsStringAsync();
                            result.Wait();

                            var dataAux2 = JsonConvert.DeserializeObject<Root>(result.Result).Data;
                            newTransf = CriteriosTransferencia(pokemon, contagemCidade, dataAux2[0].QtdePokemon, dataAux2[0].CPLvl35);
                        }
                        else if (pokemon.IdPokemonType == idPokeDex)
                        {
                            URL = "http://localhost:5000/Cidades/listarCidadeEspecifica";
                            resultRequest = httpClient.GetAsync($"{URL}?idCidade={pokemon.IdCidade}");
                            resultRequest.Wait();

                            result = resultRequest.Result.Content.ReadAsStringAsync();
                            result.Wait();

                            var dataAux2 = JsonConvert.DeserializeObject<Root2>(result.Result).Data;
                            newTransf = CriteriosTransferencia(pokemon, dataAux2[0].QtdePokemons, contagemPokemon, cpLvl35);
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
            var httpClient = new HttpClient();
            var URL = "http://localhost:5000/Cidades/listarCidadeEspecifica";
            var resultRequest = httpClient.GetAsync($"{URL}?idCidade={idCidade}");
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data2 = JsonConvert.DeserializeObject<Root2>(result.Result).Data;
            
            contagemCidade = data2[0].QtdePokemons - 1;

            URL = "http://localhost:5000/Cidades/atualizarContagem";
            resultRequest = httpClient.PutAsync($"{URL}?idCidade={idCidade}&novaContagem={contagemCidade}", null);
            resultRequest.Wait();
        }

        private void AtualizarContagemPokeDex(int idPokemon, out int? contagemPokemon, out int cpLvl35)
        {
            var httpClient = new HttpClient();
            var URL = "http://localhost:5000/Pokedex/dexDeUmPokemon";

            var resultRequest = httpClient.GetAsync($"{URL}?EspeciePokemon={idPokemon}");
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Root>(result.Result).Data;
            
            contagemPokemon = data[0].QtdePokemon - 1;
            cpLvl35 = data[0].CPLvl35;

            URL = "http://localhost:5000/Pokedex/atualizarContagem";
            resultRequest = httpClient.PutAsync($"{URL}?idPokemon={idPokemon}&novaContagem={contagemPokemon}", null);
            resultRequest.Wait();
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
