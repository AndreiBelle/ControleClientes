using Microsoft.EntityFrameworkCore;

namespace ControleClientes
{
    class AppDbContext : DbContext
    {
      public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=dados;Username=postgres;Password=root");
        }
    }
}
