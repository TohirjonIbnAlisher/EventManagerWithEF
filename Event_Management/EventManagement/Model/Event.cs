namespace EventManagement.Model
{
    public class Event
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public int RoomNumber { get; set; }    
        public  Room Room { get; set; } 
        public int CompanyId { get; set; }
        public Users Company { get; set; } 
    }
}
