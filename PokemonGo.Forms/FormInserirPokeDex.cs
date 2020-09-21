using Newtonsoft.Json;
using PokemonGo.Context.Models;
using PokemonGo.Context.Utilitarios;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
            int.TryParse(txt_Id.Text, out int nopoke);
            int.TryParse(box_Egg.Text, out int egg);
            int.TryParse(box_Evol.Text, out int evol);
            int.TryParse(box_Buddy.Text, out int buddy);
            int.TryParse(txt_CPMax.Text, out int cpmax);
            int.TryParse(txt_Lvl35.Text, out int cplvl35);

            try
            {
                PokeDex newPokemon = new PokeDex()
                {
                    Id = nopoke,
                    Name = txt_Name.Text,
                    Type1 = box_Tipo1.Text,
                    Type2 = box_Tipo2.Text,
                    CandyForEvolution = evol,
                    BuddyCandyKm = buddy,
                    EggKm = egg,
                    CPMax = cpmax,
                    CPLvl35 = cplvl35,
                    QtdePokemon = 0
                };

                if (nopoke == 0) 
                {
                    txt_Id.Text = "";
                    MessageBox.Show("O valor inserido como Id não é um número inteiro!");
                }
                if (buddy == 0) 
                {
                    box_Buddy.Text = "";
                    MessageBox.Show("O valor inserido como Buddy km não é um número inteiro!");
                    newPokemon.Id = 0;
                }
                if (cpmax == 0) 
                {
                    txt_CPMax.Text = "";
                    MessageBox.Show("O valor inserido como CP Máximo não é um número inteiro!");
                    newPokemon.Id = 0;
                }
                if (cplvl35 == 0) 
                {
                    txt_Lvl35.Text = "";
                    MessageBox.Show("O valor inserido como CP no level 35 não é um número inteiro!");
                    newPokemon.Id = 0;
                }

                var newPokemonJson = JsonConvert.SerializeObject(newPokemon);
                StringContent content = new StringContent(newPokemonJson, Encoding.UTF8, "application/json");

                var httpClient = new HttpClient();
                var URL = "http://localhost:5000/Pokedex/pokemonNovo";
                var resultRequest = httpClient.PostAsync($"{URL}", content);
                resultRequest.Wait();

                var result = resultRequest.Result.Content.ReadAsStringAsync();
                result.Wait();

                var resultBody = JsonConvert.DeserializeObject<Result<List<PokemonBag>>>(result.Result);
                MessageBox.Show(resultBody.Message);

                if (!resultBody.Error)
                {
                    txt_Id.Text = "";
                    txt_Name.Text = "";
                    box_Tipo1.Text = "";
                    box_Tipo2.Text = "";
                    box_Evol.Text = "";
                    box_Buddy.Text = "";
                    box_Egg.Text = "";
                    txt_CPMax.Text = "";
                }
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
    }
}
