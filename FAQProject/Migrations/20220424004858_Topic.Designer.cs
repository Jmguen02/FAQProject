﻿// <auto-generated />
using FAQProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FAQProject.Migrations
{
    [DbContext(typeof(FAQContext))]
    [Migration("20220424004858_Topic")]
    partial class Topic
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FAQProject.Models.FAQ", b =>
                {
                    b.Property<int>("FAQId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FAQAnswer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FAQQuestion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopicId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("FAQId");

                    b.HasIndex("TopicId");

                    b.ToTable("FAQs");

                    b.HasData(
                        new
                        {
                            FAQId = 1,
                            FAQAnswer = "A general purpose scripting language that executes in a web browser.",
                            FAQQuestion = "What is JavaScript?",
                            TopicId = "Js"
                        },
                        new
                        {
                            FAQId = 2,
                            FAQAnswer = "In 1995.",
                            FAQQuestion = "When was JavaScript first released?",
                            TopicId = "Js"
                        },
                        new
                        {
                            FAQId = 3,
                            FAQAnswer = "Bootstrap is the most popular CSS Framework for developing responsive and mobile-first websites.",
                            FAQQuestion = "What is Bootstrap?",
                            TopicId = "Bs"
                        },
                        new
                        {
                            FAQId = 4,
                            FAQAnswer = "In 2011",
                            FAQQuestion = "When was Bootstrap first released?",
                            TopicId = "Bs"
                        },
                        new
                        {
                            FAQId = 5,
                            FAQAnswer = "C# is a modern, object-oriented, and type-safe programming language.",
                            FAQQuestion = "What is C#?",
                            TopicId = "C"
                        },
                        new
                        {
                            FAQId = 6,
                            FAQAnswer = "In 2002.",
                            FAQQuestion = "When was C# first released?",
                            TopicId = "C"
                        });
                });

            modelBuilder.Entity("FAQProject.Models.Topic", b =>
                {
                    b.Property<string>("TopicId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TopicName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TopicId");

                    b.ToTable("Topics");

                    b.HasData(
                        new
                        {
                            TopicId = "Bs",
                            TopicName = "Bootstrap"
                        },
                        new
                        {
                            TopicId = "C",
                            TopicName = "C#"
                        },
                        new
                        {
                            TopicId = "Js",
                            TopicName = "JavaScript"
                        });
                });

            modelBuilder.Entity("FAQProject.Models.FAQ", b =>
                {
                    b.HasOne("FAQProject.Models.Topic", "Topic")
                        .WithMany()
                        .HasForeignKey("TopicId");
                });
#pragma warning restore 612, 618
        }
    }
}
