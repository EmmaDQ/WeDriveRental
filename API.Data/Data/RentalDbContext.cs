using Microsoft.EntityFrameworkCore;
using Shared;

namespace Database
{
    public class RentalDbContext : DbContext
    {
        public RentalDbContext(DbContextOptions<RentalDbContext> options) : base(options)
        {

        }

        public DbSet<CarModel> Cars { get; set; }
        public DbSet<BookingModel> Bookings { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    // Eller om du vill behålla IdentityUserLogin men behandla det som en keyless entity
        //    modelBuilder.Ignore<IdentityUserLogin<string>>();
        //    modelBuilder.Ignore<IdentityUserRole<string>>();
        //    //modelBuilder.Entity<IdentityUserRole<string>>().HasNoKey();
        //}

    }
}
