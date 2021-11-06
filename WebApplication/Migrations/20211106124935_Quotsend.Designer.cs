﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication;

namespace WebApplication.Migrations
{
    [DbContext(typeof(QuotesDBContext))]
    [Migration("20211106124935_Quotsend")]
    partial class Quotsend
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("WebApplication.Quote", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Quotes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("add3f7db-1191-44a9-af14-4d6c43384771"),
                            Author = "Pophet Muhammad (SAW)",
                            InsertDate = new DateTime(2021, 11, 6, 17, 49, 34, 602, DateTimeKind.Local).AddTicks(1309),
                            Text = "When a thing distrubs the peace of your hurt give it up"
                        },
                        new
                        {
                            Id = new Guid("e8ae0d48-69e6-4d85-80c1-5e4308c4cf45"),
                            Author = "Ernest Hemingway",
                            InsertDate = new DateTime(2021, 11, 6, 17, 49, 34, 603, DateTimeKind.Local).AddTicks(5457),
                            Text = "In order to write about life first you must live it."
                        },
                        new
                        {
                            Id = new Guid("c00eac12-5046-428f-b619-9b15b578a2f7"),
                            Author = "Albert Einstein",
                            InsertDate = new DateTime(2021, 11, 6, 17, 49, 34, 603, DateTimeKind.Local).AddTicks(5484),
                            Text = "Genius is 1% talent and 99% percent hard work..."
                        },
                        new
                        {
                            Id = new Guid("108eaa30-1f39-4e6c-8155-8802b018be03"),
                            Author = "Will Smith",
                            InsertDate = new DateTime(2021, 11, 6, 17, 49, 34, 603, DateTimeKind.Local).AddTicks(5488),
                            Text = "Money and success don’t change people; they merely amplify what is already there."
                        },
                        new
                        {
                            Id = new Guid("a3b9d1d5-8f64-4eea-bffa-1e27b967b3c9"),
                            Author = "stoicism",
                            InsertDate = new DateTime(2021, 11, 6, 17, 49, 34, 603, DateTimeKind.Local).AddTicks(5492),
                            Text = "Memento mori"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}