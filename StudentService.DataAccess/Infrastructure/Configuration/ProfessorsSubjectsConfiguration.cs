using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace DataAccess.Infrastructure.Configuration
{
    public class ProfessorsSubjectsConfiguration : IEntityTypeConfiguration<ProfessorsSubjects>
    {
        public void Configure(EntityTypeBuilder<ProfessorsSubjects> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}
