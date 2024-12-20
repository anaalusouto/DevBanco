using ClienteCRUD.Core.Models;
using ClienteCRUD.Data;
using ClienteCRUD.Infra.Repositories.Interfaces;

namespace ClienteCRUD.Core.UseCase.AdicionarCliente
{
    public class UseAdicionarCliente : IUseCaseAdicionarCliente
    {
        private readonly UserCRUD_DBContext _dbContext;
        public UseAdicionarCliente(UserCRUD_DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> AddAsync(ClienteModel cliente)
        {
            await _dbContext.Clientes.AddAsync(cliente);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}