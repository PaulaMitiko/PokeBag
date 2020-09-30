using PokemonGo.Context.Models;
using System;
using System.Windows.Forms;

namespace PokemonGo.Forms
{
    public partial class FormExibirPokeDex : Form
    {
        public FormExibirPokeDex()
        {
            InitializeComponent();
            CarregaListaPokemon();
        }

        private ConsumeAPI<PokeDex> consumir = new ConsumeAPI<PokeDex>();

        private void btn_Todos_Click(object sender, EventArgs e)
        {
            var URL = "http://localhost:5000/Pokedex/todosPokemonsDaDex";
            var data = consumir.ConsumeGetAPI(URL);
            
            this.dataGridView1.DataSource = data;
            this.dataGridView1.Columns["Bag"].Visible = false;
        }

        private void btn_Id_Click(object sender, EventArgs e)
        {
            var URL = "http://localhost:5000/Pokedex/todosPokemonsDaDex";
            var data = consumir.ConsumeGetAPI(URL);
          
            int idPokemon = 0;
            foreach (var item in data)
            {
                if (item.Name == box_Id.Text)
                {
                    idPokemon = item.Id;
                }
            }

            URL = $"http://localhost:5000/Pokedex/dexDeUmPokemon?EspeciePokemon={idPokemon}";
            data = consumir.ConsumeGetAPI(URL);

            this.dataGridView1.DataSource = data;
            this.dataGridView1.Columns["Bag"].Visible = false;

            if (data.Count == 0) MessageBox.Show("Você ainda não registrou esse pokémon!");

            box_Id.Text = "";
        }

        private void btn_Tipo_Click(object sender, EventArgs e)
        {
            var URL = $"http://localhost:5000/Pokedex/pokemonsPorTipo?tipoPokemon={box_Tipo.Text}";
            var data = consumir.ConsumeGetAPI(URL);

            this.dataGridView1.DataSource = data;
            this.dataGridView1.Columns["Bag"].Visible = false;

            box_Tipo.Text = "";

            if (data.Count == 0) MessageBox.Show("Você ainda não registrou nenhum pokémon desse tipo!");
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
            var data = consumir.ConsumeGetAPI(URL);

            foreach (var pokemon in data)
            {
                box_Id.Items.Add(pokemon.Name);
            }
        }
    }
}
