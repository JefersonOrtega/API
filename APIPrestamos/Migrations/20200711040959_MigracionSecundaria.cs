using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIPrestamos.Migrations
{
    public partial class MigracionSecundaria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "PersonaId", "Balance", "Cedula", "Direccion", "FechaNacimiento", "Nombre", "Telefono" },
                values: new object[] { 1, 0.0, "058-6669531-4", "C/27 de Febrero Esq.Castillo", new DateTime(2020, 7, 11, 1, 9, 57, 419, DateTimeKind.Local).AddTicks(5303), "Juan Pineda", "829-666-6000" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "PersonaId",
                keyValue: 1);
        }
    }
}
