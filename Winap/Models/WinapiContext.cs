using Microsoft.EntityFrameworkCore;

namespace Winap.Models
{
    public class WinapiContext : DbContext
    {
        public WinapiContext(DbContextOptions<WinapiContext> options)
            : base(options)
        {
            
        }
        
        public DbSet<Person> Persons { get; set; }
    }
}