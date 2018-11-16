using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class TestModel : PageModel
    {
        public void OnGet()
        {
			
        }

		[BindProperty(SupportsGet = true)]
		public InputModel Input { get; set; }

		public class InputModel
		{

			[BindProperty(Name = "text")]
			public string Text { get; set; }

			[BindProperty(Name = "check")]
			public bool CheckBox { get; set; }

		}

    }
}