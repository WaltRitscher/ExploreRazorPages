using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExploreRazorPages.Pages.DI
{
	public class AllTestimonialsModel : PageModel
	{
		private TailorMadeTours.Models.ITestimonials _service;
		public AllTestimonialsModel(TailorMadeTours.Models.ITestimonials service)
		{
			_service = service;
		}
		public void OnGet()
		{
			Testimonials = _service.GetTestimonials();
		}

		public List<TailorMadeTours.Models.Testimonial> Testimonials { get; set; }
	}
}