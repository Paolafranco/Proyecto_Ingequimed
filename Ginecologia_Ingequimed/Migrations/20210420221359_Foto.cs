using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ginecologia_Ingequimed.Migrations
{
    public partial class Foto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagenProducto",
                table: "DatoFamiliar");

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "DatoFamiliar",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Menopausia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menopausia", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Menopausia");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "DatoFamiliar");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImagenProducto",
                table: "DatoFamiliar",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
