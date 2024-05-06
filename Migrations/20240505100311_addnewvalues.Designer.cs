﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyFirstProject.Data;

#nullable disable

namespace MyFirstProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240505100311_addnewvalues")]
    partial class addnewvalues
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyFirstProject.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "ajith",
                            Description = "this is science book",
                            Title = "dynamics"
                        },
                        new
                        {
                            Id = 2,
                            Author = "pathmanathan",
                            Description = "this is physics book",
                            Title = "mechanics"
                        },
                        new
                        {
                            Id = 3,
                            Author = "kumaran",
                            Description = "this is chemistry book",
                            Title = "organnic"
                        },
                        new
                        {
                            Id = 4,
                            Author = "kenthiran",
                            Description = "this is arts book",
                            Title = "shadow"
                        },
                        new
                        {
                            Id = 5,
                            Author = "lathusan",
                            Description = "this is mathematics book",
                            Title = "frame"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
