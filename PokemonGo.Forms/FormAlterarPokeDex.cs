using System;
using System.Net.Http;
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
            int novoCP = Convert.ToInt32(txt_CP.Text);

            var resultRequest = httpClient.PutAsync($"{URL}?idPokemon={idPokemon}&novoCP={novoCP}", null);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            //var resultBody = JsonConvert.DeserializeObject<Result<PokemonBag>>(result.Result);
            //MessageBox.Show(resultBody.Message);
            MessageBox.Show("Stats alterado com sucesso");

            txt_Id.Text = "";
            txt_CP.Text = "";
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
