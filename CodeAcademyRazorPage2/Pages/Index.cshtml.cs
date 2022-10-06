// Index.cshtml.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademyRazorPage2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CodeAcademyRazorPage2.Pages
{
	public class IndexModel : PageModel
	{
		public string FullName { get; set; }
		public string LinkedInUserName { get; set; }
		public int YearsOfExperience { get; set; }
		public List<String> Languages { get; set; }
        public Link Link_Url{ get; set; }
        public void OnGet()
		{
			FullName = "Tufan Keser";
			LinkedInUserName = "TufanKeser";
			Languages = new List<string>
			{
				"C#",
				"Scala",
				"Python"
			};
		}

	}



}
