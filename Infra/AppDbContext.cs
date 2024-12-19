using Microsoft.EntityFrameworkCore;
using API_Cadastro_e_Gerenciamento_de_Clientes.Domain.Core;

namespace API_Cadastro_e_Gerenciamento_de_Clientes.Infra
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<ContaModel> Contas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relacionamento entre Conta e Cliente
            modelBuilder.Entity<ContaModel>()
                .HasOne(c => c.Titular) // Uma Conta tem um Titular (Cliente)
                .WithMany(c => c.Contas) // Um Cliente tem muitas Contas
                .HasForeignKey(c => c.ClienteId) // Chave estrangeira
                .OnDelete(DeleteBehavior.Cascade); // Se um Cliente for deletado, suas Contas também serão deletadas
        }
    }
}
