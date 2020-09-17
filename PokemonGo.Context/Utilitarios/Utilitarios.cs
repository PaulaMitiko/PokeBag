using PokemonGo.Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonGo.Context.Utilitarios
{
    public class Utilitarios<T>
    {
        private PokemonGoContext meusPokemons;
        public void AddPokeBag(PokemonBag pokemon) 
        {
            meusPokemons = new PokemonGoContext();
            using (meusPokemons) 
            {
                meusPokemons.PokemonBag.Add(pokemon);
                meusPokemons.SaveChanges();
            }
        }
        public void AddPokeDex(PokeDex newType)
        {
            meusPokemons = new PokemonGoContext();
            using (meusPokemons)
            {
                meusPokemons.PokeDex.Add(newType);
                meusPokemons.SaveChanges();
            }
        }
        public void AddCidade(Cidade newCidade)
        {
            meusPokemons = new PokemonGoContext();
            using (meusPokemons)
            {
                meusPokemons.Cidade.Add(newCidade);
                meusPokemons.SaveChanges();
            }
        }
        public List<PokemonBag> PrintAllPokeBag()
        {
            meusPokemons = new PokemonGoContext();
            
            using (meusPokemons)
            {
                return meusPokemons.PokemonBag.ToList();
            }
        }
        public List<PokeDex> PrintAllPokeDex()
        {
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                return meusPokemons.PokeDex.ToList();
            }
        }
        public List<Cidade> PrintAllCidade()
        {
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                return meusPokemons.Cidade.ToList();
            }
        }
    }
}
