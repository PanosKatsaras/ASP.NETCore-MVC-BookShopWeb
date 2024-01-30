﻿// <auto-generated />
using BulkyDataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BulkyDataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240107130345_InsertSeedDataToProductsTableInDB")]
    partial class InsertSeedDataToProductsTableInDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BulkyModels.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Adventure"
                        });
                });

            modelBuilder.Entity("BulkyModels.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price20")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Stieg Larsson",
                            CategoryId = 1,
                            Description = "The two primary characters in the saga are Lisbeth Salander, an asocial computer hacker with a photographic memory, and Mikael Blomkvist, an investigative journalist.",
                            ISBN = "SW9780307949486",
                            Price = 40.0,
                            Price20 = 25.0,
                            Price50 = 20.0,
                            Title = "The Girl with the Dragon Tattoo"
                        },
                        new
                        {
                            Id = 2,
                            Author = "J.R.R. Tolkien",
                            CategoryId = 3,
                            Description = "Follow hobbit icon Frodo and his friends on his perilous, unforgettable journey to destroy the One Ring, once and for all.",
                            ISBN = "CA9780544003415",
                            Price = 50.0,
                            Price20 = 40.0,
                            Price50 = 30.0,
                            Title = "The Lord of the Rings"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Suzanne Collins",
                            CategoryId = 2,
                            Description = "The Hunger Games follows 16-year-old Katniss Everdeen, a girl from District 12 who volunteers for the 74th Hunger Games in place of her younger sister Primrose Everdeen.",
                            ISBN = "RI9781627656368",
                            Price = 50.0,
                            Price20 = 40.0,
                            Price50 = 35.0,
                            Title = "The Hunger Games"
                        },
                        new
                        {
                            Id = 4,
                            Author = "J.K. Rowling",
                            CategoryId = 2,
                            Description = "Harry Potter is about to start his fifth year at Hogwarts School of Witchcraft and Wizardry.Harry never enjoys his summer holidays, but this summer is even worse than usual. ",
                            ISBN = "WS9780747532743",
                            Price = 65.0,
                            Price20 = 60.0,
                            Price50 = 55.0,
                            Title = "Harry Potter"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Yann Martel",
                            CategoryId = 3,
                            Description = "The protagonist, Piscine Molitor 'Pi' Patel, a Tamil boy from Pondicherry, explores issues of spirituality and practicality from an early age. ",
                            ISBN = "ST0156030209",
                            Price = 20.0,
                            Price20 = 15.0,
                            Price50 = 10.0,
                            Title = "Life of Pi"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Jon Krakauer",
                            CategoryId = 3,
                            Description = "A young man from a well-to-do family hitchhiked to Alaska and walked alone into the wilderness north of Mt. McKinley.",
                            ISBN = "FO9780307387172",
                            Price = 25.0,
                            Price20 = 20.0,
                            Price50 = 15.0,
                            Title = "Into the Wild"
                        });
                });

            modelBuilder.Entity("BulkyModels.Product", b =>
                {
                    b.HasOne("BulkyModels.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
