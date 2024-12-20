using ClienteCRUD.Core.Models;

namespace ClienteCRUD.Core.Interfaces.Adapters
{
    public interface IClienteRepository
    {
        Task<List<ClienteModel>> GetAllUsers();
        Task<bool> BuscarId(int id);
        Task<bool> AddUser(ClienteModel user);
        Task<bool> Update(ClienteModel user, int id);
    }
}
