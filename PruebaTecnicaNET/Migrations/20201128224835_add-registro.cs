using Microsoft.EntityFrameworkCore.Migrations;

namespace PruebaTecnicaNET.Migrations
{
    public partial class addregistro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EstadoCursos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nombre",
                value: "");

            migrationBuilder.UpdateData(
                table: "EstadoCursos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nombre",
                value: "Activo");

            migrationBuilder.UpdateData(
                table: "EstadoCursos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Nombre",
                value: "En Curso");

            migrationBuilder.InsertData(
                table: "EstadoCursos",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 4, "Finalizado" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EstadoCursos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "EstadoCursos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nombre",
                value: "Activo");

            migrationBuilder.UpdateData(
                table: "EstadoCursos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nombre",
                value: "En Curso");

            migrationBuilder.UpdateData(
                table: "EstadoCursos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Nombre",
                value: "Finalizado");
        }
    }
}
