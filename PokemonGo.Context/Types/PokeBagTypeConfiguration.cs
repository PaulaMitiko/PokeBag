using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PokeBag.Context.Models;


namespace PokeBag.Context.Types
{
    public class BagTypeConfiguration : IEntityTypeConfiguration<PokemonBag>
    {
        public void Configure(EntityTypeBuilder<PokemonBag> builder)
        {
            builder.HasKey(q => q.Id);

            builder.Property(q => q.CombatPoints).IsRequired();
            builder.Property(q => q.HealthPoints).IsRequired();
            builder.Property(q => q.Attack).IsRequired();
            builder.Property(q => q.Defense).IsRequired();
            builder.Property(q => q.Stamina).IsRequired();
            builder.Property(q => q.DataCaptura).IsRequired();
            builder.Property(q => q.Shiny).IsRequired();
            builder.Property(q => q.Evento).HasMaxLength(30);
            builder.Property(q => q.Sombroso).HasMaxLength(10);
            builder.Property(q => q.FastAttack).HasMaxLength(50);
            builder.Property(q => q.ChargeAttack).HasMaxLength(50);
        }
    }
}
