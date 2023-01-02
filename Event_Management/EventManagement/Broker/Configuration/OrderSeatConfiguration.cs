using EventManagement.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventManagement.Broker.Configuration
{
    public class OrderSeatConfiguration : IEntityTypeConfiguration<OrderSeat>
    {
        public void Configure(EntityTypeBuilder<OrderSeat> builder)
        {
            builder.ToTable("OrderSeat");

            builder.HasKey(orderSeat => new 
                {orderSeat.SeatId, orderSeat.UserId});

            builder.HasOne(orderSeat => orderSeat.User)
                .WithMany(user => user.OrderSeat)
                    .HasForeignKey(orderSeat => orderSeat.UserId);

            builder.HasOne(orderSeat => orderSeat.Seat)
                .WithMany(seat => seat.OrderSeats)
                    .HasForeignKey(orderSeat => orderSeat.SeatId);
        }
    }
}
