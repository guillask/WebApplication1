using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Persistence
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            // Configure a conexão com o banco de dados aqui
            optionsBuilder.UseSqlServer("Server=diego-desktop\\sqlexpress_2022;Database=DesafioArquiteto;User Id=sa;Password=luizafilha;TrustServerCertificate=true;");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
