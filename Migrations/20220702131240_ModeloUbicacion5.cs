using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendChallenge.Migrations
{
    public partial class ModeloUbicacion5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Ubicaciones_UbicacionId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_UbicacionId",
                table: "Vehiculos");

            migrationBuilder.AlterColumn<string>(
                name: "UbicacionId",
                table: "Vehiculos",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UbicacionId",
                table: "Vehiculos",
                type: "int",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_UbicacionId",
                table: "Vehiculos",
                column: "UbicacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Ubicaciones_UbicacionId",
                table: "Vehiculos",
                column: "UbicacionId",
                principalTable: "Ubicaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
