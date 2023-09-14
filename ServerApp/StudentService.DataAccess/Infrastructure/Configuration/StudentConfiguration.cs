﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;
using System.Reflection.Emit;

namespace DataAccess.Infrastructure.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {

            builder.HasIndex(x => x.IndexNumber).IsUnique();
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.methodOfFinancing).IsRequired();
            builder.Property(x => x.YearOfStudy).IsRequired();
            builder.HasOne(x => x.StudyProgram)
                   .WithMany(x => x.Students)
                   .HasForeignKey(x => x.StudyProgramId)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}