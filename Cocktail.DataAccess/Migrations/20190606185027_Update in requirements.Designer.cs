﻿// <auto-generated />
using Cocktails.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cocktails.Persistance.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190606185027_Update in requirements")]
    partial class Updateinrequirements
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cocktails.Domain.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Cocktails.Domain.Models.Cocktail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alcoholic");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Glass");

                    b.Property<string>("Instructions");

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<string>("Tags");

                    b.Property<string>("Thumb");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Cocktails");
                });

            modelBuilder.Entity("Cocktails.Domain.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Cocktails.Persistence.Contexts.CocktailIngredient", b =>
                {
                    b.Property<int>("CocktailId");

                    b.Property<int>("IngredientId");

                    b.HasKey("CocktailId", "IngredientId");

                    b.HasIndex("IngredientId");

                    b.ToTable("CocktailIngredient");
                });

            modelBuilder.Entity("Cocktails.Domain.Models.Cocktail", b =>
                {
                    b.HasOne("Cocktails.Domain.Models.Category", "Category")
                        .WithMany("Cocktails")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cocktails.Persistence.Contexts.CocktailIngredient", b =>
                {
                    b.HasOne("Cocktails.Domain.Models.Cocktail", "Cocktail")
                        .WithMany("IngredientsTo")
                        .HasForeignKey("CocktailId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Cocktails.Domain.Models.Ingredient", "Ingredient")
                        .WithMany("CocktailWith")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
