using Microsoft.EntityFrameworkCore;
using SchoolManagement_EventService.Models.EventModels;

namespace SchoolManagement_EventService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Event> Events { get; set; }
    }
}
