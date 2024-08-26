﻿// <auto-generated />
using System;
using Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace console_app.Migrations
{
    [DbContext(typeof(PruebaContext))]
    partial class PruebaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.AutorLibro", b =>
                {
                    b.Property<Guid>("AutorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CiudadId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AutorId");

                    b.HasIndex("CiudadId");

                    b.ToTable("AutorLibro");
                });

            modelBuilder.Entity("Models.Ciudades", b =>
                {
                    b.Property<Guid>("CiudadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CiudadId");

                    b.ToTable("Ciudades");
                });

            modelBuilder.Entity("Models.Libro", b =>
                {
                    b.Property<Guid>("LibroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AnioPublicacion")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("AutorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LibroId");

                    b.HasIndex("AutorId");

                    b.ToTable("Libro");
                });

            modelBuilder.Entity("Models.AutorLibro", b =>
                {
                    b.HasOne("Models.Ciudades", "Ciudad")
                        .WithMany("Autores")
                        .HasForeignKey("CiudadId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Ciudad");
                });

            modelBuilder.Entity("Models.Libro", b =>
                {
                    b.HasOne("Models.AutorLibro", "Autor")
                        .WithMany("Libros")
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Autor");
                });

            modelBuilder.Entity("Models.AutorLibro", b =>
                {
                    b.Navigation("Libros");
                });

            modelBuilder.Entity("Models.Ciudades", b =>
                {
                    b.Navigation("Autores");
                });
#pragma warning restore 612, 618
        }
    }
}
