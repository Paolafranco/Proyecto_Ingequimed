using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ginecologia_Ingequimed.Migrations
{
    public partial class DatoFamiliar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DatoFamiliar");

            migrationBuilder.CreateTable(
                name: "DatoFamily",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    FotografiaPerfil = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatoFamily", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DatoFamily");

            migrationBuilder.CreateTable(
                name: "DatoFamiliar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageName = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatoFamiliar", x => x.Id);
                });
        }
    }
}
