using APIPagamentoOnline.Domain.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace APIPagamentoOnline.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        public DbSet<PagamentoDebitoEmContaModel> LogPagamentoDebito { get; set; }
    }
}
