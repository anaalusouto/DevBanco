using API_Cadastro_e_Gerenciamento_de_Clientes.Domain.Core;
using API_Cadastro_e_Gerenciamento_de_Clientes.Dto.Cliente;

namespace API_Cadastro_e_Gerenciamento_de_Clientes.Services.Cliente
{
    public interface IClienteInterface
    {
        Task<ResponseModel<List<ClienteModel>>> ListarClientes();
        Task<ResponseModel<ClienteModel>> BuscarClientePorId(int idCliente);
        Task<ResponseModel<ClienteModel>> BuscarClientePorNome(string nome);
        Task<ResponseModel<ClienteModel>> BuscarClientePorCpf(string cpf);
        Task<ResponseModel<List<ClienteModel>>> RegistrarCliente (ClienteRegistroDto clienteRegistroDto);
        Task<ResponseModel<List<ClienteModel>>> EditarCliente(ClienteEdicaoDto clienteEdicaoDto);
        Task<ResponseModel<List<ClienteModel>>> ExcluirCliente(int idAutor);
    }
}
