using jwt.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace jwt.Data.Infra.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("user");

            builder.Property(c => c.Id)
                .HasColumnName("id");

            builder.Property(c => c.Username)
                .HasColumnName("username")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Email)
                .HasColumnName("email")
                .HasColumnType("varchar(25)")
                .HasMaxLength(25);

            builder.Property(c => c.Password)
                .HasColumnName("password")
                .HasColumnType("varchar(500)")
                .HasMaxLength(500);

            builder.Property(c => c.Created)
                .HasColumnName("created");

            builder.Property(c => c.Updated)
                .HasColumnName("updated");
        }
    }
}
