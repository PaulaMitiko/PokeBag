using PokemonGo.Context.Models;
using System;
using System.Windows.Forms;

namespace PokemonGo.Forms
{
    public partial class FormExibirSugestao : Form
    {
        public FormExibirSugestao()
        {
            InitializeComponent();
        }

        private void btn_Troca_Click(object sender, EventArgs e)
        {
            var URL = "http://localhost:5000/Pokebag/sugestaoTroca";
            var consumir = new ConsumeAPI<PokemonBagJoinDex>();
            var data = consumir.ConsumeGetAPI(URL);
            
            this.dataGridView1.DataSource = data;
            this.dataGridView1.Columns["IndividualValue"].DefaultCellStyle.Format = "P";
            this.dataGridView1.Columns["Cidade"].Visible = false;
            this.dataGridView1.Columns["PokeDex"].Visible = false;
        }
        private void btn_Transf_Click(object sender, EventArgs e)
        {
            var URL = "http://localhost:5000/Pokebag/sugestaoTransferir";
            var consumir = new ConsumeAPI<PokemonBagJoinDex>();
            var data = consumir.ConsumeGetAPI(URL);

            this.dataGridView1.DataSource = data;
            this.dataGridView1.Columns["IndividualValue"].DefaultCellStyle.Format = "P";
            this.dataGridView1.Columns["Cidade"].Visible = false;
            this.dataGridView1.Columns["PokeDex"].Visible = false;
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            var excluir = new FormExcluirPokeBag();
            this.Hide();
            excluir.ShowDialog();
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

