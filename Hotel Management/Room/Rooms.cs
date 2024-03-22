using System.ComponentModel.DataAnnotations;
namespace Hotel_Management.Room
{
    public class Rooms
    {
        public int Id { get; set; }
        [Required]
        public string RoomType { get; set; }
        [Required]
        public string Status { get; set;}
    }
}
