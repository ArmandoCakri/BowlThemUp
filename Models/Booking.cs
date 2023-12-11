using System;
using System.ComponentModel.DataAnnotations;

namespace BowlThemUp.Models
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }
        public int CustomerID { get; set; }
        public virtual Customer? Customer { get; set; }
        public int AlleyID { get; set; }
        public virtual Alley? Alley { get; set; }
        public int PlayerID { get; set; }
        public virtual Player? Player { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        private float _price;

        public float Price
        {
            get
            {
                _price = CalculateTotalCost();
                return _price;
            }
            set => _price = value;
        }

        public float CalculateTotalCost() //Function that calculates the total cost of the booking.
        {
            TimeSpan duration = EndDate - StartDate;
            float costPerHour = 20;
            float totalCost = (float)duration.TotalHours * costPerHour;
            totalCost = (float)Math.Round(totalCost,2);
            return totalCost;
        }
    }
}
