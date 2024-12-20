using ClienteCRUD.Core.Models;

namespace ClienteCRUD.Infra.Repositories.Interfaces
{
    public interface IUseCaseAtualizarCliente
    {
        Task<bool> UpdateAsync(ClienteModel user, int id);
    }
}
