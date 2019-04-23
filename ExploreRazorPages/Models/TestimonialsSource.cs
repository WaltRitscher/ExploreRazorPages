using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TailorMadeTours.Models
{
	public class TestimonialsSource : ITestimonials
	{
		private List<Testimonial> _testimonials;
		public TestimonialsSource()
		{
			_testimonials = new List<Testimonial>();
			var t = new Testimonial { ID = 1, Customer = "Randall J." };
			t.Comment = "I had a fabulous time and saw amazing scenery and sights. Both tours were great, loved that we did not have to get up early every morning to be on a bus somewhere else. Our tour leaders were fun, full of knowledge and helpful. The cruise and the ship were both enjoyable, we had a lovely cabin with a balcony.";
			_testimonials.Add(t);


			 t = new Testimonial { ID = 2, Customer = "Janet S." };
			t.Comment = "Wow, we had a great time! What a comprehensive tour - we loved it and could never have found all those fabulous places without you.";
			_testimonials.Add(t);

			t = new Testimonial { ID = 3, Customer = "Dan B." };
			t.Comment = "Our trip was just magical, and I would highly recommend Tailor-made Tours to anyone considering an eco-tour. I don’t know how it could have been better, and I can’t wait to book another trip. Thanks so much for all your help.";
			_testimonials.Add(t);

		}
		public List<Testimonial> GetTestimonials()
		{
			return _testimonials;
		}
	}
}
