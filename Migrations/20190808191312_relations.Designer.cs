﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TodoApi.Contexts;

namespace TodoApi.Migrations
{
    [DbContext(typeof(AuthorContext))]
    [Migration("20190808191312_relations")]
    partial class relations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("TodoApi.Models.Author", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("bornDate");

                    b.Property<string>("firstName");

                    b.Property<string>("lastName");

                    b.HasKey("id");

                    b.ToTable("authors");
                });

            modelBuilder.Entity("TodoApi.Models.Book", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("authorid");

                    b.Property<DateTime>("datePub");

                    b.Property<string>("title");

                    b.HasKey("Id");

                    b.HasIndex("authorid");

                    b.ToTable("books");
                });

            modelBuilder.Entity("TodoApi.Models.Book", b =>
                {
                    b.HasOne("TodoApi.Models.Author", "author")
                        .WithMany("books")
                        .HasForeignKey("authorid");
                });
#pragma warning restore 612, 618
        }
    }
}
