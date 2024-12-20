using Microsoft.EntityFrameworkCore;
using SistemaCicloContabilDiario.Models;

namespace SistemaCicloContabilDiario.Data
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
        public DbSet<AutorModel> Autores { get; set; }
        public DbSet<LivroModel> Livros { get; set; }


    }
}
