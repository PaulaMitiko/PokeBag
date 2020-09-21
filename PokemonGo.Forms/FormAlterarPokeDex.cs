using Newtonsoft.Json;
using PokemonGo.Context.Models;
using PokemonGo.Context.Utilitarios;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PokemonGo.Forms
{
    public partial class FormAlterarPokeDex : Form
    {
        public FormAlterarPokeDex()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var URL = "http://localhost:5000/Pokedex/alterarDados";

            int idPokemon = Convert.ToInt32(txt_Id.Text);
            int.TryParse(txt_CP.Text, out int novoCP);
            int.TryParse(txt_Lvl35.Text, out int novoLvl35);
            int.TryParse((Regex.Match(box_Egg.Text, @"\d+").Value), out int novoEgg);


            var resultRequest = httpClient.PutAsync($"{URL}?idPokemon={idPokemon}&novoCP={novoCP}&novoLvl35={novoLvl35}" +
                $"&novoEgg={novoEgg}", null);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var resultBody = JsonConvert.DeserializeObject<Result<List<PokemonBag>>>(result.Result);

            MessageBox.Show(resultBody.Message);

            txt_Id.Text = "";
            txt_CP.Text = "";
            txt_Lvl35.Text = "";
            box_Egg.Text = "";
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lbl_Consulta_Click(object sender, EventArgs e)
        {
            var exibir = new FormExibirPokeDex();
            this.Hide();
            exibir.ShowDialog();
            this.Show();
        }
    }
}
