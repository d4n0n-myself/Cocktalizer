﻿// <auto-generated />
using System;
using Cocktalizer.Database.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Cocktalizer.Database.EFCore.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Cocktalizer.Models.Cocktail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("PrepareMethod");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("Cocktails");
                });

            modelBuilder.Entity("Cocktalizer.Models.Ingridient", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("CocktailId");

                    b.Property<bool>("Decoration");

                    b.Property<double>("MeasurementValue");

                    b.Property<long?>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("CocktailId");

                    b.HasIndex("ProductId");

                    b.ToTable("Ingridients");
                });

            modelBuilder.Entity("Cocktalizer.Models.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<int>("Measurment");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Cocktalizer.Models.Ingridient", b =>
                {
                    b.HasOne("Cocktalizer.Models.Cocktail", "Cocktail")
                        .WithMany()
                        .HasForeignKey("CocktailId");

                    b.HasOne("Cocktalizer.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });
#pragma warning restore 612, 618
        }
    }
}
