using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BowlThemUp.Models;

namespace BowlThemUp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BowlThemUp.Models.Alley>? Alley { get; set; }
        public DbSet<BowlThemUp.Models.Booking>? Booking { get; set; }
        public DbSet<BowlThemUp.Models.Player>? Player { get; set; }
        public DbSet<BowlThemUp.Models.Customer>? Customer { get; set; }
    }
}