using PokemonGo.Context.Models;
using System;
using System.Text.RegularExpressions;
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
            int.TryParse((Regex.Match(box_Egg.Text,@"\d+").Value), out int egg);
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

                var URL = "http://localhost:5000/Pokedex/pokemonNovo";
                var consumir = new ConsumeAPI<PokeDex>();
                var resultBody = consumir.ConsumePostAPI(URL, newPokemon);
               
                MessageBox.Show(resultBody.Item1);

                if (!resultBody.Item2)
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
