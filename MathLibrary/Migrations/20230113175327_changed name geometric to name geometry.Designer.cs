﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServiceLibrary.Data;

#nullable disable

namespace ServiceLibrary.Data.Data.Data.Menus.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230113175327_changed name geometric to name geometry")]
    partial class changednamegeometrictonamegeometry
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ServiceLibrary.Data.CalculationResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfCalculation")
                        .HasColumnType("datetime2");

                    b.Property<double>("EquationResult")
                        .HasColumnType("float");

                    b.Property<double>("FirstNumber")
                        .HasColumnType("float");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Operator")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<double>("SecondNumber")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("CalculationResults");
                });

            modelBuilder.Entity("ServiceLibrary.Data.GameResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("AveragePlayerWins")
                        .HasColumnType("float");

                    b.Property<DateTime>("DateOfGameResult")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumberOfComputerWins")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfPlayerWins")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GameResults");
                });

            modelBuilder.Entity("ServiceLibrary.Data.GeometryResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Area")
                        .HasColumnType("float");

                    b.Property<DateTime>("DateOfGeometryResult")
                        .HasColumnType("datetime2");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<double>("Perimiter")
                        .HasColumnType("float");

                    b.Property<int>("ShapeId")
                        .HasColumnType("int");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ShapeId");

                    b.ToTable("GeometryResults");
                });

            modelBuilder.Entity("ServiceLibrary.Data.Shape", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TypeOfShape")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shapes");
                });

            modelBuilder.Entity("ServiceLibrary.Data.GeometryResult", b =>
                {
                    b.HasOne("ServiceLibrary.Data.Shape", "Shape")
                        .WithMany()
                        .HasForeignKey("ShapeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shape");
                });
#pragma warning restore 612, 618
        }
    }
}
