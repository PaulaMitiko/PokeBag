using PokemonGo.Context.Models;
using System;
using System.Windows.Forms;

namespace PokemonGo.Forms
{
    public partial class FormPrintInserirCidade : Form
    {
        public FormPrintInserirCidade()
        {
            InitializeComponent();
            Exibir();
        }

        private ConsumeAPI<Cidade> consumir = new ConsumeAPI<Cidade>();
        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            Cidade newCidade = new Cidade()
            {
                NomeCidade = txt_Cidade.Text,
                Pais = txt_Pais.Text,
                QtdePokemons = 0
            };

            var URL = "http://localhost:5000/Cidades/cadastrarCidade";
            var resultBody = consumir.ConsumePostAPI(URL, newCidade);
            
            MessageBox.Show(resultBody.Item1);

            txt_Cidade.Text = "";
            txt_Pais.Text = "";

            Exibir();
        }
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            int idCidade = Convert.ToInt32(txt_Id.Text);
            var URL = $"http://localhost:5000/Cidades/excluirCidade?idCidade={idCidade}";
            var resultBody = consumir.ConsumeDeleteAPI(URL);
            
            MessageBox.Show(resultBody.Message);

            txt_Id.Text = "";

            Exibir();
        }

        private void Exibir() 
        {
            var URL = "http://localhost:5000/Cidades/listarCidades";
            var data = consumir.ConsumeGetAPI(URL);

            this.DataGrid.DataSource = data;
            this.DataGrid.Columns["Bag"].Visible = false;
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
