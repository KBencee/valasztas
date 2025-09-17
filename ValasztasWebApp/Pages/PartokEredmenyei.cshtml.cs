using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ValasztasWebApp.Data;

namespace ValasztasWebApp.Pages
{
    public class PartokEredmenyeiModel : PageModel
    {
        private readonly ValasztasDbContext _context;

        public PartokEredmenyeiModel(ValasztasDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }
    }
}
