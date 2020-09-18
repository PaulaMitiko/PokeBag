using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PokemonGo.Forms
{
    public partial class FormInicialPokeDex : Form
    {
        public FormInicialPokeDex()
        {
            InitializeComponent();
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            var inserir = new FormInserirPokeDex();
            this.Hide();
            inserir.ShowDialog();
            this.Show();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            var alterar = new FormAlterarPokeDex();
            this.Hide();
            alterar.ShowDialog();
            this.Show();
        }

        private void btn_Exibir_Click(object sender, EventArgs e)
        {
            var exibir = new FormExibirPokeDex();
            this.Hide();
            exibir.ShowDialog();
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
    }
}
