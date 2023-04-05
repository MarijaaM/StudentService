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
    public class StudyProgramConfiguration : IEntityTypeConfiguration<StudyProgram>
    {
        public void Configure(EntityTypeBuilder<StudyProgram> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Name).IsRequired();
            builder.Property(x=>x.Year).IsRequired();
            
        }
    }
}
