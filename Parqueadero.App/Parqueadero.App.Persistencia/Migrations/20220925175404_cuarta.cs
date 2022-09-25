using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parqueadero.App.Persistencia.Migrations
{
    public partial class cuarta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "correo",
                table: "personas",
                newName: "contraseña");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "contraseña",
                table: "personas",
                newName: "correo");
        }
    }
}
