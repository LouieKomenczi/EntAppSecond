using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EntAppSecond.Models;
using System.Globalization;

namespace EntAppSecond.Pages
{
    public class ConfirmModel : PageModel
    {
        public string StudentID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public void OnGet()
        {

            //StudentID = HttpContext.Session.GetString("StudentID");
            //FirstName = HttpContext.Session.GetString("FirstName");
            //LastName = HttpContext.Session.GetString("LastName");
            //Email = HttpContext.Session.GetString("Email");
        }
    }
}