using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TailorMadeTours.Models;

namespace ExploreRazorPages.Pages
{
  public class AllTourStopsModel : PageModel
  {
    public AllTourStopsModel()
    {
      this.TourStops = new TourSource().TourStops;
    }
    public void OnGet()
    {

    }

    public List<TourStop> TourStops { get; set; }
  }
}