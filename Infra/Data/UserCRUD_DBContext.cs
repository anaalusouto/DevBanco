using ClienteCRUD.Core.Models;
using ClienteCRUD.Data.Map;
using Microsoft.EntityFrameworkCore;

namespace ClienteCRUD.Data
{
    public class UserCRUD_DBContext : DbContext
    {
        public UserCRUD_DBContext(DbContextOptions<UserCRUD_DBContext> options) : base(options) { }

        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<ContaModel> Contas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ContaMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}