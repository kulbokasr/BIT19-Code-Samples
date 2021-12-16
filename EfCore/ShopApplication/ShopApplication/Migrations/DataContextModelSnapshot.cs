﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopApplication.Data;

namespace ShopApplication.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShopApplication.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ExpirityDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShopId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExpirityDate = new DateTime(2021, 12, 16, 16, 52, 25, 253, DateTimeKind.Utc).AddTicks(5009),
                            Name = "Item1",
                            ShopId = 1
                        },
                        new
                        {
                            Id = 2,
                            ExpirityDate = new DateTime(2021, 12, 16, 16, 52, 25, 253, DateTimeKind.Utc).AddTicks(5859),
                            Name = "Item2",
                            ShopId = 1
                        },
                        new
                        {
                            Id = 3,
                            ExpirityDate = new DateTime(2021, 12, 16, 16, 52, 25, 253, DateTimeKind.Utc).AddTicks(5862),
                            Name = "Item3",
                            ShopId = 1
                        },
                        new
                        {
                            Id = 4,
                            ExpirityDate = new DateTime(2021, 12, 16, 16, 52, 25, 253, DateTimeKind.Utc).AddTicks(5863),
                            Name = "Item4",
                            ShopId = 2
                        },
                        new
                        {
                            Id = 5,
                            ExpirityDate = new DateTime(2021, 12, 16, 16, 52, 25, 253, DateTimeKind.Utc).AddTicks(5864),
                            Name = "Item5",
                            ShopId = 2
                        });
                });

            modelBuilder.Entity("ShopApplication.Models.Shop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shops");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Shop1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Shop2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Shop3"
                        });
                });

            modelBuilder.Entity("ShopApplication.Models.Item", b =>
                {
                    b.HasOne("ShopApplication.Models.Shop", "Shop")
                        .WithMany("Items")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("ShopApplication.Models.Shop", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}