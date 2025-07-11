using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Saboriza.Migrations
{
    /// <inheritdoc />
    public partial class MigrationPostgres1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Usuarios",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Usuarios",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Usuarios");
        }
    }
}
