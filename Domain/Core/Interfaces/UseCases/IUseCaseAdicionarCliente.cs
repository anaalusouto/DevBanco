using ClienteCRUD.Core.Models;

namespace ClienteCRUD.Infra.Repositories.Interfaces
{
    public interface IUseCaseAdicionarCliente
    {
        Task<bool> AddAsync(ClienteModel user);
    }
}
