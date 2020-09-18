using Newtonsoft.Json;
using PokemonGo.Context.Models;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace PokemonGo.Forms
{
    public partial class FormInserirPokeBag : Form
    {
        public FormInserirPokeBag()
        {
            InitializeComponent();

            //carregalista();
        }
        /*
        public List<string> teste = new List<string> 
        {"Joschua","Aly","Sone"};
        private void carregalista()
        {
            foreach (var i in teste)
            {
                box_Cidade.Items.Add(i);
            }
        }*/

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            PokemonBag newPokemon = new PokemonBag()
            {
                IdPokemonType = (box_NoPokemon.SelectedIndex)+1,
                CombatPoints = Int32.Parse(txt_CP.Text),
                HealthPoints = Int32.Parse(txt_HP.Text),
                Attack = Int32.Parse(txt_Attack.Text),
                Defense = Int32.Parse(txt_Defense.Text),
                Stamina = Int32.Parse(txt_Stamina.Text),
                IdCidade = (box_Cidade.SelectedIndex)+1,
                DataCaptura = dt_DataCaptura.Value,
                Evento = txt_Evento.Text,
                Sombroso = txt_Sombroso.Text,
                FastAttack = txt_Fast.Text,
                ChargeAttack = txt_Charge.Text,
                DisponivelTroca = false,
                Transferir = false
            };

            if (btn_ShinySim.Checked) newPokemon.Shiny = true;
            if (btn_ShinyNao.Checked) newPokemon.Shiny = false;

            var newPokemonJson = JsonConvert.SerializeObject(newPokemon);
            StringContent content = new StringContent(newPokemonJson, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();
            var URL = "http://localhost:5000/Pokebag/pokemonCapturado";
            var resultRequest = httpClient.PostAsync($"{URL}", content);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            //var resultBody = JsonConvert.DeserializeObject<Result<List<PokemonBag>>>(result.Result);
            MessageBox.Show("Pokémon inserido com sucesso!");

            btn_ShinyNao.Checked = false;
            btn_ShinySim.Checked = false;
            box_Cidade.Text = "";
            box_NoPokemon.Text = "";
            txt_CP.Text = "";
            txt_HP.Text = "";
            txt_Attack.Text = "";
            txt_Defense.Text = "";
            txt_Stamina.Text = "";
            txt_Evento.Text = "";
            txt_Sombroso.Text = "";
            txt_Fast.Text = "";
            txt_Charge.Text = "";
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

