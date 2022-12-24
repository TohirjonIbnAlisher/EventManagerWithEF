
using EventManagement.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventManagement.Broker.Configuration
{
    public class SeatConfiguration : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            builder.ToTable(nameof(Seat));

            builder.HasKey(seat => new {seat.SeatNumber, seat.RoomId });

            builder.HasOne(seat => seat.Room)
                .WithMany(room => room.Seats)
                    .HasForeignKey(seat => seat.RoomId);

        }
    }
}
