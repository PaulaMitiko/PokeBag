using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PokemonGo.Forms
{
    public partial class FormInicialPokeBag : Form
    {
        public FormInicialPokeBag()
        {
            InitializeComponent();
        }

        private void bnt_Inserir_Click(object sender, EventArgs e)
        {
            var inserir = new FormInserirPokeBag();
            this.Hide();
            inserir.ShowDialog();
            this.Show();
        }
    }
}
