using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PokeBag.Context.Models;

namespace PokeBag.Context.Types
{
    public class PokeDexTypeConfiguration : IEntityTypeConfiguration<PokeDex>
    {
        public void Configure(EntityTypeBuilder<PokeDex> builder)
        {
            builder.HasKey(q => q.Id);

            builder.Property(q => q.Name).HasMaxLength(50);
            builder.Property(q => q.Type1).HasMaxLength(10);
            builder.Property(q => q.Type2).HasMaxLength(10);
            builder.Property(q => q.CandyForEvolution);
            builder.Property(q => q.BuddyCandyKm).IsRequired();
            builder.Property(q => q.CPMax).IsRequired();

            builder.HasMany(q => q.Bag).WithOne().HasForeignKey(q => q.IdPokemonType);
        }
    }
}
