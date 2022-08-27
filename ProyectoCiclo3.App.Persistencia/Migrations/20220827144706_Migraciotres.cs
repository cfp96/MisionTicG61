using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoCiclo3.App.Persistencia.Migrations
{
    public partial class Migraciotres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "número_de_asientos",
                table: "Aviones",
                newName: "numero_de_banos");

            migrationBuilder.RenameColumn(
                name: "numero_de_baños",
                table: "Aviones",
                newName: "numero_de_asientos");

            migrationBuilder.RenameColumn(
                name: "capacidad_máxima",
                table: "Aviones",
                newName: "capacidad_maxima");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "numero_de_banos",
                table: "Aviones",
                newName: "número_de_asientos");

            migrationBuilder.RenameColumn(
                name: "numero_de_asientos",
                table: "Aviones",
                newName: "numero_de_baños");

            migrationBuilder.RenameColumn(
                name: "capacidad_maxima",
                table: "Aviones",
                newName: "capacidad_máxima");
        }
    }
}
