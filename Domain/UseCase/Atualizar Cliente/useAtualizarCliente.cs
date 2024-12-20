using ClienteCRUD.Core.Models;
using ClienteCRUD.Data;
using ClienteCRUD.Infra.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClienteCRUD.Core.UseCase.AtualizarCliente
{
    public class UseAtualizarCliente : IUseCaseAtualizarCliente
    {
        private readonly UserCRUD_DBContext _dbContext;
        public UseAtualizarCliente(UserCRUD_DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> UpdateAsync(ClienteModel cliente, int id)
        {
            ClienteModel clienteById = await _dbContext.Clientes.FirstOrDefaultAsync(x => x.Id == id);
            if (clienteById == null) { throw new Exception($"User was not found by ID:{id}"); }
            clienteById.Name = cliente.Name;
            clienteById.Email = cliente.Email;
            clienteById.Cellphone = cliente.Cellphone;
            clienteById.Data_Nascimento = cliente.Data_Nascimento;
            clienteById.CPF = cliente.CPF;


            _dbContext.Update(clienteById);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}