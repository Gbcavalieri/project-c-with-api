﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RoadOfDreams.Data;

#nullable disable

namespace RoadOfDreams.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240107001324_firstmigration")]
    partial class firstmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("RoadOfDreams.Model.Passagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_passagens");

                    b.Property<string>("Agencia")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("agencia");

                    b.Property<string>("Destino")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("destino");

                    b.Property<string>("Ida")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("data_ida");

                    b.Property<string>("Lugares")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("quantidade_lugares");

                    b.Property<string>("Origem")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("origem");

                    b.Property<string>("Volta")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("data_volta");

                    b.HasKey("Id");

                    b.ToTable("Passagens");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Agencia = "Aquiraz",
                            Destino = "Rio de Janeiro",
                            Ida = "27/07",
                            Lugares = "2",
                            Origem = "São Paulo",
                            Volta = "27/07"
                        },
                        new
                        {
                            Id = 2,
                            Agencia = "Aquiraz",
                            Destino = "Rio de Janeiro",
                            Ida = "27/07",
                            Lugares = "2",
                            Origem = "São Paulo",
                            Volta = "27/07"
                        },
                        new
                        {
                            Id = 3,
                            Agencia = "Aquiraz",
                            Destino = "Rio de Janeiro",
                            Ida = "27/07",
                            Lugares = "2",
                            Origem = "São Paulo",
                            Volta = "27/07"
                        },
                        new
                        {
                            Id = 4,
                            Agencia = "Aquiraz",
                            Destino = "Rio de Janeiro",
                            Ida = "27/07",
                            Lugares = "2",
                            Origem = "São Paulo",
                            Volta = "27/07"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
