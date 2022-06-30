using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendChallenge.Migrations
{
    public partial class AgregarTablasDbRelaciones2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_Cliente",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Id_Vehiculo",
                table: "Pedidos");

            migrationBuilder.AddColumn<string>(
                name: "Ubicacion",
                table: "Vehiculos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Pedidos",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ubicacion",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Pedidos");

            migrationBuilder.AddColumn<int>(
                name: "Id_Cliente",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_Vehiculo",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
