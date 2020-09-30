using PokemonGo.Context.Models;
using System;
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
            int.TryParse(txt_NoPokemon.Text, out int idPokemon);
            int.TryParse(txt_CP.Text, out int novoCP);
            int.TryParse(txt_HP.Text, out int novoHP);

            var URL = $"http://localhost:5000/Pokebag/alterarStats?idPokemon={idPokemon}&novoCP={novoCP}&novoHP={novoHP}";
            var consumir = new ConsumeAPI<PokemonBag>(); 
            var message = consumir.ConsumePutAPI(URL);
            
            MessageBox.Show(message);

            txt_NoPokemon.Text = "";
            txt_CP.Text = "";
            txt_HP.Text = "";
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
