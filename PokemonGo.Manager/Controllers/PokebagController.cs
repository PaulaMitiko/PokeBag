using Microsoft.AspNetCore.Mvc;
using PokemonGo.Context.Models;
using PokemonGo.Context.Utilitarios;
using System;
using System.Collections.Generic;

namespace PokemonGo.Manager.Controllers
{
    [ApiController]
    [Route("Pokebag")]
    public class PokebagController : ControllerBase
    {
        [HttpPost]
        [Route("pokemonCapturado")] //Inserir um pokémon recém capturado - Funcionando
        public ActionResult InserirPokemonCapturado(PokemonBag pokemon)
        {
            var result = new Result<PokemonBag>();
            try
            {
                Utilitarios<PokemonBag> auxiliar = new Utilitarios<PokemonBag>();
                auxiliar.AddPokeBag(pokemon);
                result.Error = false;
                result.Message = Message.SuccessAdd;

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
        [Route("pokemonsDaBag")] //Listar todos os pokémons de uma espécie  - Funcionando
        public ActionResult MostrarPokemonsEspecie(int EspeciePokemon) //Vou ter que buscar na tabela PokeDex
                                                                       //o id da especie ao buscar o nome dela.
                                                                       //Mas não precisa disso agora.
        {
            var result = new Result<List<PokemonBag>>();
            try
            {
                Utilitarios<PokemonBag> auxiliar = new Utilitarios<PokemonBag>();
                result.Data = auxiliar.PrintPokeBag(EspeciePokemon);

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
        [Route("todosPokemonsDaBag")] //Listar todos os pokémons - Funcionando
        public ActionResult MostrarTodosPokemons()
        {
            var result = new Result<List<PokemonBag>>();
            try
            {
                Utilitarios<PokemonBag> auxiliar = new Utilitarios<PokemonBag>();
                result.Data = auxiliar.PrintAllPokeBag();

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
        [Route("pokemonsPorCidade")] //Listar todos os pokémons de uma cidade  - Funcionando
        public ActionResult MostrarPokemonsCidade(int idCidade) 
        {
            var result = new Result<List<PokemonBag>>();
            try
            {
                Utilitarios<PokemonBag> auxiliar = new Utilitarios<PokemonBag>();
                result.Data = auxiliar.PrintPokeBagCidade(idCidade);

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

        [HttpDelete]
        [Route("pokemonTransferido")] //Excluir um pokémon que foi transferido - Funcionando
        public ActionResult RemoverPokemonTransferido(int idPokemon) //Vou ter que achar uma forma de encontrar o id
                                                                     //do pokémon a ser transferido. Mas não agora.
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
        }


        [HttpPut] 
        [Route("alterarStats")] //Alterar os stats de um pokémon - Funcionando
        public ActionResult AlterarStatsDoPokemon(int idPokemon, int novoCP, int novoHP)
        {
            var result = new Result<List<PokemonBag>>();

            try
            {
                Utilitarios<PokemonBag> auxiliar = new Utilitarios<PokemonBag>();
                result.Message = auxiliar.AlterarPokeBag(idPokemon, novoCP, novoHP);
                return Ok(result);
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("alterarTransferir")] //Alterar os stats de um pokémon - Funcionando
        public ActionResult AlterarTransferirDoPokemon(int idPokemon, bool novoStatus)
        {
            var result = new Result<List<PokemonBag>>();

            try
            {
                Utilitarios<PokemonBag> auxiliar = new Utilitarios<PokemonBag>();
                result.Message = auxiliar.AlterarPokeBagTransferir(idPokemon, novoStatus);
                return Ok(result);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
