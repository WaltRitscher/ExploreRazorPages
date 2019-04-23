using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TailorMadeTours.Models;


namespace WebApplication1.Controllers
{
	public class TourStopsController : Controller
	{
		public IActionResult Index()
		{
			// this example does not use dependency injection
			var tourStops = new TourSource().TourStops;
			return View(model: tourStops);
		}
	}
}