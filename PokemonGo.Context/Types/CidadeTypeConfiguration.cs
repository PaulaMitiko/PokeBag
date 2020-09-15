using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PokeBag.Context.Models;

namespace PokeBag.Context.Types
{
    public class CidadeTypeConfiguration : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.HasKey(q => q.Id);

            builder.Property(q => q.NomeCidade).HasMaxLength(100);
            builder.Property(q => q.Pais).HasMaxLength(50);

            builder.HasMany(q => q.Bag).WithOne().HasForeignKey(q => q.IdCidade);
        }
    }
}
