using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TailorMadeTours.Models;

namespace ExploreRazorPages.Pages
{
	public class EditTourStopModel : PageModel
	{
		public void OnGet(int stopNumber)
		{
			// CurrentTourStop = new TailorMadeTours.Models.TourSource().TourStops.ElementAt(stopNumber - 1);
			CurrentTourStop = new TailorMadeTours.Models.TourSource().TourStops.FirstOrDefault(x => x.StopNumber == stopNumber);
		}


		public IActionResult OnPost()
		{
			if (!ModelState.IsValid)
			{
				return Page();

			}
			#region TempData
			// how do we pass data (message) back to the orginal page?
			// use a property on the page model
			Message = $"Tour Stop: '{CurrentTourStop.Name}' was updated!";
			#endregion

			// Response.Redirect("./Index");
			return RedirectToPage("DatabindWithRouteParam", new { CurrentTourStop.StopNumber });
			// similar to RedirectToAction and RedirectToRoute
		}

		// use TempData property to pass data between pages
		// Properties marked with TempData attribute
		// are stored in encrypted cookie
		// When the data is read from the cookie, it is deleted.
		[TempData]
		public string Message { get; set; }


		[BindProperty]
		public TourStop CurrentTourStop { get; set; }
	}
}