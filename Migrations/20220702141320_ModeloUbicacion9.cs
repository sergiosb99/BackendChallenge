using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendChallenge.Migrations
{
    public partial class ModeloUbicacion9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Ubicaciones_UbicacionId1",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_UbicacionId1",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "UbicacionId",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "UbicacionId1",
                table: "Vehiculos");

            migrationBuilder.CreateIndex(
                name: "IX_Ubicaciones_VehiculoId",
                table: "Ubicaciones",
                column: "VehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ubicaciones_Vehiculos_VehiculoId",
                table: "Ubicaciones",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ubicaciones_Vehiculos_VehiculoId",
                table: "Ubicaciones");

            migrationBuilder.DropIndex(
                name: "IX_Ubicaciones_VehiculoId",
                table: "Ubicaciones");

            migrationBuilder.AddColumn<string>(
                name: "UbicacionId",
                table: "Vehiculos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UbicacionId1",
                table: "Vehiculos",
                type: "int",
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
    }
}
