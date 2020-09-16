using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace PokeBagForm
{
    public partial class FormCapturar : Form
    {
        public FormCapturar()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            var caminho = "C:\\Users\\paula.heller\\Desktop\\Teste.txt";

            PokemonBag newPokemon = new PokemonBag()
            {
                IdPokemonType = Int32.Parse(box_NoPokemon.Text),
                CombatPoints = Int32.Parse(txt_CP.Text),
                HealthPoints = Int32.Parse(txt_HP.Text),
                Attack = Int32.Parse(txt_Attack.Text),
                Defense = Int32.Parse(txt_Defense.Text),
                Stamina = Int32.Parse(txt_Stamina.Text),
                IdCidade = Int32.Parse(box_Cidade.Text),
                DataCaptura = dt_Data.Value,
                Shiny = false,
                Evento = txt_Evento.Text,
                Sombroso = txt_Sombroso.Text,
                FastAttack = txt_Fast.Text,
                ChargeAttack = txt_Charge.Text,
                DisponivelTroca = false,
                Transferir = false
            };

            using (StreamWriter writer = new StreamWriter(caminho, true))
            {
                var texto = JsonConvert.SerializeObject(newPokemon);
                writer.WriteLine(texto);
            }
            this.Close();
        }
        /*
private void btn_Salvar_Click(object sender, EventArgs e)
{
   var caminho = "C:\\Users\\paula.heller\\Desktop\\Teste.txt";
   var newPokemon = "teste";
   PokemonBag newPokemon = new PokemonBag();
   {
       IdPokemonType = Int32.Parse(box_NoPokemon.Text),
       CombatPoints = Int32.Parse(txt_CP.Text),
       HealthPoints = Int32.Parse(txt_HP.Text),
       Attack = Int32.Parse(txt_Attack.Text),
       Defense = Int32.Parse(txt_Defense.Text),
       Stamina = Int32.Parse(txt_Stamina.Text),
       IdCidade = Int32.Parse(box_Cidade.Text),
       DataCaptura = dt_Data.Value,
       Shiny = false,
       Evento = txt_Evento.Text,
       Sombroso = txt_Sombroso.Text,
       FastAttack = txt_Fast.Text,
       ChargeAttack = txt_Charge.Text,
       DisponivelTroca = false,
       Transferir = false
   };

   using (StreamWriter writer = new StreamWriter(caminho, true))
   {
       var texto = JsonConvert.SerializeObject(newPokemon);
       writer.WriteLine(texto);
   }

   var newPokemonJson = JsonConvert.SerializeObject(newPokemon);
   StringContent content = new StringContent(newPokemonJson, Encoding.UTF8, "application/json");

   var httpClient = new HttpClient();
   var URL = "http://localhost:5000/Pokebag/pokemonCapturado";
   var resultRequestPost = httpClient.PostAsync($"{URL}",content);
   resultRequestPost.Wait();


   this.Close();
}*/
    }
}
