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
    public class IndexModel : PageModel
    {
        private readonly ValasztasWebApp.Data.ValasztasDbContext _context;

        public IndexModel(ValasztasWebApp.Data.ValasztasDbContext context)
        {
            _context = context;
        }

        public IList<Jelolt> Jelolt { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Jelolt = await _context.Jeloltek.ToListAsync();
        }
    }
}
