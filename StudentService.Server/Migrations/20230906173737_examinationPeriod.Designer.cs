﻿// <auto-generated />
using System;
using DataAccess.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace StudentService.Server.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230906173737_examinationPeriod")]
    partial class examinationPeriod
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.15");

            modelBuilder.Entity("Model.ExamResult", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("ExamId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Mark")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PassedOrNot")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Results")
                        .HasColumnType("INTEGER");

                    b.Property<long>("StudentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.HasIndex("StudentId");

                    b.ToTable("ExamResults");
                });

            modelBuilder.Entity("Model.StudyProgram", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("StudyPrograms");
                });

            modelBuilder.Entity("Model.StudyProgramSubjects", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("StudyProgramId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("SubjectId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StudyProgramId");

                    b.HasIndex("SubjectId");

                    b.ToTable("StudyProgramSubjects");
                });

            modelBuilder.Entity("Model.Subject", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("ProfessorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Model.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.HasDiscriminator<string>("UserType").HasValue("User");
                });

            modelBuilder.Entity("StudentService.Model.Exam", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClassRoom")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExaminationPeriod")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("SubjectId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("Model.Professor", b =>
                {
                    b.HasBaseType("Model.User");

                    b.HasDiscriminator().HasValue("Professor");
                });

            modelBuilder.Entity("Model.Student", b =>
                {
                    b.HasBaseType("Model.User");

                    b.Property<string>("IndexNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long?>("StudyProgramId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("YearOfStudy")
                        .HasColumnType("INTEGER");

                    b.Property<int>("methodOfFinancing")
                        .HasColumnType("INTEGER");

                    b.HasIndex("IndexNumber")
                        .IsUnique();

                    b.HasIndex("StudyProgramId");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("Model.ExamResult", b =>
                {
                    b.HasOne("StudentService.Model.Exam", "Exam")
                        .WithMany()
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Student", "Student")
                        .WithMany("Exams")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Model.StudyProgramSubjects", b =>
                {
                    b.HasOne("Model.StudyProgram", "StudyProgram")
                        .WithMany()
                        .HasForeignKey("StudyProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StudyProgram");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Model.Subject", b =>
                {
                    b.HasOne("Model.Professor", "Professor")
                        .WithMany("Subjects")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("StudentService.Model.Exam", b =>
                {
                    b.HasOne("Model.Subject", "Subject")
                        .WithMany("Exams")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Model.Student", b =>
                {
                    b.HasOne("Model.StudyProgram", "StudyProgram")
                        .WithMany("Students")
                        .HasForeignKey("StudyProgramId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("StudyProgram");
                });

            modelBuilder.Entity("Model.StudyProgram", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("Model.Subject", b =>
                {
                    b.Navigation("Exams");
                });

            modelBuilder.Entity("Model.Professor", b =>
                {
                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("Model.Student", b =>
                {
                    b.Navigation("Exams");
                });
#pragma warning restore 612, 618
        }
    }
}
