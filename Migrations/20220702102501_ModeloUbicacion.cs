using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendChallenge.Migrations
{
    public partial class ModeloUbicacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_HistorialVehiculos_HistorialVehiculoId",
                table: "Vehiculos");

            migrationBuilder.DropTable(
                name: "HistorialVehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_HistorialVehiculoId",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "HistorialVehiculoId",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "Ubicacion",
                table: "Vehiculos");

            migrationBuilder.AddColumn<string>(
                name: "UbicacionId",
                table: "Vehiculos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UbicacionId1",
                table: "Vehiculos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Ubicaciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direccion = table.Column<string>(nullable: false),
                    VehiculoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicaciones", x => x.Id);
                });

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

            migrationBuilder.DropTable(
                name: "Ubicaciones");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_UbicacionId1",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "UbicacionId",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "UbicacionId1",
                table: "Vehiculos");

            migrationBuilder.AddColumn<int>(
                name: "HistorialVehiculoId",
                table: "Vehiculos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ubicacion",
                table: "Vehiculos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "HistorialVehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehiculoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialVehiculos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_HistorialVehiculoId",
                table: "Vehiculos",
                column: "HistorialVehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_HistorialVehiculos_HistorialVehiculoId",
                table: "Vehiculos",
                column: "HistorialVehiculoId",
                principalTable: "HistorialVehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
