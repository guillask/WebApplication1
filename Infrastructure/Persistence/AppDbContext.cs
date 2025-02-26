using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Domain.Lancamento> Lancamentos { get; set; }
        public DbSet<Domain.TipoLancamento> TipoLancamento { get; set; }
    }
}
