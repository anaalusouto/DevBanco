using CadastroClienteEmprestimo.Core.Models;

namespace CadastroClienteEmprestimo.Core.Interface
{
    public interface IObterClientePorIdUseCase
    {
        Task<ClienteModel?> ObterUmCliente(int id);
    }
}
