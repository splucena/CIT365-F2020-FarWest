﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorMegaDesk.Data;

namespace RazorMegaDesk.Migrations
{
    [DbContext(typeof(RazorMegaDeskContext))]
    [Migration("20201105153554_Seed")]
    partial class Seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RazorMegaDesk.Models.Desk", b =>
                {
                    b.Property<int>("DeskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("NumberOfDrawer")
                        .HasColumnType("int");

                    b.Property<int>("ProductionTimeID")
                        .HasColumnType("int");

                    b.Property<int>("SurfaceMaterialID")
                        .HasColumnType("int");

                    b.Property<decimal>("Width")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("DeskID");

                    b.HasIndex("ProductionTimeID");

                    b.HasIndex("SurfaceMaterialID");

                    b.ToTable("Desk");
                });

            modelBuilder.Entity("RazorMegaDesk.Models.ProductionTime", b =>
                {
                    b.Property<int>("ProductionTimeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Days")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductionTimeID");

                    b.ToTable("ProductionTime");
                });

            modelBuilder.Entity("RazorMegaDesk.Models.SurfaceMaterial", b =>
                {
                    b.Property<int>("SurfaceMaterialID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("SurfaceMaterialID");

                    b.ToTable("SurfaceMaterial");
                });

            modelBuilder.Entity("RazorMegaDesk.Models.Desk", b =>
                {
                    b.HasOne("RazorMegaDesk.Models.ProductionTime", "ProductionTime")
                        .WithMany()
                        .HasForeignKey("ProductionTimeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RazorMegaDesk.Models.SurfaceMaterial", "SurfaceMaterial")
                        .WithMany("Desks")
                        .HasForeignKey("SurfaceMaterialID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
