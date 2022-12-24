using EventManagement.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventManagement.Broker.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(user => user.Id);

            builder.HasMany(user => user.Events)
                .WithOne(eventt => eventt.Company)
                    .HasForeignKey(eventt => eventt.CompanyId);

            builder.Property(user => user.UserName)
                .HasMaxLength(30).IsRequired();

            builder.Property(user => user.Password)
                .HasMaxLength(30).IsRequired();

            builder.HasData(CreateSeedData());

        }

        private Users CreateSeedData()
        {
            return new Users
            {
                UserName = "Jasurbek",
                Password = "jasurbek7378",
                TellNumber = "nechidur4422",
                Role = Role.Admin
            };
        }
    }
}
