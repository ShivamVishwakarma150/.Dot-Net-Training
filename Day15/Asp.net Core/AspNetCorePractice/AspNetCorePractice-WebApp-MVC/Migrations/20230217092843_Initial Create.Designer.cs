﻿// <auto-generated />
using System;
using AspNetCorePractice_WebApp_MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspNetCorePractice_WebApp_MVC.Migrations
{
    [DbContext(typeof(AspNetCorePracticeDbContext))]
    [Migration("20230217092843_Initial Create")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AspNetCorePractice_WebApp_MVC.Models.Batch", b =>
                {
                    b.Property<int>("BatchNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BatchName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartSate")
                        .HasColumnType("datetime2");

                    b.HasKey("BatchNo");

                    b.ToTable("Batches");
                });

            modelBuilder.Entity("AspNetCorePractice_WebApp_MVC.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("PriceOfCourse")
                        .HasColumnType("int");

                    b.Property<string>("Technology")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("AspNetCorePractice_WebApp_MVC.Models.Trainer", b =>
                {
                    b.Property<int>("TrainerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skills")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearOfExperience")
                        .HasColumnType("int");

                    b.HasKey("TrainerId");

                    b.ToTable("Trainers");
                });
#pragma warning restore 612, 618
        }
    }
}
