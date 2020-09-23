using Microsoft.AspNetCore.Mvc;
using PokemonGo.Context.Models;
using PokemonGo.Context.Utilitarios;
using System;
using System.Collections.Generic;

namespace PokemonGo.Manager.Controllers
{
    [ApiController]
    [Route("Pokedex")]
    public class PokedexController : ControllerBase
    {
        [HttpPost]
        [Route("pokemonNovo")] //Inserir um pokémon na PokeDex
        public ActionResult InserirPokemon(PokeDex pokemon)
        {
            var result = new Result<PokeDex>();
            try
            {
                Utilitarios<PokeDex> auxiliar = new Utilitarios<PokeDex>();
                result.Error = auxiliar.AddPokeDex(pokemon);
                if (!result.Error)
                { 
                    result.Message = Message.SuccessAdd;
                }
                else
                {
                    result.Message = Message.NoSuccessAdd;
                    result.Status = System.Net.HttpStatusCode.InternalServerError;
                }
                return Ok(result);
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
        [Route("dexDeUmPokemon")] //Listar infos de um pokémon
        public ActionResult MostrarEspecie(int EspeciePokemon) 
        {
            var result = new Result<List<PokeDex>>();
            try
            {
                Utilitarios<PokeDex> auxiliar = new Utilitarios<PokeDex>();
                result.Data = auxiliar.PrintPokeDex(EspeciePokemon);

                if (result.Data.Count == 0)
                {
                    result.Error = true;
                    result.Message = Message.NoPokemonSpecie;
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
        [Route("todosPokemonsDaDex")] //Listar todos os pokémons
        public ActionResult MostrarTodosPokemons()
        {
            var result = new Result<List<PokeDex>>();
            try
            {
                Utilitarios<PokeDex> auxiliar = new Utilitarios<PokeDex>();
                result.Data = auxiliar.PrintAllPokeDex();

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

        [HttpGet]
        [Route("pokemonsPorTipo")] //Listar todos os pokémons de um tipo específico
        public ActionResult MostrarPokemonsTipo(string tipoPokemon)
        {
            var result = new Result<List<PokeDex>>();
            try
            {
                Utilitarios<PokeDex> auxiliar = new Utilitarios<PokeDex>();
                result.Data = auxiliar.PrintPokeDexType(tipoPokemon);

                if (result.Data.Count == 0)
                {
                    result.Error = true;
                    result.Message = Message.NoPokemonTypes;
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

        [HttpPut] 
        [Route("alterarDados")] //Alterar os dados de um pokémon 
        public ActionResult AlterarStatsDoPokemon(int idPokemon, int novoCP, int novoLvl35, int novoEgg)
        {
            var result = new Result<List<PokeDex>>();

            try
            {
                Utilitarios<PokeDex> auxiliar = new Utilitarios<PokeDex>();
                result.Error = auxiliar.AlterarPokeDex(idPokemon, novoCP, novoLvl35, novoEgg);
                result.Message = result.Error ? Message.NoSuccessAlter : Message.SuccessAlter;
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(Message.NoSuccess + ex.Message);
            }

        }

        [HttpPut]
        [Route("atualizarContagem")] //Atualizar contagem
        public ActionResult AlterarContagem(int idPokemon, int novaContagem)
        {
            var result = new Result<List<PokeDex>>();

            try
            {
                Utilitarios<PokeDex> auxiliar = new Utilitarios<PokeDex>();
                result.Error = auxiliar.AlterarContagemPokemon(idPokemon, novaContagem);
                result.Message = result.Error ? Message.NoSuccessAlter : Message.SuccessAlter;
                return Ok(result);

            }
            catch (Exception ex)
            {
                return BadRequest(Message.NoSuccess + ex.Message);
            }

        }

        /*Não se deleta pokemon da PokeDex .-.
        [HttpDelete]
        [Route("pokemonTransferido")] 
        public ActionResult RemoverPokemonTransferido(int idPokemon) 
        {
            var result = new Result<List<PokemonBag>>();
            try
            {
                Utilitarios<PokemonBag> auxiliar = new Utilitarios<PokemonBag>();
                result.Message = auxiliar.TransferirPokeBag(idPokemon);
             
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }*/
    }
}
