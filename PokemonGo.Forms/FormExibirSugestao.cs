using Newtonsoft.Json;
using PokemonGo.Context.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace PokemonGo.Forms
{
    public partial class FormExibirSugestao : Form
    {
        public FormExibirSugestao()
        {
            InitializeComponent();
        }

        private void btn_Troca_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var URL = "http://localhost:5000/Pokebag/sugestaoTroca";
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
        private void btn_Transf_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var URL = "http://localhost:5000/Pokebag/sugestaoTransferir";
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

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            var excluir = new FormExcluirPokeBag();
            this.Hide();
            excluir.ShowDialog();
            this.Show();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        class Root
        {
            public List<PokemonBagJoinDex> Data { get; set; }
        }
    }
}

