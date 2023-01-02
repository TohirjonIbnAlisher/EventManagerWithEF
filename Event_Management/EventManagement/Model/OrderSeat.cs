namespace EventManagement.Model
{
    public  class OrderSeat
    {
        public int UserId { get; set; }
        public Users User { get; set; } 
        public int SeatId { get; set; }
        public Seat Seat { get; set; }
    }
}
