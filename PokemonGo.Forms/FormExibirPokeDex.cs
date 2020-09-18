using Newtonsoft.Json;
using PokemonGo.Context.Models;
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
            var URL = "http://localhost:5000/Pokedex/dexDeUmPokemon";
            var converteu = int.TryParse(txt_Id.Text, out int especie);
            if (!converteu) { especie = 0; }
            var resultRequest = httpClient.GetAsync($"{URL}?EspeciePokemon={especie}");
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

            txt_Id.Text = "";
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
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
