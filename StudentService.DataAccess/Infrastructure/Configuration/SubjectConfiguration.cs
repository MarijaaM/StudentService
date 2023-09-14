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
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
            builder.HasMany(x => x.Exams).WithOne(x => x.Subject).HasForeignKey(x => x.SubjectId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Professor).WithMany(x => x.Subjects).HasForeignKey(x => x.ProfessorId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
