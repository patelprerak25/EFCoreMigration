using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMigration.Data
{
    public class UsersEntityConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable(nameof(Users));

            builder.Property(t => t.UserName)
              .HasMaxLength(100)
              .IsRequired();

            builder.Property(t => t.Password)
                  .HasMaxLength(100)
                  .IsRequired();
        }
    }
}
