using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace DataAccess.Infrastructure.Configuration
{
    public class ProfessorConfiguation : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.FirstName);
            builder.Property(x => x.LastName);
            builder.Property(x => x.Email);
        }
    }
}
