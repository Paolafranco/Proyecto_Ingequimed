﻿// <auto-generated />
using System;
using Ginecologia_Ingequimed.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ginecologia_Ingequimed.Migrations
{
    [DbContext(typeof(MainContext))]
    [Migration("20210415180543_Preeclampsias")]
    partial class Preeclampsias
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ginecologia_Ingequimed.Models.Calendario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Año")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Día")
                        .HasColumnType("int");

                    b.Property<string>("Hora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Calendario");
                });

            modelBuilder.Entity("Ginecologia_Ingequimed.Models.DatoFamiliar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("ImagenProducto")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("DatoFamiliar");
                });

            modelBuilder.Entity("Ginecologia_Ingequimed.Models.DatoPersonal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Alergias")
                        .HasColumnType("bit");

                    b.Property<bool>("Cesárea")
                        .HasColumnType("bit");

                    b.Property<bool>("Cirugías")
                        .HasColumnType("bit");

                    b.Property<string>("Edad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Embarazos")
                        .HasColumnType("bit");

                    b.Property<bool>("Habitos")
                        .HasColumnType("bit");

                    b.Property<bool>("Patalogías")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("DatoPersonal");
                });

            modelBuilder.Entity("Ginecologia_Ingequimed.Models.Enfermedades", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Enfermedades");
                });

            modelBuilder.Entity("Ginecologia_Ingequimed.Models.Materno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Enfermedad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_Pariente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parentesco")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Materno");
                });

            modelBuilder.Entity("Ginecologia_Ingequimed.Models.Pareja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Anticonceptivo")
                        .HasColumnType("bit");

                    b.Property<bool>("Enfermedades")
                        .HasColumnType("bit");

                    b.Property<bool>("Ets")
                        .HasColumnType("bit");

                    b.Property<bool>("Gonorrea")
                        .HasColumnType("bit");

                    b.Property<bool>("HIV")
                        .HasColumnType("bit");

                    b.Property<bool>("Hvp")
                        .HasColumnType("bit");

                    b.Property<bool>("Impotencia")
                        .HasColumnType("bit");

                    b.Property<string>("NombreAnticonceptivo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreEnfermedades")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Otros")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Pareja");
                });

            modelBuilder.Entity("Ginecologia_Ingequimed.Models.Paterno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Enfermedad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_Pariente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parentesco")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Paterno");
                });

            modelBuilder.Entity("Ginecologia_Ingequimed.Models.Preeclampsia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Preeclampsia");
                });

            modelBuilder.Entity("Ginecologia_Ingequimed.Models.Salud", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alimentación")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Embarazo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fitness")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Salud");
                });

            modelBuilder.Entity("Ginecologia_Ingequimed.Models.SindromePremestrual", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("SindromePremestrual");
                });

            modelBuilder.Entity("Ginecologia_Ingequimed.Models.Sintoma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Acto_Sexual")
                        .HasColumnType("bit");

                    b.Property<int>("Días_de_Periodo")
                        .HasColumnType("int");

                    b.Property<string>("Estado_de_Ánimo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Fin_del_Periodo")
                        .HasColumnType("int");

                    b.Property<bool>("Inyecciones")
                        .HasColumnType("bit");

                    b.Property<string>("Notas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Otros_Cuidados")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Pastillas")
                        .HasColumnType("bit");

                    b.Property<string>("Sintomas")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sintoma");
                });
#pragma warning restore 612, 618
        }
    }
}
