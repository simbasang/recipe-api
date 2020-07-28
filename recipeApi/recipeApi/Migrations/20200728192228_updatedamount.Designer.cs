﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using recipeApi;

namespace recipeApi.Migrations
{
    [DbContext(typeof(RecepieDbContext))]
    [Migration("20200728192228_updatedamount")]
    partial class updatedamount
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-preview.4.20220.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("recipeApi.Models.AmountType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("AmountType");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "dl"
                        },
                        new
                        {
                            ID = 2,
                            Name = "msk"
                        },
                        new
                        {
                            ID = 3,
                            Name = "tsk"
                        },
                        new
                        {
                            ID = 4,
                            Name = "gram"
                        });
                });

            modelBuilder.Entity("recipeApi.Models.Ingrediens", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Ingrediens");
                });

            modelBuilder.Entity("recipeApi.Models.RecepieIngrediens", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AmountTypeID")
                        .HasColumnType("int");

                    b.Property<int?>("IngrediensID")
                        .HasColumnType("int");

                    b.Property<int?>("RecepiesID")
                        .HasColumnType("int");

                    b.Property<double>("amount")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("AmountTypeID");

                    b.HasIndex("IngrediensID");

                    b.HasIndex("RecepiesID");

                    b.ToTable("RecepieIngrediens");
                });

            modelBuilder.Entity("recipeApi.Models.Recepies", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Instructions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Recepies");
                });

            modelBuilder.Entity("recipeApi.Models.RecepieIngrediens", b =>
                {
                    b.HasOne("recipeApi.Models.AmountType", null)
                        .WithMany("RecipeIngrediens")
                        .HasForeignKey("AmountTypeID");

                    b.HasOne("recipeApi.Models.Ingrediens", null)
                        .WithMany("RecipeIngrediens")
                        .HasForeignKey("IngrediensID");

                    b.HasOne("recipeApi.Models.Recepies", null)
                        .WithMany("RecipeIngrediens")
                        .HasForeignKey("RecepiesID");
                });
#pragma warning restore 612, 618
        }
    }
}