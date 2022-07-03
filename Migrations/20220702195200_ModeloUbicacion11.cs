using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendChallenge.Migrations
{
    public partial class ModeloUbicacion11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ubicaciones");

            migrationBuilder.AddColumn<string>(
                name: "Ubicacion",
                table: "Vehiculos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ubicacion",
                table: "Historiales",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VehiculoId",
                table: "Historiales",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ubicacion",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "Ubicacion",
                table: "Historiales");

            migrationBuilder.DropColumn(
                name: "VehiculoId",
                table: "Historiales");

            migrationBuilder.CreateTable(
                name: "Ubicaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HistorialId = table.Column<int>(type: "int", nullable: false),
                    VehiculoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ubicaciones_Historiales_HistorialId",
                        column: x => x.HistorialId,
                        principalTable: "Historiales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ubicaciones_Vehiculos_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "Vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ubicaciones_HistorialId",
                table: "Ubicaciones",
                column: "HistorialId");

            migrationBuilder.CreateIndex(
                name: "IX_Ubicaciones_VehiculoId",
                table: "Ubicaciones",
                column: "VehiculoId",
                unique: true);
        }
    }
}
