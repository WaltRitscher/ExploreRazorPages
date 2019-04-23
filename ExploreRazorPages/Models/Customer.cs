using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TailorMadeTours.Models
{
	public class Customer
	{
		[Required]
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		[EmailAddress]
		public String Email { get; set; }
		[Phone]
		public string MobilePhone { get; set; }
		public bool IsActive { get; set; }
		[MinLength(12)]
		public string Notes { get; set; }
		
		public String	 AdminNotes { get; set; }
	}
}
