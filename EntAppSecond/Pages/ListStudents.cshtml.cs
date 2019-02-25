using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EntAppSecond.Models;

namespace EntAppSecond.Pages
{
    public class ListStudentsModel : PageModel
    {
   

        private readonly CollegeContext _db;

        public ListStudentsModel(CollegeContext db)
        {
            _db = db;
        }

        public IList<Student> Students { get; private set; }


        public async Task OnGetAsync()
        {
            Students = await _db.Student.AsNoTracking().ToListAsync();
        }
    }
}