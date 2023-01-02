
using EventManagement.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventManagement.Broker.Configuration
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.ToTable(nameof(Room));

            builder.HasKey(room => room.RoomNumber);

            builder.Property(room => 
                room.Name).IsRequired();
            
            builder.Property(room => 
                room.Capacity).IsRequired();

            builder.HasMany(room => room.Seats)
                .WithOne(seat => seat.Room)
                    .HasForeignKey(room => room.SeatNumber);

            builder.HasMany(room => room.Events)
                .WithOne(e => e.Room)
                    .HasForeignKey(room => room.RoomNumber);
        }
    }
}
