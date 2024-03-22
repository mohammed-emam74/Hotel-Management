using System.ComponentModel.DataAnnotations;
namespace Hotel_Management.Booking
{
    public class Bookings
    {
        public int Id { get; set; }
        [Required]
        public string RoomType { get; set; }
        [Required]
        public string GuestName { get; set; }
        [Required]
        public DateTime CheckIn { get; set; }
        [Required]
        public DateTime CheckOut { get; set; }

    }
}
