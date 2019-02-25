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
    public class CreateModel : PageModel
    {
        private readonly CollegeContext _db;

        public CreateModel(CollegeContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Student Student { get; set; } = new Student();

        public void OnGet()
        {
            //Student.StudentID = HttpContext.Session.GetString("StudentID");
            //Student.FirstName = HttpContext.Session.GetString("FirstName");
            //Student.LastName = HttpContext.Session.GetString("LastName");
            //Student.Email = HttpContext.Session.GetString("Email");

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (Student.Email != Student.EmailConfirm)
                ModelState.AddModelError("Student.Email", "emails don't match");

            if (ModelState.IsValid)
            {
                _db.Student.Add(Student);
                await _db.SaveChangesAsync();
                return RedirectToPage("/ListStudents");
            }
            else
            {
                return Page();
            }


        }

        

     
    }
}