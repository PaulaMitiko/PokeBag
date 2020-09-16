using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGo.Context
{
    public class Utilitarios<T>
    {
        private PokemonGoContext meusPokemons;
        public void Add(T objeto) 
        {
            meusPokemons = new PokemonGoContext();
            using (meusPokemons) 
            {
                meusPokemons.Add(objeto);
                meusPokemons.SaveChanges();
            }
        }
        public void PrintAll(T objeto)
        {
            meusPokemons = new PokemonGoContext();
            using (meusPokemons)
            {
                //meusPokemons.PokemonBag.ToList();
            }
        }
        //public void Add(T objeto)
        //{
       //     meusPokemons = new PokemonGoContext();
        //    using (meusPokemons)
       //     {
      //          meusPokemons.Add(objeto);
      //          meusPokemons.SaveChanges();
       //     }
      //  }
    }
}
