using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TailorMadeTours.Models
{
  public class ToursDbContext : DbContext
  {
    public ToursDbContext(DbContextOptions<ToursDbContext> options)
        : base(options)
    {
      this.TourStops = new TourSource().TourStops;
    }

   // public DbSet<TailorMadeTours.Models.TourStop> TourStops { get; set; }
    public List<TailorMadeTours.Models.TourStop> TourStops { get; set; }


  }
}
