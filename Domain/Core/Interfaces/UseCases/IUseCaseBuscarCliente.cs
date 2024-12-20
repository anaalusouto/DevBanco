using ClienteCRUD.Core.Models;

namespace ClienteCRUD.Infra.Repositories.Interfaces
{
    public interface IUseCaseBuscarCliente
    {
        Task<ClienteModel> BuscarAsync(int id);
    }
}
