using System.ComponentModel.DataAnnotations;

namespace BowlThemUp.Models
{
    public class Support
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Query {  get; set; }
    }
}
