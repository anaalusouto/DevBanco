using CadastroClienteEmprestimo.Core.Interface;
using CadastroClienteEmprestimo.Core.Models;
using CadastroClienteEmprestimo.Infra;
using Microsoft.EntityFrameworkCore;

namespace CadastroClienteEmprestimo.Core.UseCase
{
    public class ObterClientePorIdUseCase : IObterClientePorIdUseCase
    {
        private readonly AppDbContext _context;

        public ObterClientePorIdUseCase(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ClienteModel?> ObterUmCliente(int id)
        {
            var cliente = await _context.Clientes.FirstOrDefaultAsync(clienteBanco => clienteBanco.Id == id);

            if (cliente == null) 
            {
                return null;
            }

            return cliente;
        }
    }
}
