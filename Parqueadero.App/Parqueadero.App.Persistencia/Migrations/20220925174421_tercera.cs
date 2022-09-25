using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parqueadero.App.Persistencia.Migrations
{
    public partial class tercera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tiempocompleto",
                table: "tiempocompleto");

            migrationBuilder.RenameTable(
                name: "tiempocompleto",
                newName: "tiempocompletoss");

            migrationBuilder.AddColumn<string>(
                name: "correo",
                table: "personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tiempocompletoss",
                table: "tiempocompletoss",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tiempocompletoss",
                table: "tiempocompletoss");

            migrationBuilder.DropColumn(
                name: "correo",
                table: "personas");

            migrationBuilder.RenameTable(
                name: "tiempocompletoss",
                newName: "tiempocompleto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tiempocompleto",
                table: "tiempocompleto",
                column: "Id");
        }
    }
}
