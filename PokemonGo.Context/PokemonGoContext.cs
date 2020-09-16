using Microsoft.EntityFrameworkCore;
using PokeBag.Context.Models;

namespace PokemonGo.Context
{
    public class PokemonGoContext : DbContext
    {
        public PokemonGoContext()
        {
        }
        public PokemonGoContext(DbContextOptions<PokemonGoContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=NT-04781\\SQLEXPRESS01;Initial Catalog=PokemonGoBanco;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PokemonGoContext).Assembly);

            modelBuilder.Entity<PokemonBag>()
            .HasOne(p => p.PokeDex)
            .WithMany(b => b.Bag)
            .HasForeignKey(p => p.IdPokemonType);

            modelBuilder.Entity<PokemonBag>()
            .HasOne(p => p.Cidade)
            .WithMany(b => b.Bag)
            .HasForeignKey(p => p.IdCidade);
        }

        public DbSet<PokemonBag> PokemonBag { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<PokeDex> PokeDex { get; set; }
    }
}
