using Microsoft.EntityFrameworkCore;
using Hotel_Management.Payment;

namespace Hotel_Management.Booking
{
    public class PaymentssDbContext :DbContext
    {
        public PaymentssDbContext(DbContextOptions<PaymentssDbContext> actions)
        : base(actions)
        {

        }

        public DbSet<Bookings> Booking { get; set; }
        public DbSet<Hotel_Management.Payment.Payments> Payments { get; set; } = default!;
    }
}
