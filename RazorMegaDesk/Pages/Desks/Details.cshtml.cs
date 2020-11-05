using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorMegaDesk.Data;
using RazorMegaDesk.Models;

namespace RazorMegaDesk.Pages.Desks
{
    public class DetailsModel : PageModel
    {
        private readonly RazorMegaDesk.Data.RazorMegaDeskContext _context;

        public DetailsModel(RazorMegaDesk.Data.RazorMegaDeskContext context)
        {
            _context = context;
        }

        public Desk Desk { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Desk = await _context.Desk
                .Include(d => d.ProductionTime)
                .Include(d => d.SurfaceMaterial).FirstOrDefaultAsync(m => m.DeskID == id);

            if (Desk == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
