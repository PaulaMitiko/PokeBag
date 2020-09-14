using PokeDex_Estudo.Context.Models;
using System.Data.Entity.ModelConfiguration;

namespace PokeDex_Estudo.Context.Types
{
    public class BagTypeConfiguration : EntityTypeConfiguration<Bag>
    {
        public BagTypeConfiguration() 
        {
            HasKey(q => q.Id);

            Property(q => q.CombatPoints).IsRequired();
            Property(q => q.HealthPoints).IsRequired();
            Property(q => q.Attack).IsRequired();
            Property(q => q.Defense).IsRequired();
            Property(q => q.Stamina).IsRequired();
            Property(q => q.DataCaptura).IsRequired();
            Property(q => q.Shiny).IsRequired();
            Property(q => q.Evento).HasMaxLength(30);
            Property(q => q.Sombroso).HasMaxLength(10);
            Property(q => q.FastAttack).HasMaxLength(50);
            Property(q => q.ChargeAttack).HasMaxLength(50);

            HasRequired(q => q.PokeDex).WithMany().HasForeignKey(q => q.IdPokemonType);
            HasRequired(q => q.Cidade).WithMany().HasForeignKey(q => q.IdCidade);
        }
    }
}
