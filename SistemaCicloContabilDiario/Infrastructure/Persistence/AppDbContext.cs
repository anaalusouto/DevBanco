using Microsoft.EntityFrameworkCore;
using SistemaCicloContabilDiario.Domain.Entities;
using SistemaCicloContabilDiario.Domain.ValueObjects;
using SistemaCicloContabilDiario.Models;

namespace SistemaCicloContabilDiario.Infrastructure.Persistence
{
    //herda DbContext do EntityFrameworkCore
    //gerencia a conexão com o BD
    public class AppDbContext : DbContext
    {
        //atalho "ctor" para criar construtor
        //o parâmetro do construtor recebe opções de config de BD (string de conexão, providers, pools...)
        //base(options) passa as configs recebidas para o construtor da super classe DbContext
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //DbSet permite read, inserts, uptades e dels
        // DbSet<T> representa uma coleção de entidades tipo T (generica) 
 
        public DbSet<Transacao> Transacoes { get; set; }
        public DbSet<TipoTransacao> TiposTransacao { get; set; }
        public DbSet<CategoriaTransacao> CategoriasTransacao { get; set; }
        public DbSet<Montante> Montantes { get; set; }


    }
}
