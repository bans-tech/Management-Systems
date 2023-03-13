using System;
using System.ComponentModel.DataAnnotations;

namespace HotelManagementSystem.Models
{
    public class Room
    {
        [Key]
        public Guid Id { get; set; }
        public string? RoomNumber { get; set; }
        public string? RoomType { get; set; }
        public string? Availability { get; set; }
        public string? Price { get; set; }
    }
}