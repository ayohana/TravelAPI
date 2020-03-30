using Microsoft.EntityFrameworkCore;

namespace TravelAPI.Models
{
  public class TravelAPIContext : DbContext
  {
    public TravelAPIContext(DbContextOptions<TravelAPIContext> options)
        : base(options)
    {
    }

    public DbSet<Review> Reviews { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Review>()
          .HasData(
              new Review { ReviewId = 1, Destination = "Hawaii", Title = "Coconuts Yes!", Description = "Always ask for them.", Rating = 3 },
              new Review { ReviewId = 2, Destination = "Seattle", Title = "The Emerald City", Description = "Mhm", Rating = 3 },
              new Review { ReviewId = 3, Destination = "Denver", Title = "Hiking Paradise", Description = "Bring your hiking shoes with you!", Rating = 3 },
              new Review { ReviewId = 4, Destination = "New York", Title = "Walk, walk, walk", Description = "So little time, so much distance to travel", Rating = 6 },
              new Review { ReviewId = 5, Destination = "Chicago", Title = "Good 'ol Chicago", Description = "Dunkin donuts all around!", Rating = 5 }
          );
    }
  }
}