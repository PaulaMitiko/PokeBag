using System.Collections.Generic;

namespace PokeDex_Estudo.Context.Models
{
    public class Cidade
    {
        public int Id { get; set; }
        public string NomeCidade { get; set; }
        public string Pais { get; set; }

        public virtual ICollection<Bag> Bag { get; set; } = new HashSet<Bag>();
    }
}
