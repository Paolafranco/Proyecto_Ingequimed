using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ginecologia_Ingequimed.Migrations
{
    public partial class Pantallas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calendario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Día = table.Column<int>(nullable: false),
                    Mes = table.Column<int>(nullable: false),
                    Año = table.Column<string>(nullable: true),
                    Hora = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DatoFamiliar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagenProducto = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatoFamiliar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DatoPersonal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Edad = table.Column<string>(nullable: true),
                    Habitos = table.Column<bool>(nullable: false),
                    Patalogías = table.Column<bool>(nullable: false),
                    Alergias = table.Column<bool>(nullable: false),
                    Embarazos = table.Column<bool>(nullable: false),
                    Cesárea = table.Column<bool>(nullable: false),
                    Cirugías = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatoPersonal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materno",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Pariente = table.Column<string>(nullable: true),
                    Parentesco = table.Column<string>(nullable: true),
                    Enfermedad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materno", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pareja",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enfermedades = table.Column<bool>(nullable: false),
                    Anticonceptivo = table.Column<bool>(nullable: false),
                    Impotencia = table.Column<bool>(nullable: false),
                    Ets = table.Column<bool>(nullable: false),
                    HIV = table.Column<bool>(nullable: false),
                    Hvp = table.Column<bool>(nullable: false),
                    Gonorrea = table.Column<bool>(nullable: false),
                    Otros = table.Column<bool>(nullable: false),
                    NombreEnfermedades = table.Column<string>(nullable: true),
                    NombreAnticonceptivo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pareja", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paterno",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Pariente = table.Column<string>(nullable: true),
                    Parentesco = table.Column<string>(nullable: true),
                    Enfermedad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paterno", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Salud",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fitness = table.Column<string>(nullable: true),
                    Alimentación = table.Column<string>(nullable: true),
                    Embarazo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salud", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sintoma",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fin_del_Periodo = table.Column<int>(nullable: false),
                    Días_de_Periodo = table.Column<int>(nullable: false),
                    Pastillas = table.Column<bool>(nullable: false),
                    Inyecciones = table.Column<bool>(nullable: false),
                    Otros_Cuidados = table.Column<string>(nullable: true),
                    Acto_Sexual = table.Column<bool>(nullable: false),
                    Sintomas = table.Column<string>(nullable: true),
                    Estado_de_Ánimo = table.Column<string>(nullable: true),
                    Notas = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sintoma", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calendario");

            migrationBuilder.DropTable(
                name: "DatoFamiliar");

            migrationBuilder.DropTable(
                name: "DatoPersonal");

            migrationBuilder.DropTable(
                name: "Materno");

            migrationBuilder.DropTable(
                name: "Pareja");

            migrationBuilder.DropTable(
                name: "Paterno");

            migrationBuilder.DropTable(
                name: "Salud");

            migrationBuilder.DropTable(
                name: "Sintoma");
        }
    }
}
