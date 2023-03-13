using System;

namespace HotelManagementSystem.Models
{
    public class ServiceType
    
    {
        public Guid Id { get; set; }
        public bool Accommodation { get; set; }
        public bool Restaurant { get; set; }
        public bool Conference { get; set; }
        public bool Laundry { get; set; }
        public bool Outdoor { get; set; }
    }
}