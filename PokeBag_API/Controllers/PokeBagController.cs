using Microsoft.AspNetCore.Mvc;
using PokeDex_Estudo.Context;
using PokeDex_Estudo.Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PokeBag_API.Controllers
{
    [ApiController]
    [Route("Pokebag")]
    public class PokebagController : ControllerBase
    {
        public PokeDexContext meusPokemons = new PokeDexContext();
        //public static List<Bag> meusPokemons = new List<Bag>();

        [HttpPost]
        [Route("pokemonCapturado")] //Inserir um pokémon recém capturado
        public ActionResult InserirPokemonCapturado(Bag pokemon)
        {
            //
            //meubanquinho.Bag.Where(q => q.Id == 1);
            meusPokemons.Add(pokemon);

            return Ok(meusPokemons);
        }

        [HttpGet]
        [Route("pokemonsDaBag")] //Listar todos os pokémons de uma espécie  
        public ActionResult MostrarPokemonsEspecie(int EspeciePokemon) //Vou ter que buscar na tabela PokeDex
                                                                       //o id da especie ao buscar o nome dela.
                                                                       //Mas não precisa disso agora.
        {
            var result = new Result<List<Bag>>();
            try
            {

                result.Data = meusPokemons.Where(x => x.IdPokemonType.Equals(EspeciePokemon)).ToList();


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
        public ActionResult MostrarTodosPokemons(int EspeciePokemon)
        {
            var result = new Result<List<Bag>>();
            try
            {

                result.Data = meusPokemons.ToList();


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
                var result = meusPokemons.RemoveAll(x => x.Id == idPokemon);

                if (result == 0)
                    return BadRequest(Message.NoSuccessTransferir);
                else
                    return Ok(Message.SuccessTransferir);
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
            var result = new Result<List<Bag>>();
            try
            {
                result.Data = meusPokemons.Where(x => x.Id == idPokemon).ToList();

                result.Data.Select(s =>
                {
                    s.CombatPoints = novoCP;
                    s.HealthPoints = novoHP;
                    return s;
                }).ToList();

                return Ok(result);
            }
            catch (Exception ex)
            {
                result.Error = true;
                result.Message = ex.Message;
                return BadRequest(result);
            }

        }
    }
}
