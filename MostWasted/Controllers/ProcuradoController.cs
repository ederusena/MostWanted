using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using MostWanted.Models;
using MostWanted.Repository;
using MostWanted.Repository.Context;
using System.Net;

namespace MostWanted.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProcuradoController : ControllerBase
    {
        private readonly ProcuradoRepository procuradoRepository;
        
        public ProcuradoController(DataBaseContext context)
        {
            procuradoRepository = new ProcuradoRepository(context);
        }

        [HttpGet]
        public ActionResult<IList<ProcuradoModel>> Get()
        {
            try
            {
                var lista = procuradoRepository.Listar();

                if (lista != null)
                {
                    return Ok(lista);
                }
                else
                {
                    return NotFound();
                }

            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }

        [HttpGet("{id:int}")]
        public ActionResult<ProcuradoModel> Get([FromRoute] int id)
        {
            try
            {
                var procuradoModel = procuradoRepository.Consultar(id);
                if (procuradoModel != null)
                {
                    return Ok(procuradoModel);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("nome/{nome}")]
        public ActionResult<ProcuradoModel> Get([FromRoute] string nome)
        {
            try
            {
                var procuradoModel = procuradoRepository.PorNome(nome);
                if (procuradoModel != null)
                {
                    return Ok(procuradoModel);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("agencia/{agencia}")]
        public ActionResult<ProcuradoModel> GetAgencia([FromRoute] string agencia)
        {
            try
            {
                var procuradoModel = procuradoRepository.PorAgencia(agencia);
                if (procuradoModel != null)
                {
                    return Ok(procuradoModel);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("nacionalide/{nacionalidade}")]
        public ActionResult<ProcuradoModel> GetNacionalidade([FromRoute] string nacionalidade)
        {
            try
            {
                var procuradoModel = procuradoRepository.PorNacionalidade(nacionalidade);
                if (procuradoModel != null)
                {
                    return Ok(procuradoModel);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("recompensaCrescente")]
        public ActionResult<ProcuradoModel> GetRecompensa()
        {
            try
            {
                var procuradoModel = procuradoRepository.PorRecompensaCrescente();
                if (procuradoModel != null)
                {
                    return Ok(procuradoModel);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("recompensaDecrescente")]
        public ActionResult<ProcuradoModel> GetRecompensaDecrescente()
        {
            try
            {
                var procuradoModel = procuradoRepository.PorRecompensaDecrescente();
                if (procuradoModel != null)
                {
                    return Ok(procuradoModel);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public ActionResult<ProcuradoModel> Post([FromBody] ProcuradoModel procuradoModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                procuradoRepository.Inserir(procuradoModel);
                var location = new Uri(Request.GetEncodedUrl() + "/" + procuradoModel.ProcuradoId);
                return Created(location, procuradoModel);
            }
            catch (Exception error)
            {
                return BadRequest(new { message = $"Não foi possível inserir o procurado. Detalhes: {error.Message}" });
            }
        }

        [HttpDelete("{id:int}")]
        public ActionResult<ProcuradoModel> Delete([FromRoute] int id)
        {
            try
            {
                var procuradoModel = procuradoRepository.Consultar(id);
                if (procuradoModel != null)
                {
                    procuradoRepository.Excluir(id);
                    // Retorno Sucesso.
                    // Efetuou a exclusão, porém sem necessidade de informar os dados.
                    return NoContent();
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpPut("{id:int}")]
        public ActionResult<ProcuradoModel> Put([FromRoute] int id, [FromBody] ProcuradoModel procuradoModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                procuradoRepository.Update(procuradoModel);
                return NoContent();
            }
            catch (Exception error)
            {
                return BadRequest(new { message = $"Não foi possível alterar o procurado. Detalhes: {error.Message}" });
            }
        }
    }
}
