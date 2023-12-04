using System.ComponentModel.DataAnnotations;

namespace BowlThemUp.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MobileNumber { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public int PlayerAmount { get; set; }
        public virtual ICollection<Booking>? Bookings { get; set; }
    }
}
