using System.ComponentModel.DataAnnotations;

namespace BowlThemUp.Models
{
    public class Alley
    {
        [Key]
        public int AlleyID { get; set; }
        public string? LaneType { get; set; }
        public string? LaneCondition { get; set; }
        public string? LaneLength { get; set; }
        public virtual ICollection<Booking>? Bookings { get; set; }  
    }
}
