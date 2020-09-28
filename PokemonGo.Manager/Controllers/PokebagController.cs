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
                result.Error = auxiliar.AddPokeBag(pokemon);
                result.Message = result.Error ? Message.NoSuccessAdd : Message.SuccessAdd;

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
        [Route("pokemonsDaBagstring")] //Listar todos os pokémons de uma espécie  - Funcionando
        public ActionResult MostrarPokemonsEspecie(string EspeciePokemon) 
        {
            var result = new Result<List<PokemonBagJoinDex>>();
            try
            {
                Utilitarios<PokemonBagJoinDex> auxiliar = new Utilitarios<PokemonBagJoinDex>();
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
        [Route("pokemonsDaBag")] //Listar todos os pokémons de uma espécie  - Funcionando
        public ActionResult MostrarPokemonsEspecie(int EspeciePokemon) 
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
        [Route("todosPokemonsDaBagJoin")] //Listar todos os pokémons - Funcionando
        public ActionResult MostrarTodosPokemonsJoin()
        {
            var result = new Result<List<PokemonBagJoinDex>>();
            try
            {
                Utilitarios<PokemonBagJoinDex> auxiliar = new Utilitarios<PokemonBagJoinDex>();
                result.Data = auxiliar.PrintAllPokeBagJoin();

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
                    result.Message = Message.NoPokemonCity;
                    result.Status = System.Net.HttpStatusCode.InternalServerError;

                    return BadRequest(result);
                }
                else
                {
                    result.Error = false;
                    result.Message = Message.SuccessPokemonCity;
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
        public ActionResult RemoverPokemonTransferido(int idPokemon) 
        {
            var result = new Result<List<PokemonBag>>();
            try
            {
                Utilitarios<PokemonBag> auxiliar = new Utilitarios<PokemonBag>();
                result.Data = auxiliar.TransferirPokeBag(idPokemon);

                if (result.Data is null)
                {
                    result.Error = true;
                    result.Message = Message.NoSuccessTransferir;
                }
                else 
                {
                    result.Error = false;
                    result.Message = Message.SuccessTransferir;
                }
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
                result.Error = auxiliar.AlterarPokeBag(idPokemon, novoCP, novoHP);
                result.Message = result.Error ? Message.NoSuccessAlter : Message.SuccessAlter;

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpPut]
        [Route("alterarTransferir")] //Alterar o status de transferir de um pokémon - Funcionando
        public ActionResult AlterarTransferirDoPokemon(int idPokemon, bool novoStatus)
        {
            var result = new Result<List<PokemonBag>>();

            try
            {
                Utilitarios<PokemonBag> auxiliar = new Utilitarios<PokemonBag>();
                result.Error = auxiliar.AlterarPokeBagTransferir(idPokemon, novoStatus);
                result.Message = result.Error ? Message.NoSuccessAlter : Message.SuccessAlter;
                
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("sugestaoTransferir")] //Listar todos os pokémons para transferir  - Funcionando
        public ActionResult MostrarPokemonsTransferir() 
        {
            var result = new Result<List<PokemonBagJoinDex>>();
            try
            {
                Utilitarios<PokemonBagJoinDex> auxiliar = new Utilitarios<PokemonBagJoinDex>();
                result.Data = auxiliar.PrintPokeBagTransf();

                if (result.Data.Count == 0)
                {
                    result.Error = true;
                    result.Message = Message.NoSugestion;
                    result.Status = System.Net.HttpStatusCode.InternalServerError;

                    return BadRequest(result);
                }
                else
                {
                    result.Error = false;
                    result.Message = Message.SuccessSugestion;
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
        [Route("sugestaoTroca")] //Listar todos os pokémons para transferir  - Funcionando
        public ActionResult MostrarPokemonsTroca()
        {
            var result = new Result<List<PokemonBagJoinDex>>();
            try
            {
                Utilitarios<PokemonBagJoinDex> auxiliar = new Utilitarios<PokemonBagJoinDex>();
                result.Data = auxiliar.PrintPokeBagTroca();

                if (result.Data.Count == 0)
                {
                    result.Error = true;
                    result.Message = Message.NoSugestion;
                    result.Status = System.Net.HttpStatusCode.InternalServerError;

                    return BadRequest(result);
                }
                else
                {
                    result.Error = false;
                    result.Message = Message.SuccessSugestion;
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
    }
}
