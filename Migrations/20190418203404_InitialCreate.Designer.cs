﻿// <auto-generated />
using Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Final_Project.Migrations
{
    [DbContext(typeof(FinalProjectContext))]
    [Migration("20190418203404_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("Final_Project.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("RecipeID");

                    b.HasKey("CategoryID");

                    b.HasIndex("RecipeID")
                        .IsUnique();

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Final_Project.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ingredients");

                    b.Property<int>("Title")
                        .HasMaxLength(60);

                    b.HasKey("RecipeID");

                    b.ToTable("Recipe");
                });

            modelBuilder.Entity("Final_Project.Models.Review", b =>
                {
                    b.Property<int>("ReviewID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RecipeID");

                    b.Property<int>("Score");

                    b.HasKey("ReviewID");

                    b.HasIndex("RecipeID");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("Final_Project.Models.Category", b =>
                {
                    b.HasOne("Final_Project.Models.Recipe")
                        .WithOne("Category")
                        .HasForeignKey("Final_Project.Models.Category", "RecipeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Final_Project.Models.Review", b =>
                {
                    b.HasOne("Final_Project.Models.Recipe", "Recipe")
                        .WithMany("Reviews")
                        .HasForeignKey("RecipeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}