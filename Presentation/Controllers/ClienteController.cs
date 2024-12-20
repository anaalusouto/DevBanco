using ClienteCRUD.Core.Models;
using ClienteCRUD.Infra.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClienteCRUD.Presentation.Controllers
{
    [Route("clienteMetodos")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly IUseCaseAdicionarCliente _useAdicionarCliente;
        private readonly IUseCaseAtualizarCliente _useAtualizarCliente;
        private readonly IUseCaseBuscarCliente _useBuscarCliente;

        public ClienteController(IUseCaseAdicionarCliente useAdicionarCliente, IUseCaseAtualizarCliente useAtualizarCliente, IUseCaseBuscarCliente useBuscarCliente)
        {
            _useAdicionarCliente = useAdicionarCliente;
            _useAtualizarCliente = useAtualizarCliente;
            _useBuscarCliente = useBuscarCliente;
        }

        [HttpPost("cadastro")]
        public async Task<ActionResult<ClienteModel>> Post([FromBody] ClienteModel user)
        {
            await _useAdicionarCliente.AddAsync(user);
            return Ok(true);
        }

        [HttpPut("alterar")]
        public async Task<ActionResult<List<ClienteModel>>> Put(ClienteModel cliente, int id)
        {
            await _useAtualizarCliente.UpdateAsync(cliente, id);
            return Ok(true);
        }

        [HttpGet("buscarPorId")]
        public async Task<ActionResult<List<ClienteModel>>> GetById(int id)
        {
            ClienteModel user = await _useBuscarCliente.BuscarAsync(id);
            return Ok(user);
        }
    }
}
