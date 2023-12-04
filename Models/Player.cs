using Humanizer;
using System.ComponentModel.DataAnnotations;

namespace BowlThemUp.Models
{
    public enum gender
    {
        Male,
        Female
    }
    public class Player
    {
        [Key]
        public int PlayerID { get; set; }
        public string? PlayerName { get; set; }
        public float ShoeSize { get; set; }
        public int PlayerAge { get; set; }
        public gender Gender { get; set; }
        public virtual ICollection<Booking>? Bookings { get; set; }
    }
}
