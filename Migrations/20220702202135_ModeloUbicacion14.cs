using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendChallenge.Migrations
{
    public partial class ModeloUbicacion14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "VehiculoId",
                table: "Historiales",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Historiales_VehiculoId",
                table: "Historiales",
                column: "VehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Historiales_Vehiculos_VehiculoId",
                table: "Historiales",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Historiales_Vehiculos_VehiculoId",
                table: "Historiales");

            migrationBuilder.DropIndex(
                name: "IX_Historiales_VehiculoId",
                table: "Historiales");

            migrationBuilder.AlterColumn<string>(
                name: "VehiculoId",
                table: "Historiales",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "VehiculoId1",
                table: "Historiales",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                onDelete: ReferentialAction.Cascade);
        }
    }
}
