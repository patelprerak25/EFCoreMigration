using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMigration.Data
{
    public class UserDetailsEntityConfiguration : IEntityTypeConfiguration<UserDetails>
    {
        public void Configure(EntityTypeBuilder<UserDetails> builder)
        {
            builder.ToTable(nameof(UserDetails));

            builder.Property(t => t.Address)
              .HasMaxLength(100)
              .IsRequired();

            builder.Property(t => t.Email)
              .HasMaxLength(100)
              .IsRequired();
        }
    }
}
