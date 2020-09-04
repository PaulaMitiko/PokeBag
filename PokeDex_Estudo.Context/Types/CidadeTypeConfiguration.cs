using PokeDex_Estudo.Context.Models;
using System.Data.Entity.ModelConfiguration;

namespace PokeDex_Estudo.Context.Types
{
    public class CidadeTypeConfiguration : EntityTypeConfiguration<Cidade>
    {
        public CidadeTypeConfiguration() 
        {
            HasKey(q => q.Id);

            Property(q => q.NomeCidade).HasMaxLength(100);
            Property(q => q.Pais).HasMaxLength(50);

            HasMany(q => q.Bag).WithRequired().HasForeignKey(q => q.IdCidade);
        }
    }
}
