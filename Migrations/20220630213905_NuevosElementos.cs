using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendChallenge.Migrations
{
    public partial class NuevosElementos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HistorialVehiculoId",
                table: "Vehiculos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "HistorialVehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ubicacion = table.Column<string>(nullable: false)
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
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
