
using EventManagement.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventManagement.Broker.Configuration
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("Event");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.EventName)
                .HasMaxLength(40).IsRequired();

            builder.Property(e => 
                e.StartAt).IsRequired();
            
            builder.Property(e => 
                e.EndAt).IsRequired();

            builder.HasOne(e => e.Company)
                .WithMany(company => company.Events)
                    .HasForeignKey(e => e.CompanyId);

            builder.HasOne(e => e.Room)
                .WithMany(room => room.Events);
        }
    }
}
