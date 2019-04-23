using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExploreRazorPages.Pages
{
	public class HandlerExampleModel : PageModel
	{
		// from an HTTPGet request
		//
		public void OnGet()
		{
			// from an HTTPGet request
		}
		public void OnGetAsync()
		{
			// called async  
		}

		public IActionResult OnPost()
		{
			// from an HTTPPost request

			// can return void or an IActionResult
			return null;
		}
		public IActionResult OnPostAsync()
		{
			return null;
		}
		public IActionResult OnPut()
		{
			// use to update existing information
			return null;
		}
		public void OnDelete()
		{
			// delete
		}

		public void OnPostSignUpForNewletter()
		{
			// when there are multiple ways to post to this page
			// use OnPost prefix and a appropriate name
			// example OnPost------  
		}
	}
}