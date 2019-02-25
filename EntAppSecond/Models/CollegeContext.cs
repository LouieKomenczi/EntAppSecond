﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntAppSecond.Models
{
    public class CollegeContext:DbContext
    {
        public CollegeContext(DbContextOptions<CollegeContext> options)
            :base(options)
        { }

        public DbSet<Student> Student { get; set; }
    }
}
