using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendChallenge.Migrations
{
    public partial class ModeloUbicacion13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Historiales_Vehiculos_VehiculoId1",
                table: "Historiales");

            migrationBuilder.AlterColumn<int>(
                name: "VehiculoId1",
                table: "Historiales",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Historiales_Vehiculos_VehiculoId1",
                table: "Historiales",
                column: "VehiculoId1",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
