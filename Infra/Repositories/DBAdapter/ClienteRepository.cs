using ClienteCRUD.Core.Interfaces.Adapters;
using ClienteCRUD.Core.Models;

namespace ClienteCRUD.Infra.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        public Task<bool> AddUser(ClienteModel user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> BuscarId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ClienteModel>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(ClienteModel user, int id)
        {
            throw new NotImplementedException();
        }
    }
}
