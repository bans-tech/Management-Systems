using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagementSystem.Models
{
    public class Guest
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Contact { get; set; }
        public bool SpecialService { get; set; }
        [ForeignKey("ServiceTypeId")]
        public ServiceType? ServiceType { get; set; }
        public Guid ServiceTypeId { get; set; }
        [ForeignKey("RoomNumber")] 
        public Room? Room { get; set; }
        public string? RoomNumber { get; set; }
        public string? SpecialRequest { get; set; }
    }
}