using ClienteCRUD.Core.Models;
using ClienteCRUD.Data;
using ClienteCRUD.Infra.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClienteCRUD.Core.UseCase.AtualizarCliente
{
    public class UseBuscarCliente : IUseCaseBuscarCliente
    {
        private readonly UserCRUD_DBContext _dbContext;
        public UseBuscarCliente(UserCRUD_DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ClienteModel> BuscarAsync(int id)
        {
            return await _dbContext.Clientes.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}