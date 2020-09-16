using Newtonsoft.Json;
using PokeBag.Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace PokemonGo.Forms
{
    public partial class FormInserir : Form
    {
        public FormInserir()
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
            PokemonBag newPokemon = new PokemonBag()
            {
                IdPokemonType = Int32.Parse(box_NoPokemon.Text),
                CombatPoints = Int32.Parse(txt_CP.Text),
                HealthPoints = Int32.Parse(txt_HP.Text),
                Attack = Int32.Parse(txt_Attack.Text),
                Defense = Int32.Parse(txt_Defense.Text),
                Stamina = Int32.Parse(txt_Stamina.Text),
                IdCidade = Int32.Parse(box_Cidade.Text),
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
            var resultRequestPost = httpClient.PostAsync($"{URL}", content);
            resultRequestPost.Wait();
            //Mensagem de certo ou erro usar show.dialog
            this.Close();
        }   
    }
}

