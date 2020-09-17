using System.Collections.Generic;

namespace PokemonGo.Context.Models
{
    public class Cidade
    {
        public int Id { get; set; }
        public string NomeCidade { get; set; }
        public string Pais { get; set; }

        public virtual ICollection<PokemonBag> Bag { get; set; } = new HashSet<PokemonBag>(); //Josh pediu pra por num ctor
    }
}
