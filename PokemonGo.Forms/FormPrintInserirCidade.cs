using Newtonsoft.Json;
using PokemonGo.Context.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace PokemonGo.Forms
{
    public partial class FormPrintInserirCidade : Form
    {
        public FormPrintInserirCidade()
        {
            InitializeComponent();
            Exibir();
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            Cidade newCidade = new Cidade()
            {
                NomeCidade = txt_Cidade.Text,
                Pais = txt_Pais.Text
            };

            var newCidadeJson = JsonConvert.SerializeObject(newCidade);
            StringContent content = new StringContent(newCidadeJson, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();
            var URL = "http://localhost:5000/Cidades/cadastrarCidade";
            var resultRequest = httpClient.PostAsync($"{URL}", content);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            //var resultBody = JsonConvert.DeserializeObject<Result<List<PokemonBag>>>(result.Result);
            MessageBox.Show("Cidade inserida com sucesso!");

            txt_Cidade.Text = "";
            txt_Pais.Text = "";

            Exibir();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var URL = "http://localhost:5000/Cidades/excluirCidade";

            int idCidade = Convert.ToInt32(txt_Id.Text);

            var resultRequest = httpClient.DeleteAsync($"{URL}?idCidade={idCidade}");
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            MessageBox.Show("Cidade excluida com sucesso!");

            Exibir();
        }

        private void Exibir() 
        {
            var httpClient = new HttpClient();
            var URL = "http://localhost:5000/Cidades/listarCidades";
            var resultRequest = httpClient.GetAsync(URL);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Root>(result.Result).Data;
            List<Cidade> lista = new List<Cidade>();

            foreach (var cidade in data)
            {
                lista.Add(cidade);
            }

            this.DataGrid.DataSource = lista;
            this.DataGrid.Columns["Bag"].Visible = false;
        }

        class Root
        {
            public List<Cidade> Data { get; set; }
        }
    }
}
