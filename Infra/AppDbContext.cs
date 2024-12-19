using CadastroClienteEmprestimo.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroClienteEmprestimo.Infra
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<ClienteModel> Clientes { get; set; }

    }
}
