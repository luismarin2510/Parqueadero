using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parqueadero.App.Persistencia.Migrations
{
    public partial class segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_vehiculos",
                table: "vehiculos");

            migrationBuilder.RenameTable(
                name: "vehiculos",
                newName: "vehiculoss");

            migrationBuilder.RenameColumn(
                name: "tiempo",
                table: "porhorass",
                newName: "salida");

            migrationBuilder.AddColumn<DateTime>(
                name: "hora_entrada",
                table: "tiempocompleto",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "hora_salida",
                table: "tiempocompleto",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "entrada",
                table: "porhorass",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_vehiculoss",
                table: "vehiculoss",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_vehiculoss",
                table: "vehiculoss");

            migrationBuilder.DropColumn(
                name: "hora_entrada",
                table: "tiempocompleto");

            migrationBuilder.DropColumn(
                name: "hora_salida",
                table: "tiempocompleto");

            migrationBuilder.DropColumn(
                name: "entrada",
                table: "porhorass");

            migrationBuilder.RenameTable(
                name: "vehiculoss",
                newName: "vehiculos");

            migrationBuilder.RenameColumn(
                name: "salida",
                table: "porhorass",
                newName: "tiempo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vehiculos",
                table: "vehiculos",
                column: "Id");
        }
    }
}
