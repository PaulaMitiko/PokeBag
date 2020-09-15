using System.Collections.Generic;

namespace PokeBag.Context.Models
{
    public class Cidade
    {
        public int Id { get; set; }
        public string NomeCidade { get; set; }
        public string Pais { get; set; }

        public virtual ICollection<PokemonBag> Bag { get; set; } = new HashSet<PokemonBag>();
    }
}
