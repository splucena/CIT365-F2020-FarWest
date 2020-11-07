using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorMegaDesk.Data;
using RazorMegaDesk.Models;

namespace RazorMegaDesk.Pages.Desks
{
    public class IndexModel : PageModel
    {
        private readonly RazorMegaDesk.Data.RazorMegaDeskContext _context;

        public string DateSort { get; set; }
        public string NameSort { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string DeskCustomerName { get; set; }
        public SelectList CustomerNames { get; set; }

        public IndexModel(RazorMegaDesk.Data.RazorMegaDeskContext context)
        {
            _context = context;
        }

        public IList<Desk> Desk { get;set; }

        public async Task OnGetAsync(string sortOrder)
        {
            Desk = await _context.Desk
                .Include(d => d.ProductionTime)
                .Include(d => d.SurfaceMaterial).ToListAsync();
            var desks = from d in _context.Desk
                             select d;
            // Filter
            IQueryable<string> customerNameQuery = from d in _context.Desk
                                                   orderby d.CustomerName
                                                   select d.CustomerName;

            if (!string.IsNullOrEmpty(DeskCustomerName))
            {
                desks = desks.Where(s => s.CustomerName == DeskCustomerName);
            }

            // Search
            if (!string.IsNullOrEmpty(SearchString))
            {
                desks = desks.Where(s => s.CustomerName.Contains(SearchString));
            }
            CustomerNames = new SelectList(await customerNameQuery.Distinct().ToListAsync());

            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";
            switch (sortOrder)
            {
                case "name_desc":
                    desks = desks.OrderByDescending(s => s.CustomerName);
                    break;
                case "Date":
                    desks = desks.OrderBy(s => s.DateCreated);
                    break;
                case "date_desc":
                    desks = desks.OrderByDescending(s => s.DateCreated);
                    break;
                default:
                    desks = desks.OrderBy(s => s.CustomerName);
                    break;
            }

            Desk = await desks.ToListAsync();
        }
    }
}
