namespace EventManagement.Model
{
    public class Seat
    {
        public int SeatNumber { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }

        public ICollection<OrderSeat> OrderSeats { get; set; }
    }
}
