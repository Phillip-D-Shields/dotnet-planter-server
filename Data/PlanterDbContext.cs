using Microsoft.EntityFrameworkCore;
using Planter.Models;

namespace Planter.Data
{
  public class PlanterDbContext : DbContext
  {
    public PlanterDbContext(DbContextOptions<PlanterDbContext> options) : base(options)
    {
    }

    public DbSet<User>? Users { get; set; }
    public DbSet<Plant>? Plants { get; set; }
    public DbSet<PlantingCalendar>? PlantingCalendars { get; set; }

    // other DbSet properties for domain models here ...
  }
}