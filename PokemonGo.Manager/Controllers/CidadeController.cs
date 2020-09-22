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
                result.Error = auxiliar.AddCidade(cidade);
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
                    result.Message = Message.NoCity;
                    result.Status = System.Net.HttpStatusCode.InternalServerError;

                    return BadRequest(result);
                }
                else
                {
                    result.Error = false;
                    result.Message = Message.SuccessCity;
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
        [Route("listarCidadeEspecifica")] //Listar informações de uma cidade especifica
        public ActionResult MostrarCidadesPais(int idCidade)
        {
            var result = new Result<List<Cidade>>();
            try
            {
                Utilitarios<Cidade> auxiliar = new Utilitarios<Cidade>();
                result.Data = auxiliar.PrintCidadeEspecifica(idCidade);

                if (result.Data.Count == 0)
                {
                    result.Error = true;
                    result.Message = Message.NoOneCity;
                    result.Status = System.Net.HttpStatusCode.InternalServerError;

                    return BadRequest(result);
                }
                else
                {
                    result.Error = false;
                    result.Message = Message.SuccessCity;
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
                result.Error = auxiliar.ExcluirCidade(idCidade);
                result.Message = result.Error ? Message.NoTransferCity : Message.SuccessTransferCity;

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut] 
        [Route("atualizarContagem")] //Atualizar contagem
        public ActionResult AlterarContagem(int idCidade, int novaContagem)
        {
            var result = new Result<List<Cidade>>();

            try
            {
                Utilitarios<Cidade> auxiliar = new Utilitarios<Cidade>();
                result.Error = auxiliar.AlterarCidade(idCidade, novaContagem);
                result.Message = result.Error ? Message.NoTransferCity : Message.SuccessCount;

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
