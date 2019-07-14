using Microsoft.EntityFrameworkCore.Migrations;

namespace Segfy.Domain.Migrations
{
    public partial class EFCoreCodeFirstSampleModelsSegfyContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Automovel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Placa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Automovel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Segurado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Documento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Segurado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApoliceAutomovel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    numero = table.Column<string>(nullable: true),
                    AutomovelId = table.Column<int>(nullable: true),
                    SeguradoId = table.Column<int>(nullable: true),
                    ValorPremio = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApoliceAutomovel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApoliceAutomovel_Automovel_AutomovelId",
                        column: x => x.AutomovelId,
                        principalTable: "Automovel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ApoliceAutomovel_Segurado_SeguradoId",
                        column: x => x.SeguradoId,
                        principalTable: "Segurado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApoliceAutomovel_AutomovelId",
                table: "ApoliceAutomovel",
                column: "AutomovelId");

            migrationBuilder.CreateIndex(
                name: "IX_ApoliceAutomovel_SeguradoId",
                table: "ApoliceAutomovel",
                column: "SeguradoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApoliceAutomovel");

            migrationBuilder.DropTable(
                name: "Automovel");

            migrationBuilder.DropTable(
                name: "Segurado");
        }
    }
}
