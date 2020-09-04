using System.Collections.Generic;

namespace PokeDex_Estudo.Context.Models
{
    public class PokeDex
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public int CandyForEvolution { get; set; }
        public int BuddyCandyKm { get; set; }
        public int EggKm { get; set; }
        public int CPMax { get; set; }

        public virtual ICollection<Bag> Bag { get; set; } = new HashSet<Bag>();
    }
}
