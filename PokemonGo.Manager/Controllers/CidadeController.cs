using Microsoft.AspNetCore.Mvc;
using PokemonGo.Context.Models;
using PokemonGo.Context.Utilitarios;
using System;
using System.Collections.Generic;

namespace PokemonGo.Manager.Controllers
{
    [ApiController]
    [Route("Cidades")]
    public class CidadesController : ControllerBase
    {
        [HttpPost]
        [Route("cadastrarCidade")] //Inserir uma cidade nova
        public ActionResult InserirCidade(Cidade cidade)
        {
            var result = new Result<Cidade>();
            try
            {
                Utilitarios<Cidade> auxiliar = new Utilitarios<Cidade>();
                auxiliar.AddCidade(cidade);
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
        [Route("listarCidades")] //Listar cidades cadastradas
        public ActionResult MostrarCidades() 
        {
            var result = new Result<List<Cidade>>();
            try
            {
                Utilitarios<Cidade> auxiliar = new Utilitarios<Cidade>();
                result.Data = auxiliar.PrintAllCidade();

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
        [Route("listarCidadesPais")] //Listar cidades de um país específico
        public ActionResult MostrarCidadesPais(string pais)
        {
            var result = new Result<List<Cidade>>();
            try
            {
                Utilitarios<Cidade> auxiliar = new Utilitarios<Cidade>();
                result.Data = auxiliar.PrintCidadePais(pais);

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
        [Route("excluirCidade")]  //Deletar cidade vazia
        public ActionResult RemoverCidade(int idCidade) 
        {
            var result = new Result<List<Cidade>>();
            try
            {
                Utilitarios<Cidade> auxiliar = new Utilitarios<Cidade>();
                result.Message = auxiliar.ExcluirCidade(idCidade);
             
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /* Não existem dados a serem alterados em cidade
        [HttpPut] 
        [Route("alterarDados")]
        public ActionResult AlterarStatsDoPokemon(int idPokemon, int novoCP)
        {
            var result = new Result<List<PokeDex>>();

            try
            {
                Utilitarios<PokeDex> auxiliar = new Utilitarios<PokeDex>();
                result.Message = auxiliar.AlterarPokeDex(idPokemon, novoCP);
                return Ok(result);
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }*/
    }
}
