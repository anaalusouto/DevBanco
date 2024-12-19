using API_Cadastro_e_Gerenciamento_de_Clientes.Domain.Core;
using API_Cadastro_e_Gerenciamento_de_Clientes.Dto.Conta;

namespace API_Cadastro_e_Gerenciamento_de_Clientes.Services.Conta
{
    public interface IContaInterface
    {
        Task<ResponseModel<List<ContaModel>>> ListarContas();
        Task<ResponseModel<ContaModel>> CriarConta(int idCliente, ContaCriacaoDto contaCriacaoDto);
    }
}
