using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EntAppSecond.Models;

namespace EntAppSecond.Pages
{
    public class StudentDetailsModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string StudentID { get; set; }

        public void OnGet()
        {

        }
    }
}