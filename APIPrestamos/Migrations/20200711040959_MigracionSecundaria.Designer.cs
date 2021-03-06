﻿// <auto-generated />
using System;
using APIPrestamos.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APIPrestamos.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200711040959_MigracionSecundaria")]
    partial class MigracionSecundaria
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("APIPrestamos.Models.Personas", b =>
                {
                    b.Property<int>("PersonaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Balance")
                        .HasColumnType("REAL");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT")
                        .HasMaxLength(15);

                    b.HasKey("PersonaId");

                    b.ToTable("Personas");

                    b.HasData(
                        new
                        {
                            PersonaId = 1,
                            Balance = 0.0,
                            Cedula = "058-6669531-4",
                            Direccion = "C/27 de Febrero Esq.Castillo",
                            FechaNacimiento = new DateTime(2020, 7, 11, 1, 9, 57, 419, DateTimeKind.Local).AddTicks(5303),
                            Nombre = "Juan Pineda",
                            Telefono = "829-666-6000"
                        });
                });

            modelBuilder.Entity("APIPrestamos.Models.Prestamos", b =>
                {
                    b.Property<int>("PrestamoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Balance")
                        .HasColumnType("REAL");

                    b.Property<string>("Concepto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<double>("Monto")
                        .HasColumnType("REAL");

                    b.Property<int>("PersonaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PrestamoId");

                    b.HasIndex("PersonaId");

                    b.ToTable("Prestamos");
                });

            modelBuilder.Entity("APIPrestamos.Models.Prestamos", b =>
                {
                    b.HasOne("APIPrestamos.Models.Personas", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
