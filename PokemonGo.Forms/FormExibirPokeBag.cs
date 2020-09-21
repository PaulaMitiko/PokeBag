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
            List<PokemonBagJoinDex> lista = new List<PokemonBagJoinDex>();

            foreach (var pokemon in data)
            {
                    lista.Add(pokemon);   
            }

            this.dataGridView1.DataSource = lista;
            this.dataGridView1.Columns["IndividualValue"].DefaultCellStyle.Format = "P";
            this.dataGridView1.Columns["Cidade"].Visible = false;
            this.dataGridView1.Columns["PokeDex"].Visible = false;
        }

        class Root
        {
            public List<PokemonBagJoinDex> Data { get; set; }
        }

        private void btn_ExibirTipo_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var URL = "http://localhost:5000/Pokebag/pokemonsDaBag";
            var especie = txt_Especie.Text;
            var resultRequest = httpClient.GetAsync($"{URL}?EspeciePokemon={especie}");
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Root>(result.Result).Data;
            List<PokemonBagJoinDex> lista = new List<PokemonBagJoinDex>();

            foreach (var pokemon in data)
            {
                lista.Add(pokemon);
            }

            this.dataGridView1.DataSource = lista;
            this.dataGridView1.Columns["IndividualValue"].DefaultCellStyle.Format = "P";
            this.dataGridView1.Columns["Cidade"].Visible = false;
            this.dataGridView1.Columns["PokeDex"].Visible = false;

            txt_Especie.Text = "";
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
