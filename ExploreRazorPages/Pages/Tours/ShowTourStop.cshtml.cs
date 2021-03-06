﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TailorMadeTours.Models;

namespace ExploreRazorPages.Pages
{
	public class ShowTourStopModel : PageModel
	{
		public void OnGet(int stopNumber)
		{
			CurrentTourStop = new TailorMadeTours.Models.TourSource().TourStops.FirstOrDefault(x => x.StopNumber== stopNumber);
		}

		// use TempData property to pass data between pages
		// Properties marked with TempData attribute
		// are stored in encrypted cookie
		// When the data is read from the cookie, it is deleted.
		[TempData]
		public string Message { get; set; }


		public bool ShouldShowMessage => !String.IsNullOrEmpty(Message);
		[BindProperty]
		public TourStop CurrentTourStop { get; set; }
	}
}