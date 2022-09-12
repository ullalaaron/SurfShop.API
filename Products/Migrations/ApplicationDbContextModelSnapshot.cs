﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Products.Data;

#nullable disable

namespace Products.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Products.Data.Entities.Product", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("89917829-b744-44ec-bfb5-929e1e9ef06a"),
                            ImageURL = "",
                            Name = "The Bombster",
                            Price = 999.0
                        },
                        new
                        {
                            Id = new Guid("086ca54e-2085-4689-a664-5d5416fa230d"),
                            ImageURL = "",
                            Name = "The Bombastic",
                            Price = 1049.0
                        },
                        new
                        {
                            Id = new Guid("b03036b8-3e6a-42a5-a12d-31997a72d182"),
                            ImageURL = "",
                            Name = "The Gigastic",
                            Price = 1199.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
