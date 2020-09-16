using Microsoft.AspNetCore.Mvc;
using PokeBag.Context.Models;
using PokeBagAPI;
using PokemonGo.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PokeBag_API.Controllers
{
    [ApiController]
    [Route("Pokebag")]
    public class PokebagController : ControllerBase
    {
        //public static List<PokemonBag> meusPokemons = new List<PokemonBag>();
        public PokemonGoContext meusPokemons = new PokemonGoContext(); //tirar isso depois

        [HttpPost]
        [Route("pokemonCapturado")] //Inserir um pokémon recém capturado
        public ActionResult InserirPokemonCapturado(PokemonBag pokemon)
        {
            /*meusPokemons.Add(pokemon);
            meusPokemons.SaveChanges();*/
            Utilitarios<PokemonBag> variaveldoJosh = new Utilitarios<PokemonBag>();
            variaveldoJosh.Add(pokemon);

            return Ok(meusPokemons);
        }

        [HttpGet]
        [Route("pokemonsDaBag")] //Listar todos os pokémons de uma espécie  
        public ActionResult MostrarPokemonsEspecie(int EspeciePokemon) //Vou ter que buscar na tabela PokeDex
                                                                       //o id da especie ao buscar o nome dela.
                                                                       //Mas não precisa disso agora.
        {
            var result = new Result<List<PokemonBag>>();
            try
            {
                result.Data = meusPokemons.PokemonBag.Where(x => x.IdPokemonType.Equals(EspeciePokemon)).ToList();

                if (result.Data.Count == 0)
                {
                    result.Error = true;
                    result.Message = Message.NoPokemonType;
                    result.Status = System.Net.HttpStatusCode.InternalServerError;

                    return BadRequest(result);
                }
                else
                {
                    result.Error = false;
                    result.Message = Message.SuccessType;
                    result.Status = System.Net.HttpStatusCode.InternalServerError;

                    return Ok(result);
                }
            }
            catch (Exception ex)
            {
                result.Error = true;
                result.Message = Message.NoSuccess + ex.Message;
                result.Status = System.Net.HttpStatusCode.InternalServerError;

                return NotFound(result);
            }
        }

        [HttpGet]
        [Route("todosPokemonsDaBag")] //Listar todos os pokémons 
        public ActionResult MostrarTodosPokemons()
        {
            var result = new Result<List<PokemonBag>>();
            try
            {
                result.Data = meusPokemons.PokemonBag.ToList();

                if (result.Data.Count == 0)
                {
                    result.Error = true;
                    result.Message = Message.NoPokemon;
                    result.Status = System.Net.HttpStatusCode.InternalServerError;

                    return BadRequest(result);
                }
                else
                {
                    result.Error = false;
                    result.Message = Message.Success;
                    result.Status = System.Net.HttpStatusCode.InternalServerError;

                    return Ok(result);
                }
            }
            catch (Exception ex)
            {
                result.Error = true;
                result.Message = Message.NoSuccess + ex.Message;
                result.Status = System.Net.HttpStatusCode.InternalServerError;

                return NotFound(result);
            }
        }

        [HttpDelete]
        [Route("pokemonTransferido")] //Excluir um pokémon que foi transferido
        public ActionResult RemoverPokemonTransferido(int idPokemon) //Vou ter que achar uma forma de encontrar o id
                                                                     //do pokémon a ser transferido. Mas não agora.
        {
            try
            {
                var pokemonTransferido = meusPokemons.PokemonBag.FirstOrDefault(q => q.Id == idPokemon);

                //var result = meusPokemons.RemoveAll(x => x.Id == idPokemon);

                //if (result == 0)
                    //return BadRequest(Message.NoSuccessTransferir);
                
                if (pokemonTransferido != null)
                {
                    meusPokemons.PokemonBag.Remove(pokemonTransferido);
                    meusPokemons.SaveChanges();
                    return BadRequest(Message.SuccessTransferir);
                }
                else
                    return Ok(Message.NoSuccessTransferir);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPut]
        [Route("alterarStats")]
        public ActionResult AlterarStatsDoPokemon(int idPokemon, int novoCP, int novoHP)
        {
            var pokemon = meusPokemons.PokemonBag.FirstOrDefault(q => q.Id == idPokemon);
            //var result = new Result<List<PokemonBag>>();

            try
            {
                /*result.Data = meusPokemons.PokemonBag.Where(x => x.Id == idPokemon).ToList();

                result.Data.Select(s =>
                {
                    s.CombatPoints = novoCP;
                    s.HealthPoints = novoHP;
                    return s;
                }).ToList();

                return Ok(result);
                */
                if (!(pokemon is null))
                {
                    pokemon.CombatPoints = novoCP;
                    pokemon.HealthPoints = novoHP;
                    meusPokemons.SaveChanges();
                    return Ok(Message.SuccessAlter);
                }
                else
                {
                    return Ok(Message.NoSuccessAlter);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
