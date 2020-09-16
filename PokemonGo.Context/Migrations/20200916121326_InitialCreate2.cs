using Microsoft.EntityFrameworkCore.Migrations;

namespace PokemonGo.Context.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PokemonBag_Cidade_CidadeId",
                table: "PokemonBag");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonBag_PokeDex_PokeDexId",
                table: "PokemonBag");

            migrationBuilder.DropIndex(
                name: "IX_PokemonBag_CidadeId",
                table: "PokemonBag");

            migrationBuilder.DropIndex(
                name: "IX_PokemonBag_PokeDexId",
                table: "PokemonBag");

            migrationBuilder.DropColumn(
                name: "CidadeId",
                table: "PokemonBag");

            migrationBuilder.DropColumn(
                name: "PokeDexId",
                table: "PokemonBag");

            migrationBuilder.AddColumn<bool>(
                name: "Transferir",
                table: "PokemonBag",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Transferir",
                table: "PokemonBag");

            migrationBuilder.AddColumn<int>(
                name: "CidadeId",
                table: "PokemonBag",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PokeDexId",
                table: "PokemonBag",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PokemonBag_CidadeId",
                table: "PokemonBag",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonBag_PokeDexId",
                table: "PokemonBag",
                column: "PokeDexId");

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonBag_Cidade_CidadeId",
                table: "PokemonBag",
                column: "CidadeId",
                principalTable: "Cidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonBag_PokeDex_PokeDexId",
                table: "PokemonBag",
                column: "PokeDexId",
                principalTable: "PokeDex",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
