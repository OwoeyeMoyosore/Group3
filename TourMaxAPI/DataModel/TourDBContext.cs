using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TourMaxAPI.ViewModel;

namespace TourMaxAPI.DataModel
{
    public class TourDBContext: IdentityDbContext<TourUser, IdentityRole, string>
    {
        public DbSet<Tour> Tours { get; set; }
        public DbSet<TourImage> tourImages { get; set; }
        public DbSet<Booking> bookings { get; set; }
        public DbSet<Hotel> hotels { get; set; }
        public DbSet<Payment> payments { get; set; }
        public DbSet<TourCategory> tourCategories { get; set; }

        public TourDBContext(DbContextOptions<TourDBContext> options): base(options)
        {

        }
    }
}
 