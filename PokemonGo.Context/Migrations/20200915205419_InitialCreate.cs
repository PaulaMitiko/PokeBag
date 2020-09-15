using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PokemonGo.Context.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cidade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCidade = table.Column<string>(maxLength: 100, nullable: true),
                    Pais = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokeDex",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Type1 = table.Column<string>(maxLength: 10, nullable: true),
                    Type2 = table.Column<string>(maxLength: 10, nullable: true),
                    CandyForEvolution = table.Column<int>(nullable: false),
                    BuddyCandyKm = table.Column<int>(nullable: false),
                    EggKm = table.Column<int>(nullable: false),
                    CPMax = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokeDex", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokemonBag",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPokemonType = table.Column<int>(nullable: false),
                    CombatPoints = table.Column<int>(nullable: false),
                    HealthPoints = table.Column<int>(nullable: false),
                    Attack = table.Column<int>(nullable: false),
                    Defense = table.Column<int>(nullable: false),
                    Stamina = table.Column<int>(nullable: false),
                    IndividualValue = table.Column<double>(nullable: false),
                    IdCidade = table.Column<int>(nullable: false),
                    DataCaptura = table.Column<DateTime>(nullable: false),
                    Shiny = table.Column<bool>(nullable: false),
                    Evento = table.Column<string>(maxLength: 30, nullable: true),
                    Sombroso = table.Column<string>(maxLength: 10, nullable: true),
                    DisponivelTroca = table.Column<bool>(nullable: false),
                    FastAttack = table.Column<string>(maxLength: 50, nullable: true),
                    ChargeAttack = table.Column<string>(maxLength: 50, nullable: true),
                    PokeDexId = table.Column<int>(nullable: true),
                    CidadeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonBag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonBag_Cidade_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PokemonBag_Cidade_IdCidade",
                        column: x => x.IdCidade,
                        principalTable: "Cidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonBag_PokeDex_IdPokemonType",
                        column: x => x.IdPokemonType,
                        principalTable: "PokeDex",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonBag_PokeDex_PokeDexId",
                        column: x => x.PokeDexId,
                        principalTable: "PokeDex",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PokemonBag_CidadeId",
                table: "PokemonBag",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonBag_IdCidade",
                table: "PokemonBag",
                column: "IdCidade");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonBag_IdPokemonType",
                table: "PokemonBag",
                column: "IdPokemonType");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonBag_PokeDexId",
                table: "PokemonBag",
                column: "PokeDexId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokemonBag");

            migrationBuilder.DropTable(
                name: "Cidade");

            migrationBuilder.DropTable(
                name: "PokeDex");
        }
    }
}
