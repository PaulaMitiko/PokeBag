using Newtonsoft.Json;
using PokemonGo.Context.Models;
using PokemonGo.Context.Utilitarios;
using System;
using System.Collections.Generic;
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

            carregalista();
        }

        public List<string> teste = new List<string> 
        {"Joschua","Aly","Sone"};
        private void carregalista()
        {
            foreach (var i in teste)
            {
                box_Cidade.Items.Add(i);
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            int.TryParse(box_NoPokemon.Text, out int idPoke);
            int.TryParse(box_Cidade.Text, out int idCidade);

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

            this.Close();
        }   
    }
}

