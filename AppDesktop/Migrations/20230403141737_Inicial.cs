using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppDesktop.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblAsignaturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Horas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAsignaturas", x => x.Id);
                });

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
                name: "tblDocentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDocentes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblSedes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSedes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblUsuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pass = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUsuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tlbAlumnos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tlbAlumnos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblCarreraAsignaturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarreraId = table.Column<int>(type: "int", nullable: false),
                    AsignaturaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCarreraAsignaturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblCarreraAsignaturas_tblAsignaturas_AsignaturaId",
                        column: x => x.AsignaturaId,
                        principalTable: "tblAsignaturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblCarreraAsignaturas_tblCarreras_CarreraId",
                        column: x => x.CarreraId,
                        principalTable: "tblCarreras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblSeccion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AsignaturaId = table.Column<int>(type: "int", nullable: false),
                    DocenteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSeccion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblSeccion_tblAsignaturas_AsignaturaId",
                        column: x => x.AsignaturaId,
                        principalTable: "tblAsignaturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblSeccion_tblDocentes_DocenteId",
                        column: x => x.DocenteId,
                        principalTable: "tblDocentes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblCarreraSede",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarreraId = table.Column<int>(type: "int", nullable: false),
                    SedeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCarreraSede", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblCarreraSede_tblCarreras_CarreraId",
                        column: x => x.CarreraId,
                        principalTable: "tblCarreras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblCarreraSede_tblSedes_SedeId",
                        column: x => x.SedeId,
                        principalTable: "tblSedes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblSeccionAlumnos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeccionId = table.Column<int>(type: "int", nullable: false),
                    AlumnoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSeccionAlumnos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblSeccionAlumnos_tblSeccion_SeccionId",
                        column: x => x.SeccionId,
                        principalTable: "tblSeccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblSeccionAlumnos_tlbAlumnos_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "tlbAlumnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblCarreraAsignaturas_AsignaturaId",
                table: "tblCarreraAsignaturas",
                column: "AsignaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCarreraAsignaturas_CarreraId",
                table: "tblCarreraAsignaturas",
                column: "CarreraId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCarreraSede_CarreraId",
                table: "tblCarreraSede",
                column: "CarreraId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCarreraSede_SedeId",
                table: "tblCarreraSede",
                column: "SedeId");

            migrationBuilder.CreateIndex(
                name: "IX_tblSeccion_AsignaturaId",
                table: "tblSeccion",
                column: "AsignaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_tblSeccion_DocenteId",
                table: "tblSeccion",
                column: "DocenteId");

            migrationBuilder.CreateIndex(
                name: "IX_tblSeccionAlumnos_AlumnoId",
                table: "tblSeccionAlumnos",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_tblSeccionAlumnos_SeccionId",
                table: "tblSeccionAlumnos",
                column: "SeccionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblCarreraAsignaturas");

            migrationBuilder.DropTable(
                name: "tblCarreraSede");

            migrationBuilder.DropTable(
                name: "tblSeccionAlumnos");

            migrationBuilder.DropTable(
                name: "tblUsuarios");

            migrationBuilder.DropTable(
                name: "tblCarreras");

            migrationBuilder.DropTable(
                name: "tblSedes");

            migrationBuilder.DropTable(
                name: "tblSeccion");

            migrationBuilder.DropTable(
                name: "tlbAlumnos");

            migrationBuilder.DropTable(
                name: "tblAsignaturas");

            migrationBuilder.DropTable(
                name: "tblDocentes");
        }
    }
}
