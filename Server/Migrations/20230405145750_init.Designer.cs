﻿// <auto-generated />
using DataAccess.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Server.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230405145750_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("Model.Student", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("IndexNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("StudyProgramId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("YearOfStudy")
                        .HasColumnType("INTEGER");

                    b.Property<int>("methodOfFinancing")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Model.StudentListensSub", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PassedOrNot")
                        .HasColumnType("INTEGER");

                    b.Property<long>("StudentId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("SubjectId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("YearOfStudy")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("StudentListensSubs");
                });

            modelBuilder.Entity("Model.StudyProgram", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("StudyPrograms");
                });

            modelBuilder.Entity("Model.StudyProgramExams", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("StudyProgramId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("SubjectId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StudyProgramId");

                    b.HasIndex("SubjectId");

                    b.ToTable("StudyProgramExams");
                });

            modelBuilder.Entity("Model.Subject", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Model.Student", b =>
                {
                    b.HasOne("Model.StudyProgram", "StudyProgram")
                        .WithMany("Students")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StudyProgram");
                });

            modelBuilder.Entity("Model.StudentListensSub", b =>
                {
                    b.HasOne("Model.Student", "Student")
                        .WithMany("Subjects")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Subject", "Subject")
                        .WithMany("Students")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Model.StudyProgramExams", b =>
                {
                    b.HasOne("Model.StudyProgram", "StudyProgram")
                        .WithMany("Exams")
                        .HasForeignKey("StudyProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Subject", "Subject")
                        .WithMany("StudyPrograms")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StudyProgram");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Model.Student", b =>
                {
                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("Model.StudyProgram", b =>
                {
                    b.Navigation("Exams");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Model.Subject", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("StudyPrograms");
                });
#pragma warning restore 612, 618
        }
    }
}
