using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesCollege.Models;

namespace RazorPagesCollege.Pages_Colleges
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesCollegeContext _context;

        public CreateModel(RazorPagesCollegeContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public College College { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.College.Add(College);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
