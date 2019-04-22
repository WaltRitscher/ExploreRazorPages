﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExploreRazorPages.Pages
{
  public class AllTourStopsDIModel : PageModel
  {
    private TailorMadeTours.Models.ApiContext _db;

    public AllTourStopsDIModel(TailorMadeTours.Models.ApiContext db)
    {
      _db = db;
    }
    public void OnGet()
    {
      TourStops = _db.TourStops;
    }
    public List<TailorMadeTours.Models.TourStop> TourStops { get; set; }
  }
}