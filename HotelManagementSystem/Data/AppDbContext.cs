using HotelManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagementSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(AppDbContextOptions<AppDbContext> options) : base(options) 
        {}
        
        public DbSet<Book> Books { get; set; }
    }
}