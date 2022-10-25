using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FAQProject.Models;

namespace FAQProject.Models
{
    public class FAQContext : DbContext
    {
        public FAQContext (DbContextOptions<FAQContext> options) : base(options)
        { }

        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FAQ>().HasData(
                new FAQ
                {
                    FAQId = 1,
                    FAQQuestion = "What is JavaScript?",
                    FAQAnswer = "A general purpose scripting language that executes in a web browser.",
                    TopicId = "Js",
                    CategoryId = "G"
                },
                new FAQ
                {
                    FAQId = 2,
                    FAQQuestion = "When was JavaScript first released?",
                    FAQAnswer = "In 1995.",
                    TopicId = "Js",
                    CategoryId = "H"
                },
                new FAQ
                {
                    FAQId = 3,
                    FAQQuestion = "What is Bootstrap?",
                    FAQAnswer = "Bootstrap is the most popular CSS Framework for developing responsive and mobile-first websites.",
                    TopicId = "Bs",
                    CategoryId = "G"
                },
                new FAQ
                {
                    FAQId = 4,
                    FAQQuestion = "When was Bootstrap first released?",
                    FAQAnswer = "In 2011",
                    TopicId = "Bs",
                    CategoryId = "H"
                },
                new FAQ
                {
                    FAQId = 5,
                    FAQQuestion = "What is C#?",
                    FAQAnswer = "C# is a modern, object-oriented, and type-safe programming language.",
                    TopicId = "C",
                    CategoryId = "G"
                },
                new FAQ
                {
                    FAQId = 6,
                    FAQQuestion = "When was C# first released?",
                    FAQAnswer = "In 2002.",
                    TopicId = "C",
                    CategoryId = "H"
                }
            );

            modelBuilder.Entity<Topic>().HasData(
                new Topic { TopicId = "Bs", TopicName = "Bootstrap"},
                new Topic { TopicId = "C", TopicName = "C#"},
                new Topic { TopicId = "Js", TopicName = "JavaScript"}
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "G", CategoryName = "General"},
                new Category { CategoryId = "H", CategoryName = "Histroy"}
                );
        }
    }
}
