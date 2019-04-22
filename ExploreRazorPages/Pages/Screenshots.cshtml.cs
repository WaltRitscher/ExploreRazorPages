using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TailorMadeTours.Models;

namespace ExploreRazorPages.Pages
{
    public class ScreenshotsModel : PageModel
    {
        public void OnGet()
        {

        }
        public TourStop CurrentTourStop { get; set; }
    }
}