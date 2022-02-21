using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesCollege.Models;

namespace RazorPagesMovie.Pages_Colleges
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesCollegeContext _context;

        public DeleteModel(RazorPagesCollegeContext context)
        {
            _context = context;
        }

        [BindProperty]
        public College College { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            College = await _context.College.FirstOrDefaultAsync(m => m.ID == id);

            if (College == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            College = await _context.College.FindAsync(id);

            if (College != null)
            {
                _context.College.Remove(College);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
