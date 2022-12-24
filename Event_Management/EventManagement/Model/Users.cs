using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Model
{
    public class Users
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string TellNumber { get; set; }    
        
        public Role Role { get; set; }
        public ICollection<Event> Events { get; set; }

        public ICollection<OrderSeat> OrderSeat { get; set; }
    }
}
