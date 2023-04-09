using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace DataAccess.Infrastructure.Configuration
{
    public class ExamConfiguration : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.DateTime);
            builder.Property(x => x.Mark);
            builder.HasOne(x => x.Student)
                   .WithMany(x => x.PreviousExams)
                   .HasForeignKey(x => x.StudentId);
        }
    }
}
