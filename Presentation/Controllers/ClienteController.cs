using API_Cadastro_e_Gerenciamento_de_Clientes.Domain.Core;
using API_Cadastro_e_Gerenciamento_de_Clientes.Dto.Cliente;
using API_Cadastro_e_Gerenciamento_de_Clientes.Services.Cliente;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Cadastro_e_Gerenciamento_de_Clientes.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly IClienteInterface _clienteInterface;
        public ClienteController(IClienteInterface clienteInterface)
        {
            _clienteInterface = clienteInterface;
        }

        [HttpGet("ListarClientes")]
        public async Task<ActionResult<ResponseModel<List<ClienteModel>>>> ListarCLiente()
        {
            var clientes = await _clienteInterface.ListarClientes();
            return Ok(clientes);
        }


        [HttpGet("BuscarClientePorId/{idCliente}")]
        public async Task<ActionResult<ResponseModel<ClienteModel>>> BuscarClientePorId(int idCliente)
        {
            var cliente = await _clienteInterface.BuscarClientePorId(idCliente);
            return Ok(cliente);
        }

        [HttpGet("BuscarClientePorNome/{nameCliente}")]
        public async Task<ActionResult<ResponseModel<ClienteModel>>> BuscarClientePorNome(string nameCliente)
        {
            var cliente = await _clienteInterface.BuscarClientePorNome(nameCliente);
            return Ok(cliente);
        }

        [HttpGet("BuscarClientePorCpf/{cpfCliente}")]
        public async Task<ActionResult<ResponseModel<ClienteModel>>> BuscarClientePorCpf(string cpfCliente)
        {
            var cliente = await _clienteInterface.BuscarClientePorCpf(cpfCliente);
            return Ok(cliente);
        }

        [HttpPost("RegistrarCliente")]
        public async Task<ActionResult<ResponseModel<ClienteModel>>> RegistrarCliente(ClienteRegistroDto clienteRegistroDto)
        {
            var clientes = await _clienteInterface.RegistrarCliente(clienteRegistroDto);
            return Ok(clientes);
        }

        [HttpPut("EditarCliente{idCliente}")]
        public async Task<ActionResult<ResponseModel<List<ClienteModel>>>> EditarCliente(ClienteEdicaoDto clienteEdicaoDto)
        {
            var clientes = await _clienteInterface.EditarCliente(clienteEdicaoDto);
            return Ok(clientes);
        }

        [HttpDelete("ExcluirCliente")]
        public async Task<ActionResult<ResponseModel<List<ClienteModel>>>> ExcluirCliente(int idCliente)
        {
            var clientes = await _clienteInterface.ExcluirCliente(idCliente);
            return Ok(clientes);
        }
    }
}
