using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoCiclo3.App.Persistencia.Migrations
{
    public partial class Migraciondos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "capacidad_máxima",
                table: "Aviones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "numero_de_baños",
                table: "Aviones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "número_de_asientos",
                table: "Aviones",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "capacidad_máxima",
                table: "Aviones");

            migrationBuilder.DropColumn(
                name: "numero_de_baños",
                table: "Aviones");

            migrationBuilder.DropColumn(
                name: "número_de_asientos",
                table: "Aviones");
        }
    }
}
