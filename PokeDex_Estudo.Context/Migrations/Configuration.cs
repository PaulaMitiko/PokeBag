namespace PokeDex_Estudo.Context.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PokeDex_Estudo.Context.PokeDexContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "PokeDex_Estudo.Context.PokeDexContext";
        }

        protected override void Seed(PokeDex_Estudo.Context.PokeDexContext context)
        {
        }
    }
}
