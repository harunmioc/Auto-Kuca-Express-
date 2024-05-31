using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Express.Data.Migrations
{
    /// <inheritdoc />
    public partial class lolcina : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Korpa",
                table: "Korisnik",
                newName: "KorpaId");

            migrationBuilder.AddColumn<int>(
                name: "Kilometraza",
                table: "Proizvod",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Slika",
                table: "Proizvod",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kilometraza",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "Slika",
                table: "Proizvod");

            migrationBuilder.RenameColumn(
                name: "KorpaId",
                table: "Korisnik",
                newName: "Korpa");
        }
    }
}
