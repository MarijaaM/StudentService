using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace DataAccess.Infrastructure.Configuration
{
    public class StudyProgramConfiguration : IEntityTypeConfiguration<StudyProgram>
    {
        public void Configure(EntityTypeBuilder<StudyProgram> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
        }
    }
}
