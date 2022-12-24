namespace EventManagement.Model
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }   

        public ICollection<Seat> Seats { get;set; }

        public ICollection<Event> Events { get; set; }
    }
}
