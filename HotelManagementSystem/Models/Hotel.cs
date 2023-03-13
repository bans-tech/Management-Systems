using System;
using System.ComponentModel.DataAnnotations;

namespace HotelManagementSystem.Models
{
    public class Hotel
    {
        [Key]
        public Guid Id { get; set; }
        public string? HotelName { get; set; }
        public string? Location { get; set; }
        public int? NumberOfRooms { get; set; }
        public string? GpsAddress { get; set; }
        public string? ContactInfo { get; set; }
    }
}