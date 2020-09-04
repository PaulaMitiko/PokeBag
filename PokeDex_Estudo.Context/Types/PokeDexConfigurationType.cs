using PokeDex_Estudo.Context.Models;
using System.Data.Entity.ModelConfiguration;

namespace PokeDex_Estudo.Context.Types
{
    public class PokeDexConfigurationType : EntityTypeConfiguration<PokeDex>
    {
        public PokeDexConfigurationType() 
        {
            HasKey(q => q.Id);

            Property(q => q.Name).HasMaxLength(50);
            Property(q => q.Type1).HasMaxLength(10);
            Property(q => q.Type2).HasMaxLength(10);
            Property(q => q.BuddyCandyKm).IsRequired();
            Property(q => q.CPMax).IsRequired();

            HasMany(q => q.Bag).WithRequired().HasForeignKey(q => q.IdPokemonType);
        }
    }
}
