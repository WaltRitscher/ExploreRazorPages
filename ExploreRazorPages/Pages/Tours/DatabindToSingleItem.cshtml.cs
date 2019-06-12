using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TailorMadeTours.Models;

namespace ExploreRazorPages.Pages
{
    public class DatabindToSingleItemModel : PageModel
    {
        // private ApiContext _db; 
        public DatabindToSingleItemModel()
        {
            // ApiContext db
            // _db= db;
            // use this to setup dependency injection
        }
        public void OnGet()
        {
            //CurrentTourStop = new TailorMadeTours.Models.TourSource().TourStops.ElementAt(3);
            CurrentTourStop = new TailorMadeTours.Models.TourSource().TourStops.FirstOrDefault(x=>x.StopNumber== 3);
        }
        
        
        public TourStop CurrentTourStop { get; set; }
    }
}