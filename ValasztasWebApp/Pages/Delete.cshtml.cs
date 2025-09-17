using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ValasztasWebApp.Data;
using ValasztasWebApp.Models;

namespace ValasztasWebApp.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly ValasztasWebApp.Data.ValasztasDbContext _context;

        public DeleteModel(ValasztasWebApp.Data.ValasztasDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Jelolt Jelolt { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jelolt = await _context.Jeloltek.FirstOrDefaultAsync(m => m.Id == id);

            if (jelolt == null)
            {
                return NotFound();
            }
            else
            {
                Jelolt = jelolt;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jelolt = await _context.Jeloltek.FindAsync(id);
            if (jelolt != null)
            {
                Jelolt = jelolt;
                _context.Jeloltek.Remove(Jelolt);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
