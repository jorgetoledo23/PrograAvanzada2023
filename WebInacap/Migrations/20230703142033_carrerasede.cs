using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebInacap.Migrations
{
    /// <inheritdoc />
    public partial class carrerasede : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCarreras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duracion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCarreras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblSedeCarreras",
                columns: table => new
                {
                    SedeId = table.Column<int>(type: "int", nullable: false),
                    CarreraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSedeCarreras", x => new { x.SedeId, x.CarreraId });
                    table.ForeignKey(
                        name: "FK_tblSedeCarreras_tblCarreras_CarreraId",
                        column: x => x.CarreraId,
                        principalTable: "tblCarreras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblSedeCarreras_tblSedes_SedeId",
                        column: x => x.SedeId,
                        principalTable: "tblSedes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblSedeCarreras_CarreraId",
                table: "tblSedeCarreras",
                column: "CarreraId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblSedeCarreras");

            migrationBuilder.DropTable(
                name: "tblCarreras");
        }
    }
}
