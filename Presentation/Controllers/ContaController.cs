using API_Cadastro_e_Gerenciamento_de_Clientes.Domain.Core;
using API_Cadastro_e_Gerenciamento_de_Clientes.Dto.Conta;
using API_Cadastro_e_Gerenciamento_de_Clientes.Services.Conta;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Cadastro_e_Gerenciamento_de_Clientes.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaController : ControllerBase
    {

        private readonly IContaInterface _contaInterface;
        public ContaController(IContaInterface contaInterface)
        {
            _contaInterface = contaInterface;
        }

        [HttpGet("ListarContas")]
        public async Task<ActionResult<ResponseModel<List<ContaModel>>>> ListarConta()
        {
            var contas = await _contaInterface.ListarContas();
            return Ok(contas);
        }

        [HttpPost("CriarConta/{idCliente}")]
        public async Task<ActionResult<ResponseModel<ContaModel>>> CriarConta(int idCliente, [FromBody] ContaCriacaoDto contaCriacaoDto)
        {
            // Chama o serviço passando o idCliente e o DTO
            var resposta = await _contaInterface.CriarConta(idCliente, contaCriacaoDto);

            // Retorna a resposta apropriada
            if (resposta.Status)
            {
                return Ok(resposta);
            }
            else
            {
                return BadRequest(resposta);
            }
        }

    }
}
