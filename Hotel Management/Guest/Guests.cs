using System.ComponentModel.DataAnnotations;

namespace Hotel_Management.Guest
{
    public class Guests
    {
        public int Id{ get; set; }
        [Required]
       public string Name { get; set; }
        [Required]
        public string  Email { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
