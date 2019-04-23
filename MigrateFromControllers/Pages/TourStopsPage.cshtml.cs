using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TailorMadeTours.Models;

namespace MigrateFromControllers.Pages
{
	public class TourStopsPageModel : PageModel
	{
		public List<TourStop> TourStops { get; set; }
		public TourStopsPageModel()
		{
			this.TourStops = new TourSource().TourStops;
		}
		// handler methods here...
		public void OnGet()		{		}
	}
}