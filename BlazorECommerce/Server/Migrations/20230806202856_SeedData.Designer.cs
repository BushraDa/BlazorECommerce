﻿// <auto-generated />
using System;
using BlazorECommerce.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorECommerce.Server.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230806202856_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorECommerce.Shared.Product", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            id = new Guid("d226ec89-6275-43a0-8691-9bbec32788e1"),
                            Description = "",
                            Name = "Painting",
                            Price = 1000m
                        },
                        new
                        {
                            id = new Guid("8801a399-3d4a-4806-bde9-f4ad65b27dc5"),
                            Description = "",
                            Name = "Embroidery",
                            Price = 2000m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}