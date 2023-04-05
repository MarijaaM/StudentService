using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Infrastructure.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x=>x.IndexNumber).IsRequired();
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x=>x.methodOfFinancing).IsRequired();
            builder.Property(x=>x.YearOfStudy).IsRequired();
            builder.HasOne(x=>x.StudyProgram).WithMany(x=>x.Students).HasForeignKey(x=>x.Id).OnDelete(DeleteBehavior.Cascade);
            

         
        }
    }
}
