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
    public class StudentListensSubConfiguration : IEntityTypeConfiguration<StudentListensSub>
    {
        public void Configure(EntityTypeBuilder<StudentListensSub> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Student).WithMany(x => x.Subjects).HasForeignKey(x => x.StudentId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Subject).WithMany(x => x.Students).HasForeignKey(x => x.SubjectId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
