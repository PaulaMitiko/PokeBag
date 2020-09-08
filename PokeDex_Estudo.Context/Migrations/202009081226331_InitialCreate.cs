namespace PokeDex_Estudo.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bag",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdPokemonType = c.Int(nullable: false),
                        CombatPoints = c.Int(nullable: false),
                        HealthPoints = c.Int(nullable: false),
                        Atack = c.Int(nullable: false),
                        Defense = c.Int(nullable: false),
                        Stamina = c.Int(nullable: false),
                        IndividualValue = c.Double(nullable: false),
                        IdCidade = c.Int(nullable: false),
                        DataCaptura = c.DateTime(nullable: false),
                        Shiny = c.Boolean(nullable: false),
                        Evento = c.String(maxLength: 30),
                        Sombroso = c.String(maxLength: 10),
                        DisponivelTroca = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cidade", t => t.IdCidade)
                .ForeignKey("dbo.PokeDex", t => t.IdPokemonType)
                .Index(t => t.IdPokemonType)
                .Index(t => t.IdCidade);
            
            CreateTable(
                "dbo.Cidade",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeCidade = c.String(maxLength: 100),
                        Pais = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PokeDex",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Type1 = c.String(maxLength: 10),
                        Type2 = c.String(maxLength: 10),
                        CandyForEvolution = c.Int(nullable: false),
                        BuddyCandyKm = c.Int(nullable: false),
                        EggKm = c.Int(nullable: false),
                        CPMax = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bag", "IdPokemonType", "dbo.PokeDex");
            DropForeignKey("dbo.Bag", "IdCidade", "dbo.Cidade");
            DropIndex("dbo.Bag", new[] { "IdCidade" });
            DropIndex("dbo.Bag", new[] { "IdPokemonType" });
            DropTable("dbo.PokeDex");
            DropTable("dbo.Cidade");
            DropTable("dbo.Bag");
        }
    }
}
