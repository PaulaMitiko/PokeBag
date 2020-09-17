using Microsoft.Extensions.Caching.Memory;
using PokemonGo.Context;
using PokemonGo.Context.Models;
using PokemonGo.Context.Utilitarios;
using System;
using System.Linq;

namespace Testador
{
    class Program
    {
        static void Main(string[] args)
        {
            PokemonGoContext meusPokemons = new PokemonGoContext();
            
            var aux = meusPokemons.PokeDex.ToList();
            foreach (var item in aux) { Console.WriteLine(item); }

            Console.ReadKey();
            //Utilitarios<PokeDex> auxiliar = new Utilitarios<PokeDex>();
        }
    }
}
