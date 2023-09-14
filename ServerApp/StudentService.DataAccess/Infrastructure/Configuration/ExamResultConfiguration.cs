using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace DataAccess.Infrastructure.Configuration
{
    public class ExamResultConfiguration : IEntityTypeConfiguration<ExamResult>
    {
        public void Configure(EntityTypeBuilder<ExamResult> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Mark);

            builder.HasOne(x => x.Student)
                  .WithMany(x => x.Exams)
                  .HasForeignKey(x => x.StudentId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
