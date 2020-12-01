using Microsoft.EntityFrameworkCore.Migrations;

namespace PruebaTecnicaNET.Migrations
{
    public partial class datos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EstadoCursos",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "Activo" });

            migrationBuilder.InsertData(
                table: "EstadoCursos",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 2, "En Curso" });

            migrationBuilder.InsertData(
                table: "EstadoCursos",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 3, "Finalizado" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EstadoCursos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EstadoCursos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EstadoCursos",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
