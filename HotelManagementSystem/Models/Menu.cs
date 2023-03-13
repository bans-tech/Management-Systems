using System;

namespace HotelManagementSystem.Models
{
    public class Menu
    {
        public Guid Id { get; set; }
        public string? MenuItem { get; set; }
        public string? Description { get; set; }
        public string? Price { get; set; }
        public string? TimeServe { get; set; }
        
    }
}