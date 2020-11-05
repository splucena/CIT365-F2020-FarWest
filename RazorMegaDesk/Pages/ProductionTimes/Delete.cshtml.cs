using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorMegaDesk.Data;
using RazorMegaDesk.Models;

namespace RazorMegaDesk.Pages.ProductionTimes
{
    public class DeleteModel : PageModel
    {
        private readonly RazorMegaDesk.Data.RazorMegaDeskContext _context;

        public DeleteModel(RazorMegaDesk.Data.RazorMegaDeskContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ProductionTime ProductionTime { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProductionTime = await _context.ProductionTime.FirstOrDefaultAsync(m => m.ProductionTimeID == id);

            if (ProductionTime == null)
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

            ProductionTime = await _context.ProductionTime.FindAsync(id);

            if (ProductionTime != null)
            {
                _context.ProductionTime.Remove(ProductionTime);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
