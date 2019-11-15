﻿// <auto-generated />
using AsNoTrackingLabs.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AsNoTrackingLabs.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20191103022148_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("AsNoTrackingLabs.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Completed")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Completed")
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .HasColumnName("TaskName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}