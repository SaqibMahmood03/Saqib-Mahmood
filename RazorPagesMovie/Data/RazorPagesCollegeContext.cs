using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesCollege.Models;

    public class RazorPagesCollegeContext : DbContext
    {
        public RazorPagesCollegeContext (DbContextOptions<RazorPagesCollegeContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesCollege.Models.College> College { get; set; }
    }
