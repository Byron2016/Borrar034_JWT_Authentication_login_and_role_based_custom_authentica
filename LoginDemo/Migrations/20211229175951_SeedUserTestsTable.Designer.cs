﻿// <auto-generated />
using LoginDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LoginDemo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211229175951_SeedUserTestsTable")]
    partial class SeedUserTestsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("LoginDemo.Models.UserTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("UserTests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "a.yahoo.com",
                            Name = "a",
                            Password = "b"
                        },
                        new
                        {
                            Id = 2,
                            Email = "a2.yahoo.com",
                            Name = "a2",
                            Password = "b2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}