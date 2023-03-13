using System;

namespace HotelManagementSystem.Models
{
    public class Staff
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Position { get; set; }
        public string? HomeAddress { get; set; }
        public string? ContactInfo { get; set; }
        public bool OnShift { get; set; }
    }
}