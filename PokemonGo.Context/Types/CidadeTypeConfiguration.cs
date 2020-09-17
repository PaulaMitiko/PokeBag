using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PokemonGo.Context.Models;

namespace PokemonGo.Context.Types
{
    public class CidadeTypeConfiguration : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.HasKey(q => q.Id);

            builder.Property(q => q.NomeCidade).HasMaxLength(100);
            builder.Property(q => q.Pais).HasMaxLength(50);
        }
    }
}
