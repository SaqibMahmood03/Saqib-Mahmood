using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesCollege.Models;


namespace RazorPagesCollege.Pages_Colleges
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesCollegeContext _context;

        public IndexModel(RazorPagesCollegeContext context)
        {
            _context = context;
        }

        public IList<College> College { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList CountryList { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Country { get; set; }
       public async Task OnGetAsync()
{IQueryable<string> CountryQuery = from c in _context.College
                                              orderby c.Country
                                              select c.Country;
            var colleges = from c in _context.College
                       select c; // SELECT * from College

            if (!string.IsNullOrEmpty(SearchString))
            {
                // where clause from sql, where c.CarModel = SearchString
                colleges = colleges.Where(c => c.CollegeName.ToLower().Contains(SearchString.ToLower()));
            }

            if (!string.IsNullOrEmpty(Country))
            {
                colleges = colleges.Where(c => c.Country == Country);
            }
            CountryList = new SelectList(await CountryQuery.Distinct().ToListAsync());

            College = await colleges.ToListAsync();
}
    }
}
