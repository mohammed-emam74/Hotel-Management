using Microsoft.EntityFrameworkCore;

namespace Hotel_Management.Room
{
    public class RoomsDbContext : DbContext
    {
        public RoomsDbContext(DbContextOptions<RoomsDbContext> choices)
       : base(choices)
        {

        }

        public DbSet<Rooms> Room { get; set; }
    }
}
