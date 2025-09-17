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
    public class JelölekKeruletenkentModel : PageModel
    {
        private readonly ValasztasWebApp.Data.ValasztasDbContext _context;

        public JelölekKeruletenkentModel(ValasztasWebApp.Data.ValasztasDbContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public int KijeloltKerulet { get; set; }

        public IList<int>  Keruletek { get; set; }

        public IList<Jelolt> Jelolt { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Keruletek = _context.Jeloltek.Select(x => x.Kerulet).OrderBy(x => x).ToList();

            if (KijeloltKerulet == 0)
                Jelolt = await _context.Jeloltek.ToListAsync();
            else
                Jelolt = _context.Jeloltek.Where(x => x.Kerulet == KijeloltKerulet).ToList();
        }
    }
}
