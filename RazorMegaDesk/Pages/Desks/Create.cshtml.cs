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

        public decimal getDeskCost(Desk desk)
        {
            decimal cost = 0;
            decimal basePrice = 200;
            cost += basePrice;
            decimal surfaceArea = desk.Width * desk.Height;
            if (surfaceArea > 1000)
            {
                cost += surfaceArea - 1000;
            }
            decimal drawersCost = desk.NumberOfDrawer * 50;
            cost += drawersCost;
            cost += desk.SurfaceMaterial.Cost;
            if (desk.ProductionTime.Days < 14)
            {
                switch (desk.ProductionTime.Days)
                {
                    case 3:
                        if (surfaceArea < 1000)
                        {
                            cost += 60;
                        }
                        if (surfaceArea < 2000)
                        {
                            cost += 70;
                        }
                        if (surfaceArea > 2000)
                        {
                            cost += 80;
                        }
                        break;
                    case 5:
                        if (surfaceArea < 1000)
                        {
                            cost += 40;
                        }
                        if (surfaceArea < 2000)
                        {
                            cost += 50;
                        }
                        if (surfaceArea > 2000)
                        {
                            cost += 60;
                        }
                        break;
                    case 7:
                        if (surfaceArea < 1000)
                        {
                            cost += 30;
                        }
                        if (surfaceArea < 2000)
                        {
                            cost += 35;
                        }
                        if (surfaceArea > 2000)
                        {
                            cost += 40;
                        }
                        break;
                    default:
                        break;
                }
            }
            return cost;
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Desk.SurfaceMaterial = _context.SurfaceMaterial.Find(Desk.SurfaceMaterialID);
            Desk.ProductionTime = _context.ProductionTime.Find(Desk.ProductionTimeID);

            Desk.Amount = getDeskCost(Desk);

            _context.Desk.Add(Desk);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
