﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parqueadero.App.Persistencia;

#nullable disable

namespace Parqueadero.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220925175404_cuarta")]
    partial class cuarta
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Parqueadero.App.Dominio.Lugar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Numero_puesto")
                        .HasColumnType("int");

                    b.Property<bool>("aprobacion")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("lugares");
                });

            modelBuilder.Entity("Parqueadero.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estacionamiento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("horario")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numero_vehiculos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("personas");
                });

            modelBuilder.Entity("Parqueadero.App.Dominio.Porhoras", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("entrada")
                        .HasColumnType("datetime2");

                    b.Property<string>("motivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("salida")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("porhorass");
                });

            modelBuilder.Entity("Parqueadero.App.Dominio.Tiempocompleto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("aprobacion")
                        .HasColumnType("bit");

                    b.Property<DateTime>("fecha_salida")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("hora_entrada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("hora_salida")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("tiempocompletoss");
                });

            modelBuilder.Entity("Parqueadero.App.Dominio.Transaccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("acceso")
                        .HasColumnType("datetime2");

                    b.Property<string>("pago")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("salida")
                        .HasColumnType("datetime2");

                    b.Property<int>("tarifa")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("transacciones");
                });

            modelBuilder.Entity("Parqueadero.App.Dominio.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipo_vehiculo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("vehiculoss");
                });
#pragma warning restore 612, 618
        }
    }
}
