using Microsoft.EntityFrameworkCore;

namespace ControleClientes
{
    class AppDbContext : DbContext
    {
      public DbSet<Cliente> Clientes { get; set; }
      public DbSet<Cidade> Cidades { get; set; }
      public DbSet<Os> OrdemServico { get; set; }

        public DbSet<TipoOs> TiposDeOs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=dados;Username=postgres;Password=1234");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
              .HasOne(c => c.Cidade)
              .WithMany(c => c.Clientes)
              .HasForeignKey(c => c.CidadeId);

            modelBuilder.Entity<Os>()
              .HasOne(o => o.Cliente)
              .WithMany(c => c.Os)
              .HasForeignKey(o => o.ClienteId);

            modelBuilder.Entity<Os>()
                .HasOne(o => o.TipoOs)
                .WithMany()
                .HasForeignKey(o => o.TipoOsID);
        }
    }
}
