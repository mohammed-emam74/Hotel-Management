using Hotel_Management.Booking;
using Hotel_Management.Guest;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Management.Payment
{
    public class PaymentsDbContext:DbContext
    {
        public PaymentsDbContext(DbContextOptions<PaymentsDbContext> Lists)
        : base(Lists)
        {

        }

        public DbSet<Payments> Payments { get; set; }
    }
}
