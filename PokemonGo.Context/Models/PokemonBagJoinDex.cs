using System;

namespace PokemonGo.Context.Models
{
    public class PokemonBagJoinDex
    {
        double _individualValue;

        public int Id { get; set; }
        
        public string PokemonType { get; set; }
        public int CombatPoints { get; set; }
        public int HealthPoints { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Stamina { get; set; }
        public double IndividualValue
        {
            get => _individualValue;
            set => _individualValue = (Attack + Defense + Stamina) / 45d;
        }
        public string NomeCidade { get; set; }
        public DateTime DataCaptura { get; set; }
        public bool Shiny { get; set; }
        public string Evento { get; set; }
        public string Sombroso { get; set; }
        public bool DisponivelTroca { get; set; }
        public string FastAttack { get; set; } //futuramente inserir uma attack dex e fazer relação e tornar uma foreign key
        public string ChargeAttack { get; set; }
        public bool Transferir { get; set; }

        public virtual PokeDex PokeDex { get; set; }
        public virtual Cidade Cidade { get; set; }
    }
}
