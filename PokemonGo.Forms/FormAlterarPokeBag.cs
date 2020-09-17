﻿using System;
using System.Net.Http;
using System.Windows.Forms;

namespace PokemonGo.Forms
{
    public partial class FormAlterarPokeBag : Form
    {
        public FormAlterarPokeBag()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            var httpClient = new HttpClient();
            var URL = "http://localhost:5000/Pokebag/alterarStats";

            int idPokemon = Convert.ToInt32(txt_NoPokemon.Text);
            int novoCP = Convert.ToInt32(txt_CP.Text);
            int novoHP = Convert.ToInt32(txt_HP.Text);

            var resultRequest = httpClient.PutAsync($"{URL}?idPokemon={idPokemon}&novoCP={novoCP}&novoHP={novoHP}", null);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            //var resultBody = JsonConvert.DeserializeObject<Result<PokemonBag>>(result.Result);
            //MessageBox.Show(resultBody.Message);
            MessageBox.Show("Stats alterado com sucesso");

            this.Close();
        }
    }
}
