using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendChallenge.Migrations
{
    public partial class ModeloUbicacion12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VehiculoId1",
                table: "Historiales",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Historiales_VehiculoId1",
                table: "Historiales",
                column: "VehiculoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Historiales_Vehiculos_VehiculoId1",
                table: "Historiales",
                column: "VehiculoId1",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Historiales_Vehiculos_VehiculoId1",
                table: "Historiales");

            migrationBuilder.DropIndex(
                name: "IX_Historiales_VehiculoId1",
                table: "Historiales");

            migrationBuilder.DropColumn(
                name: "VehiculoId1",
                table: "Historiales");
        }
    }
}
