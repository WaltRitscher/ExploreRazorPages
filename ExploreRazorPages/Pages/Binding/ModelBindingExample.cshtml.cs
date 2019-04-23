using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TailorMadeTours.Models;

namespace ExploreRazorPages.Pages.Binding
{
	public class ModelBindingExampleModel : PageModel
	{
		// 	Model Binding in Razor Pages is the process that takes values from HTTP requests and maps them to handler method parameters or PageModel properties.
		//  By default, only values that form part of a POST request are considered for model binding when you use the BindProperty attribute.
		[BindProperty(SupportsGet =true)]
		public Customer Customer { get; set; }
		
		public void OnGet([Bind] string FirstName, [Bind]bool IsActive)
		{
			// 

			var currentCustomer = Customer;
			
		}
	}
}