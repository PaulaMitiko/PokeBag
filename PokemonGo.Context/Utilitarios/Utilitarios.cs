using PokemonGo.Context.Models;
using System.Collections.Generic;
using System.Linq;

namespace PokemonGo.Context.Utilitarios
{
    public class Utilitarios<T>
    {
        private PokemonGoContext meusPokemons;
        //########################//
        //ADICIONAR ITENS AO BANCO//
        //########################//
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
        //##################//
        //PRINTAR ESPECÍFICO//
        //##################//
        public List<PokemonBag> PrintPokeBag(int especiePokemon) //Testado - OK
        {
            meusPokemons = new PokemonGoContext();
            
            using (meusPokemons)
            {
                return meusPokemons.PokemonBag.Where(x => x.IdPokemonType.Equals(especiePokemon)).ToList();
            }
        }

        public List<PokeDex> PrintPokeDex(int especiePokemon) 
        {
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                return meusPokemons.PokeDex.Where(x => x.Id.Equals(especiePokemon)).ToList();
            }
        }

        public List<PokeDex> PrintPokeDexType(string tipoPokemon)
        {
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                return meusPokemons.PokeDex.Where(x => x.Type1.Equals(tipoPokemon)||x.Type2.Equals(tipoPokemon)).ToList();
            }
        }

        public List<Cidade> PrintCidadeEspecifica(int idCidade)
        {
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                return meusPokemons.Cidade.Where(x => x.Id.Equals(idCidade)).ToList();
            }
        }
        //#############//
        //PRINTAR TODOS//
        //#############//
        public List<PokemonBag> PrintAllPokeBag() //Testado - Ok
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

        //##################//
        //EXCLUIR UM POKEMON//
        //##################//
        public string TransferirPokeBag(int idPokemon) //Funcionando
        {
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                var pokemonTransferido = meusPokemons.PokemonBag.FirstOrDefault(q => q.Id == idPokemon);

                if (pokemonTransferido != null)
                {
                    meusPokemons.PokemonBag.Remove(pokemonTransferido);
                    meusPokemons.SaveChanges();
                    return Message.SuccessTransferir;
                }
                else
                    return Message.NoSuccessTransferir;
            }
        }
        public string ExcluirCidade(int idCidade) 
        {
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                var cidadeExcluida = meusPokemons.Cidade.FirstOrDefault(q => q.Id == idCidade);

                if (cidadeExcluida != null)
                {
                    meusPokemons.Cidade.Remove(cidadeExcluida);
                    meusPokemons.SaveChanges();
                    return Message.SuccessTransferir;
                }
                else
                    return Message.NoSuccessTransferir;
            }
        }

        //#############//
        //ALTERAR STATS//
        //#############//
        public string AlterarPokeBag(int idPokemon, int novoCP, int novoHP) //Funcionando
        {
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                var pokemon = meusPokemons.PokemonBag.FirstOrDefault(q => q.Id == idPokemon);

                if (pokemon != null)
                {
                    pokemon.CombatPoints = novoCP;
                    pokemon.HealthPoints = novoHP;
                    meusPokemons.SaveChanges();
                    return Message.SuccessAlter;
                }
                else
                    return Message.NoSuccessAlter;
            }
        }

        public string AlterarPokeDex(int idPokemon, int novoCP)
        {
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                var pokemon = meusPokemons.PokeDex.FirstOrDefault(q => q.Id == idPokemon);

                if (pokemon != null)
                {
                    pokemon.CPMax = novoCP;
                    meusPokemons.SaveChanges();
                    return Message.SuccessAlter;
                }
                else
                    return Message.NoSuccessAlter;
            }
        }

        public string AlterarContagemPokemon(int idPokemon, int novaContagem)
        {
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                var pokemon = meusPokemons.PokeDex.FirstOrDefault(q => q.Id == idPokemon);

                if (pokemon != null)
                {
                    pokemon.QtdePokemon = novaContagem;
                    meusPokemons.SaveChanges();
                    return Message.SuccessAlter;
                }
                else
                    return Message.NoSuccessAlter;
            }
        }

        public string AlterarCidade(int idCidade, int novaContagem)
        {
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                var cidade = meusPokemons.Cidade.FirstOrDefault(q => q.Id == idCidade);

                if (cidade != null)
                {
                    cidade.QtdePokemons = novaContagem;
                    meusPokemons.SaveChanges();
                    return Message.SuccessAlter;
                }
                else
                    return Message.NoSuccessAlter;
            }
        }
    }
}
