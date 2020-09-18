using Newtonsoft.Json;
using PokemonGo.Context.Models;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace PokemonGo.Forms
{
    public partial class FormInserirPokeDex : Form
    {
        public FormInserirPokeDex()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            int.TryParse(box_Egg.Text, out int egg);
            int.TryParse(box_Evol.Text, out int evol);

            PokeDex newPokemon = new PokeDex()
            {
                Id = int.Parse(txt_Id.Text),
                Name = txt_Name.Text,
                Type1 = box_Tipo1.Text,
                Type2 = box_Tipo2.Text,
                CandyForEvolution = evol,
                BuddyCandyKm = int.Parse(box_Buddy.Text),
                EggKm = egg,
                CPMax = int.Parse(txt_CPMax.Text),
                CPLvl35 = int.Parse(txt_Lvl35.Text)
            };
            var newPokemonJson = JsonConvert.SerializeObject(newPokemon);
            StringContent content = new StringContent(newPokemonJson, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();
            var URL = "http://localhost:5000/Pokedex/pokemonNovo";
            var resultRequest = httpClient.PostAsync($"{URL}", content);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            //var resultBody = JsonConvert.DeserializeObject<Result<List<PokemonBag>>>(result.Result);
            MessageBox.Show("Pokémon inserido com sucesso!");

            txt_Id.Text = "";
            txt_Name.Text = "";
            box_Tipo1.Text = "";
            box_Tipo2.Text = "";
            box_Evol.Text = "";
            box_Buddy.Text = "";
            box_Egg.Text = "";
            txt_CPMax.Text = "";
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
