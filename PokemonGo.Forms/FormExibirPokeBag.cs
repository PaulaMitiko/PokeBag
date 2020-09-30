using PokemonGo.Context.Models;
using System;
using System.Windows.Forms;

namespace PokemonGo.Forms
{
    public partial class FormExibirPokeBag : Form
    {
        public FormExibirPokeBag()
        {
            InitializeComponent();
            CarregaListaPokemon();
        }

        private void btn_ExibirTodos_Click(object sender, EventArgs e)
        {
            var URL = "http://localhost:5000/Pokebag/todosPokemonsDaBagJoin";
            var consumir = new ConsumeAPI<PokemonBagJoinDex>();
            var data = consumir.ConsumeGetAPI(URL);

            this.dataGridView1.DataSource = data;
            this.dataGridView1.Columns["IndividualValue"].DefaultCellStyle.Format = "P";
            this.dataGridView1.Columns["Cidade"].Visible = false;
            this.dataGridView1.Columns["PokeDex"].Visible = false;
        }

        private void btn_ExibirTipo_Click(object sender, EventArgs e)
        {
            try
            {
                var especie = box_Especie.Text;
                var URL = $"http://localhost:5000/Pokebag/pokemonsDaBagstring?EspeciePokemon={especie}";
                var consumir = new ConsumeAPI<PokemonBagJoinDex>();
                var data = consumir.ConsumeGetAPI(URL);
                
                this.dataGridView1.DataSource = data;
                this.dataGridView1.Columns["IndividualValue"].DefaultCellStyle.Format = "P";
                this.dataGridView1.Columns["Cidade"].Visible = false;
                this.dataGridView1.Columns["PokeDex"].Visible = false;

                box_Especie.Text = "";
                
                if (data.Count == 0) MessageBox.Show("Você ainda não capturou nenhum pokémon dessa espécie!");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void CarregaListaPokemon()
        {
            var URL = "http://localhost:5000/Pokedex/todosPokemonsDaDex";
            var consumir = new ConsumeAPI<PokeDex>();
            var data = consumir.ConsumeGetAPI(URL);

            foreach (var pokemon in data)
            {
                box_Especie.Items.Add(pokemon.Name);
            }
        }
    }
}
