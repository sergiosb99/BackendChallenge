using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendChallenge.Migrations
{
    public partial class ModeloUbicacion10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Ubicaciones_VehiculoId",
                table: "Ubicaciones");

            migrationBuilder.AddColumn<int>(
                name: "HistorialId",
                table: "Ubicaciones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Historiales",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historiales", x => x.Id);
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

            migrationBuilder.AddForeignKey(
                name: "FK_Ubicaciones_Historiales_HistorialId",
                table: "Ubicaciones",
                column: "HistorialId",
                principalTable: "Historiales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ubicaciones_Historiales_HistorialId",
                table: "Ubicaciones");

            migrationBuilder.DropTable(
                name: "Historiales");

            migrationBuilder.DropIndex(
                name: "IX_Ubicaciones_HistorialId",
                table: "Ubicaciones");

            migrationBuilder.DropIndex(
                name: "IX_Ubicaciones_VehiculoId",
                table: "Ubicaciones");

            migrationBuilder.DropColumn(
                name: "HistorialId",
                table: "Ubicaciones");

            migrationBuilder.CreateIndex(
                name: "IX_Ubicaciones_VehiculoId",
                table: "Ubicaciones",
                column: "VehiculoId");
        }
    }
}
