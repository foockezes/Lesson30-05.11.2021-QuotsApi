using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication
{
    public class QuotesDBContext : DbContext
    {
        public QuotesDBContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Quote>().HasData
                (
                new Quote
                {
                    Id = Guid.NewGuid(),
                    Text = "When a thing distrubs the peace of your hurt give it up",
                    Author = "Pophet Muhammad (SAW)",
                    InsertDate = DateTime.Now
                },
            new Quote
            {
                Id = Guid.NewGuid(),
                Text = "In order to write about life first you must live it.",
                Author = "Ernest Hemingway",
                InsertDate = DateTime.Now
            },
            new Quote
            {
                Id = Guid.NewGuid(),
                Text = "Genius is 1% talent and 99% percent hard work...",
                Author = "Albert Einstein",
                InsertDate = DateTime.Now
            },
            new Quote
            {
                Id = Guid.NewGuid(),
                Text = "Money and success don’t change people; they merely amplify what is already there.",
                Author = "Will Smith",
                InsertDate = DateTime.Now
            },

            new Quote
            {
                Id = Guid.NewGuid(),
                Text = "Memento mori",
                Author = "stoicism",
                InsertDate = DateTime.Now
            }
                );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=quotedb.db");
        }

        public DbSet<Quote> Quotes { get; set; }

        public QuotesDBContext()
        {
        }

    }
}
