using PokeDex_Estudo.Context.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Reflection;

namespace PokeDex_Estudo.Context
{
    public class PokeDexContext : DbContext
    {
        public PokeDexContext() : base("DefaultConnection")
        {
        }

        public DbSet<Bag> Bag { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<PokeDex> PokeDex { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
