using System;
using BulkyModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BulkyDataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Mystery", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Fantasy", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Adventure", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "The Girl with the Dragon Tattoo",
                    Author = "Stieg Larsson",
                    Description = "The two primary characters in the saga are Lisbeth Salander, an asocial computer hacker with a photographic memory, and Mikael Blomkvist, an investigative journalist.",
                    ISBN = "SW9780307949486",
                    Price = 40,
                    Price20 = 25,
                    Price50 = 20,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "The Lord of the Rings",
                    Author = "J.R.R. Tolkien",
                    Description = "Follow hobbit icon Frodo and his friends on his perilous, unforgettable journey to destroy the One Ring, once and for all.",
                    ISBN = "CA9780544003415",
                    Price = 50,
                    Price20 = 40,
                    Price50 = 30,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "The Hunger Games",
                    Author = "Suzanne Collins",
                    Description = "The Hunger Games follows 16-year-old Katniss Everdeen, a girl from District 12 who volunteers for the 74th Hunger Games in place of her younger sister Primrose Everdeen.",
                    ISBN = "RI9781627656368",
                    Price = 50,
                    Price20 = 40,
                    Price50 = 35,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Title = "Harry Potter",
                    Author = "J.K. Rowling",
                    Description = "Harry Potter is about to start his fifth year at Hogwarts School of Witchcraft and Wizardry.Harry never enjoys his summer holidays, but this summer is even worse than usual. ",
                    ISBN = "WS9780747532743",
                    Price = 65,
                    Price20 = 60,
                    Price50 = 55,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Title = "Life of Pi",
                    Author = "Yann Martel",
                    Description = "The protagonist, Piscine Molitor 'Pi' Patel, a Tamil boy from Pondicherry, explores issues of spirituality and practicality from an early age. ",
                    ISBN = "ST0156030209",
                    Price = 20,
                    Price20 = 15,
                    Price50 = 10,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    Title = "Into the Wild",
                    Author = "Jon Krakauer",
                    Description = "A young man from a well-to-do family hitchhiked to Alaska and walked alone into the wilderness north of Mt. McKinley.",
                    ISBN = "FO9780307387172",
                    Price = 25,
                    Price20 = 20,
                    Price50 = 15,
                    CategoryId = 3,
                    ImageUrl = ""
                });
        }
    }
}
