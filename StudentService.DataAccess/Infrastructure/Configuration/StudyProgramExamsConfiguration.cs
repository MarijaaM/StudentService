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
    public class StudyProgramExamsConfiguration : IEntityTypeConfiguration<StudyProgramSubject>
    {
        public void Configure(EntityTypeBuilder<StudyProgramSubject> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

        }
    }
}
