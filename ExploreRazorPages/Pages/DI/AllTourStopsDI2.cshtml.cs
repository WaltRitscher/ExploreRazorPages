using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExploreRazorPages.Pages
{
    public class AllTourStopsDI2Model : PageModel
    {
		

		public AllTourStopsDI2Model(TailorMadeTours.Models.ToursDbContext db)
		{
			
		}
		public void OnGet()
		{
			
		}
		
	}
}