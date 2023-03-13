using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagementSystem.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string? MenuItemOrdered { get; set; }
        [ForeignKey("RoomNumber")] 
        public Room? Room { get; set; }
        public string? RoomNumber { get; set; }
        public string? SpecialRequest { get; set; }
    }
}