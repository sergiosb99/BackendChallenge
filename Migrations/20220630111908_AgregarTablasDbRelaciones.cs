using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendChallenge.Migrations
{
    public partial class AgregarTablasDbRelaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cliente",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Vehiculo",
                table: "Pedidos");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Pedidos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_Cliente",
                table: "Pedidos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_Vehiculo",
                table: "Pedidos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VehiculoId",
                table: "Pedidos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ClienteId",
                table: "Pedidos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_VehiculoId",
                table: "Pedidos",
                column: "VehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clientes_ClienteId",
                table: "Pedidos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Vehiculos_VehiculoId",
                table: "Pedidos",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_ClienteId",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Vehiculos_VehiculoId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_ClienteId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_VehiculoId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Id_Cliente",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Id_Vehiculo",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "VehiculoId",
                table: "Pedidos");

            migrationBuilder.AddColumn<string>(
                name: "Cliente",
                table: "Pedidos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Vehiculo",
                table: "Pedidos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
