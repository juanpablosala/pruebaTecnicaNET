using Microsoft.EntityFrameworkCore.Migrations;

namespace PruebaTecnicaNET.Migrations
{
    public partial class addcampos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EstadoCursoId",
                table: "Cursos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_EstadoCursoId",
                table: "Cursos",
                column: "EstadoCursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_EstadoCursos_EstadoCursoId",
                table: "Cursos",
                column: "EstadoCursoId",
                principalTable: "EstadoCursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_EstadoCursos_EstadoCursoId",
                table: "Cursos");

            migrationBuilder.DropIndex(
                name: "IX_Cursos_EstadoCursoId",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "EstadoCursoId",
                table: "Cursos");
        }
    }
}
