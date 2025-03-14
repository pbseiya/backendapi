﻿// <auto-generated />
using System;
using BackendAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BackendAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250312160523_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BackendAPI.Models.BillOfMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ChildComponentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int?>("MachineId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("ParentComponentId")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ChildComponentId");

                    b.HasIndex("MachineId");

                    b.HasIndex("ParentComponentId");

                    b.ToTable("BillOfMaterials");
                });

            modelBuilder.Entity("BackendAPI.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2025, 3, 12, 16, 5, 23, 374, DateTimeKind.Utc).AddTicks(3550),
                            IsDeleted = false,
                            Name = "Electrical"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2025, 3, 12, 16, 5, 23, 374, DateTimeKind.Utc).AddTicks(3550),
                            IsDeleted = false,
                            Name = "Mechanical"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2025, 3, 12, 16, 5, 23, 374, DateTimeKind.Utc).AddTicks(3550),
                            IsDeleted = false,
                            Name = "Hydraulic"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2025, 3, 12, 16, 5, 23, 374, DateTimeKind.Utc).AddTicks(3550),
                            IsDeleted = false,
                            Name = "Pneumatic"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2025, 3, 12, 16, 5, 23, 374, DateTimeKind.Utc).AddTicks(3560),
                            IsDeleted = false,
                            Name = "Electronic"
                        });
                });

            modelBuilder.Entity("BackendAPI.Models.Component", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("LeadTime")
                        .HasColumnType("int");

                    b.Property<int>("MinimumStock")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PartNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("SupplierId")
                        .HasColumnType("int");

                    b.Property<int?>("UnitOfMeasureId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.HasIndex("UnitOfMeasureId");

                    b.ToTable("Components");
                });

            modelBuilder.Entity("BackendAPI.Models.Machine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("InstallationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("ManufactureDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Manufacturer")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ModelNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SerialNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("BackendAPI.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ContactPerson")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Notes")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Phone")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("BackendAPI.Models.UnitOfMeasure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("UnitOfMeasures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Abbreviation = "pc",
                            CreatedAt = new DateTime(2025, 3, 12, 16, 5, 23, 374, DateTimeKind.Utc).AddTicks(3400),
                            IsDeleted = false,
                            Name = "Piece"
                        },
                        new
                        {
                            Id = 2,
                            Abbreviation = "kg",
                            CreatedAt = new DateTime(2025, 3, 12, 16, 5, 23, 374, DateTimeKind.Utc).AddTicks(3400),
                            IsDeleted = false,
                            Name = "Kilogram"
                        },
                        new
                        {
                            Id = 3,
                            Abbreviation = "m",
                            CreatedAt = new DateTime(2025, 3, 12, 16, 5, 23, 374, DateTimeKind.Utc).AddTicks(3400),
                            IsDeleted = false,
                            Name = "Meter"
                        },
                        new
                        {
                            Id = 4,
                            Abbreviation = "L",
                            CreatedAt = new DateTime(2025, 3, 12, 16, 5, 23, 374, DateTimeKind.Utc).AddTicks(3410),
                            IsDeleted = false,
                            Name = "Liter"
                        });
                });

            modelBuilder.Entity("BackendAPI.Models.BillOfMaterial", b =>
                {
                    b.HasOne("BackendAPI.Models.Component", "ChildComponent")
                        .WithMany("ParentBOMs")
                        .HasForeignKey("ChildComponentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BackendAPI.Models.Machine", "Machine")
                        .WithMany("BillOfMaterials")
                        .HasForeignKey("MachineId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BackendAPI.Models.Component", "ParentComponent")
                        .WithMany("ChildBOMs")
                        .HasForeignKey("ParentComponentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ChildComponent");

                    b.Navigation("Machine");

                    b.Navigation("ParentComponent");
                });

            modelBuilder.Entity("BackendAPI.Models.Component", b =>
                {
                    b.HasOne("BackendAPI.Models.Category", "Category")
                        .WithMany("Components")
                        .HasForeignKey("CategoryId");

                    b.HasOne("BackendAPI.Models.Supplier", "Supplier")
                        .WithMany("Components")
                        .HasForeignKey("SupplierId");

                    b.HasOne("BackendAPI.Models.UnitOfMeasure", "UnitOfMeasure")
                        .WithMany("Components")
                        .HasForeignKey("UnitOfMeasureId");

                    b.Navigation("Category");

                    b.Navigation("Supplier");

                    b.Navigation("UnitOfMeasure");
                });

            modelBuilder.Entity("BackendAPI.Models.Category", b =>
                {
                    b.Navigation("Components");
                });

            modelBuilder.Entity("BackendAPI.Models.Component", b =>
                {
                    b.Navigation("ChildBOMs");

                    b.Navigation("ParentBOMs");
                });

            modelBuilder.Entity("BackendAPI.Models.Machine", b =>
                {
                    b.Navigation("BillOfMaterials");
                });

            modelBuilder.Entity("BackendAPI.Models.Supplier", b =>
                {
                    b.Navigation("Components");
                });

            modelBuilder.Entity("BackendAPI.Models.UnitOfMeasure", b =>
                {
                    b.Navigation("Components");
                });
#pragma warning restore 612, 618
        }
    }
}
