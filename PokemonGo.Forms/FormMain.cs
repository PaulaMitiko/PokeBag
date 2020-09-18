using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PokemonGo.Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btn_PokeBag_Click(object sender, EventArgs e)
        {
            var pokeBag = new FormInicialPokeBag();
            this.Hide();
            pokeBag.ShowDialog();
            this.Show();
        }

        private void btn_PokeDex_Click(object sender, EventArgs e)
        {
            var pokeDex = new FormInicialPokeBag();
            this.Hide();
            pokeDex.ShowDialog();
            this.Show();
        }

        private void btn_Cidade_Click(object sender, EventArgs e)
        {
            var cidade = new FormPrintInserirCidade();
            this.Hide();
            cidade.ShowDialog();
            this.Show();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
