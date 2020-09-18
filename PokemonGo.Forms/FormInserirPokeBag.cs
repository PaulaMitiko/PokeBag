using Newtonsoft.Json;
using PokemonGo.Context.Models;
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
                box_NoPokemon.Items.Add($"{pokemon.Id} - {pokemon.Name}");
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
                box_Cidade.Items.Add($"{cidade.Id} - {cidade.NomeCidade}");
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

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            PokemonBag newPokemon = new PokemonBag()
            {
                IdPokemonType = (box_NoPokemon.SelectedIndex)+1,
                CombatPoints = Int32.Parse(txt_CP.Text),
                HealthPoints = Int32.Parse(txt_HP.Text),
                Attack = Int32.Parse(txt_Attack.Text),
                Defense = Int32.Parse(txt_Defense.Text),
                Stamina = Int32.Parse(txt_Stamina.Text),
                IdCidade = (box_Cidade.SelectedIndex)+1,
                DataCaptura = dt_DataCaptura.Value,
                Evento = txt_Evento.Text,
                Sombroso = txt_Sombroso.Text,
                FastAttack = txt_Fast.Text,
                ChargeAttack = txt_Charge.Text
            };

            if (btn_ShinySim.Checked) newPokemon.Shiny = true;
            if (btn_ShinyNao.Checked) newPokemon.Shiny = false;

            newPokemon.DisponivelTroca = CriteriosTroca(newPokemon);
            newPokemon.Transferir = CriteriosTransferencia(newPokemon);

            var newPokemonJson = JsonConvert.SerializeObject(newPokemon);
            StringContent content = new StringContent(newPokemonJson, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();
            var URL = "http://localhost:5000/Pokebag/pokemonCapturado";
            var resultRequest = httpClient.PostAsync($"{URL}", content);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            //var resultBody = JsonConvert.DeserializeObject<Result<List<PokemonBag>>>(result.Result);
            MessageBox.Show("Pokémon inserido com sucesso!");

            btn_ShinyNao.Checked = false;
            btn_ShinySim.Checked = false;
            box_Cidade.Text = "";
            box_NoPokemon.Text = "";
            txt_CP.Text = "";
            txt_HP.Text = "";
            txt_Attack.Text = "";
            txt_Defense.Text = "";
            txt_Stamina.Text = "";
            txt_Evento.Text = "";
            txt_Sombroso.Text = "";
            txt_Fast.Text = "";
            txt_Charge.Text = "";
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

            return pokemon.IndividualValue < 0.4 && pokemon.CombatPoints >= lista[0].CPLvl35 ? true : false;
        }

        private bool CriteriosTransferencia(PokemonBag pokemon)
        {
            if (pokemon.Shiny) return false;
            if (!(pokemon.Sombroso is null)) return false;
            if (!(pokemon.Evento is null)) return false;

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

            int contagemPokemon = lista[0].QtdePokemon + 1;

            URL = "http://localhost:5000/Pokedex/atualizarContagem";
            resultRequest = httpClient.PutAsync($"{URL}?idPokemon={pokemon.IdPokemonType}&novaContagem={contagemPokemon}", null);
            resultRequest.Wait();

            if (contagemPokemon == 1) return false;

            if (pokemon.IndividualValue >= 0.85) return false;
            else if (pokemon.CombatPoints >= lista[0].CPLvl35) return false;

            URL = "http://localhost:5000/Cidades/listarCidades";
            resultRequest = httpClient.GetAsync(URL);
            resultRequest.Wait();

            result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data2 = JsonConvert.DeserializeObject<Root2>(result.Result).Data;
            List<Cidade> lista2 = new List<Cidade>();

            foreach (var cidade in data2)
            {
                lista2.Add(cidade);
            }

            int contagemCidade = lista[0].QtdePokemon + 1;

            URL = "http://localhost:5000/Cidades/atualizarContagem";
            resultRequest = httpClient.PutAsync($"{URL}?idCidade={pokemon.IdCidade}&novaContagem={contagemCidade}", null);
            resultRequest.Wait();

            if (contagemCidade == 1) return false;

            return true;
        }
    }
}

