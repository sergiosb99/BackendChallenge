using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendChallenge.Migrations
{
    public partial class ModeloUbicacion8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UbicacionId1",
                table: "Vehiculos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_UbicacionId1",
                table: "Vehiculos",
                column: "UbicacionId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Ubicaciones_UbicacionId1",
                table: "Vehiculos",
                column: "UbicacionId1",
                principalTable: "Ubicaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Ubicaciones_UbicacionId1",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_UbicacionId1",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "UbicacionId1",
                table: "Vehiculos");
        }
    }
}
