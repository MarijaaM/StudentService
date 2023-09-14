using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace StudentService.DataAccess.Infrastructure.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Password).IsRequired();
            builder.HasDiscriminator<string>("UserType")
        .HasValue<Student>("Student")
        .HasValue<Professor>("Professor");
            builder.ToTable("Users");
        }
    }
}
