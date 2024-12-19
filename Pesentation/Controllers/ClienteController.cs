using CadastroClienteEmprestimo.Core.Interface;
using CadastroClienteEmprestimo.Pesentation.Dto;
using Microsoft.AspNetCore.Mvc;

namespace CadastroClienteEmprestimo.Pesentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly ICadastrarClienteUseCase _cadastrarClienteUseCase;
        private readonly IObterClientePorIdUseCase _obterClientePorIdUseCase;
        private readonly IAtualizarClienteUseCase _atualizarClienteUseCase;

        public ClienteController(
            ICadastrarClienteUseCase cadastrarClienteUseCase,
            IObterClientePorIdUseCase obterClientePorIdUseCase,
            IAtualizarClienteUseCase atualizarClienteUseCase
            )
        {
            _cadastrarClienteUseCase = cadastrarClienteUseCase;
            _obterClientePorIdUseCase = obterClientePorIdUseCase;
            _atualizarClienteUseCase = atualizarClienteUseCase;
        }

        [HttpPost("CadastrarCliente")]
        public async Task<IActionResult> CadastrarCliente([FromBody] ClienteCreateDto dto)
        {
            var cliente = await _cadastrarClienteUseCase.CadastrarCliente(dto);

            return Ok(cliente);
        }

        [HttpGet("BuscarCliente/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cliente = await _obterClientePorIdUseCase.ObterUmCliente(id);
            
            if (cliente == null) 
            {
                return NotFound();
            }

            return Ok(cliente);
        }
        [HttpPatch("AtualizarCliente/{id}")]
        public async Task<IActionResult> AtualizarCliente(int id, [FromBody] ClienteAtualizadoDto clienteAtualizadoDto)
        {
            var cliente = await _atualizarClienteUseCase.AtualizarCliente(id, clienteAtualizadoDto);
            if (cliente == null)
                return NotFound();

            return Ok(cliente);
        }
    }
}
