using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorMegaDesk.Data;
using RazorMegaDesk.Models;

namespace RazorMegaDesk.Pages.Desks
{
    public class CreateModel : PageModel
    {
        private readonly RazorMegaDesk.Data.RazorMegaDeskContext _context;

        public CreateModel(RazorMegaDesk.Data.RazorMegaDeskContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ProductionTimeID"] = new SelectList(_context.ProductionTime, "ProductionTimeID", "Days");
        ViewData["SurfaceMaterialID"] = new SelectList(_context.SurfaceMaterial, "SurfaceMaterialID", "Material");
            return Page();
        }

        [BindProperty]
        public Desk Desk { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Desk.Add(Desk);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
