using Newtonsoft.Json;
using PokemonGo.Context.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace PokemonGo.Forms
{
    public partial class FormExibirPokeBag : Form
    {
        public FormExibirPokeBag()
        {
            InitializeComponent();

            
        }

        private void btn_ExibirTodos_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var URL = "http://localhost:5000/Pokebag/todosPokemonsDaBag";
            var resultRequest = httpClient.GetAsync(URL);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Root>(result.Result).Data;
            List<PokemonBag> lista = new List<PokemonBag>();

            foreach (var pokemon in data)
            {
                    lista.Add(pokemon);   
            }

            this.dataGridView1.DataSource = lista;
        }

        class Root
        {
            public List<PokemonBag> Data { get; set; }
        }

        private void btn_ExibirTipo_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var URL = "http://localhost:5000/Pokebag/pokemonsDaBag";
            int especie = Convert.ToInt32(txt_Especie.Text);
            var resultRequest = httpClient.GetAsync($"{URL}?EspeciePokemon={especie}");
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Root>(result.Result).Data;
            List<PokemonBag> lista = new List<PokemonBag>();

            foreach (var pokemon in data)
            {
                lista.Add(pokemon);
            }

            this.dataGridView1.DataSource = lista;
        }
    }
}
