﻿// <auto-generated />
using System;
using BlazorApp.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorApp.Api.Migrations
{
    [DbContext(typeof(BlazorDBContext))]
    partial class BlazorDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorApp.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Library")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Library = 1,
                            PublishDate = new DateTime(2022, 1, 21, 13, 6, 18, 133, DateTimeKind.Local).AddTicks(2730),
                            Title = "Quo Vadis"
                        },
                        new
                        {
                            Id = 2,
                            Library = 2,
                            PublishDate = new DateTime(2022, 1, 21, 13, 6, 18, 133, DateTimeKind.Local).AddTicks(2775),
                            Title = "Dracula"
                        });
                });

            modelBuilder.Entity("BlazorApp.Models.Library", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Libraries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Cervantes"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Obispo"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}