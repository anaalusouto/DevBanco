using CadastroClienteEmprestimo.Core.Models;
using CadastroClienteEmprestimo.Pesentation.Dto;

namespace CadastroClienteEmprestimo.Core.Interface
{
    public interface ICadastrarClienteUseCase
    {
        Task<ClienteModel> CadastrarCliente(ClienteCreateDto dto);
    }
}
