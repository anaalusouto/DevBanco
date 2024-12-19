using CadastroClienteEmprestimo.Core.Models;
using CadastroClienteEmprestimo.Pesentation.Dto;

namespace CadastroClienteEmprestimo.Core.Interface
{
    public interface IAtualizarClienteUseCase
    {
        Task<ClienteModel?> AtualizarCliente(int id, ClienteAtualizadoDto clienteAtualizadoDto);
    }
}
