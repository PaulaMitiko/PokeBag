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
            var httpClient = new HttpClient();
            var URL = "http://localhost:5000/Pokebag/pokemonTransferido";

            int idPokemon = Convert.ToInt32(txt_IdPokemon.Text);

            var resultRequest = httpClient.DeleteAsync($"{URL}?idPokemon={idPokemon}");
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            MessageBox.Show("Vish");

            txt_IdPokemon.Text = "";
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
