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
    }
}
