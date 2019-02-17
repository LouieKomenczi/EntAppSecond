using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace EntAppSecond.Pages
{
    public class FormWSModel : PageModel
    {
        public string[] Color = { "Red", "Yellow", "Back" };

        [BindProperty]
        public bool[] ColorSelected { get; set; } = { false, false, false };

        [BindProperty]
        public bool ConsentSelected { get; set; }

        [BindProperty]
        public string ProductCode { get; set; } 

        public void OnPost()
        {
            
        }
    }
}