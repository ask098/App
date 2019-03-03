﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Wayuu.DAL;

namespace Wayuu.DAL.Migrations
{
    [DbContext(typeof(WayuuContext))]
    partial class WayuuContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
<<<<<<< HEAD
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
=======
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
>>>>>>> origin/Student
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Wayuu.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Description");

                    b.Property<string>("Duration");

                    b.Property<int>("Enroll");

                    b.Property<DateTime>("FinishDate");

                    b.Property<int>("MaxCapacity");

                    b.Property<string>("Name");

                    b.Property<string>("Place");

                    b.Property<DateTime>("Schedule");

                    b.Property<int>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Wayuu.Entities.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("now()");

                    b.Property<string>("Message");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("Wayuu.Entities.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime>("Creation_date")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("now()");

                    b.Property<string>("Description");

                    b.Property<string>("Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int>("Telephone");

                    b.HasKey("Id");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("Wayuu.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<int>("Birthdate");

                    b.Property<long>("Cid");

                    b.Property<int>("CourseId");

                    b.Property<DateTime>("DateAdmission");

                    b.Property<string>("Department");

                    b.Property<string>("Email");

                    b.Property<string>("Gender");

                    b.Property<string>("Municipality");

                    b.Property<string>("Name");

                    b.Property<int>("SchoolId");

                    b.Property<string>("SecondSurname");

                    b.Property<string>("Surname");

                    b.Property<int>("Telephone");

                    b.Property<string>("TipeCid");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("SchoolId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Wayuu.Entities.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Identification");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("SchoolId");

                    b.Property<string>("SecondSurname");

                    b.Property<string>("Surname");

                    b.Property<int>("Telephone");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Wayuu.Entities.Course", b =>
                {
                    b.HasOne("Wayuu.Entities.Teacher")
                        .WithMany("Courses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wayuu.Entities.Student", b =>
                {
                    b.HasOne("Wayuu.Entities.Course")
                        .WithMany("Students")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Wayuu.Entities.School")
                        .WithMany("Students")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wayuu.Entities.Teacher", b =>
                {
                    b.HasOne("Wayuu.Entities.School")
                        .WithMany("Teachers")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
