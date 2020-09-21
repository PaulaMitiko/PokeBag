using Newtonsoft.Json;
using PokemonGo.Context.Models;
using PokemonGo.Context.Utilitarios;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace PokemonGo.Forms
{
    public partial class FormExibirPokeDex : Form
    {
        public FormExibirPokeDex()
        {
            InitializeComponent();
            CarregaListaPokemon();
        }

        private void btn_Todos_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var URL = "http://localhost:5000/Pokedex/todosPokemonsDaDex";
            var resultRequest = httpClient.GetAsync(URL);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Root>(result.Result).Data;
            List<PokeDex> lista = new List<PokeDex>();

            foreach (var pokemon in data)
            {
                lista.Add(pokemon);
            }

            this.dataGridView1.DataSource = lista;
            this.dataGridView1.Columns["Bag"].Visible = false;
        }

        class Root
        {
            public List<PokeDex> Data { get; set; }
        }

        private void btn_Id_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();

            var URL = "http://localhost:5000/Pokedex/todosPokemonsDaDex";

            var resultRequest = httpClient.GetAsync(URL);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Root>(result.Result).Data;
          
            int idPokemon = 0;
            foreach (var item in data)
            {
                if (item.Name == box_Id.Text)
                {
                    idPokemon = item.Id;
                }
            }

            URL = "http://localhost:5000/Pokedex/dexDeUmPokemon";
           
            resultRequest = httpClient.GetAsync($"{URL}?EspeciePokemon={idPokemon}");
            resultRequest.Wait();

            result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            data = JsonConvert.DeserializeObject<Root>(result.Result).Data;
            List<PokeDex> lista = new List<PokeDex>();

            foreach (var pokemon in data)
            {
                lista.Add(pokemon);
            }

            this.dataGridView1.DataSource = lista;
            this.dataGridView1.Columns["Bag"].Visible = false;

            var resultBody = JsonConvert.DeserializeObject<Result<List<PokemonBag>>>(result.Result);

            if (resultBody.Error) MessageBox.Show(resultBody.Message);

            box_Id.Text = "";
        }

        private void btn_Tipo_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var URL = "http://localhost:5000/Pokedex/pokemonsPorTipo";
            var resultRequest = httpClient.GetAsync($"{URL}?tipoPokemon={box_Tipo.Text}");
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Root>(result.Result).Data;
            List<PokeDex> lista = new List<PokeDex>();

            foreach (var pokemon in data)
            {
                lista.Add(pokemon);
            }

            this.dataGridView1.DataSource = lista;
            this.dataGridView1.Columns["Bag"].Visible = false;

            box_Tipo.Text = "";

            var resultBody = JsonConvert.DeserializeObject<Result<List<PokemonBag>>>(result.Result);

            if (resultBody.Error) MessageBox.Show(resultBody.Message);
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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
                box_Id.Items.Add(pokemon.Name);
            }
        }
    }
}
