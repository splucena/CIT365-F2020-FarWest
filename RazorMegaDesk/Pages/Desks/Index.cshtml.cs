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

        public IndexModel(RazorMegaDesk.Data.RazorMegaDeskContext context)
        {
            _context = context;
        }

        public IList<Desk> Desk { get;set; }

        //public async Task OnGetAsync()
        //{
        //    Desk = await _context.Desk
        //        .Include(d => d.ProductionTime)
        //        .Include(d => d.SurfaceMaterial).ToListAsync();
        //}
        public IList<Desk> Desks { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList CustomerName { get; set; }
        [BindProperty(SupportsGet = true)]
        public string DeskCustomerName { get; set; }
        public string CustomerNameSort { get; set; }
        public string DateSort { get; set; }

        public IList<Desk> Desk_ { get; set; }
        public async Task OnGetAsync(string sortOrder)
        {

            IQueryable<string> nameQuery = from m in _context.Desk
                                           orderby m.CustomerName
                                           select m.CustomerName;

            //Scripture = await _context.Scripture.ToListAsync();
            var desk = from m in _context.Desk
                            select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                desk = desk.Where(s => s.CustomerName.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(DeskCustomerName))
            {
                desk = desk.Where(x => x.CustomerName == DeskCustomerName);
            }
            CustomerName = new SelectList(await nameQuery.Distinct().ToListAsync());
            Desk = await desk.AsNoTracking().ToListAsync();

            CustomerNameSort = String.IsNullOrEmpty(sortOrder) ? "Customer" : "";
            DateSort = sortOrder == "Date" ? "InsertDate" : "Date";
            IQueryable<Desk> scripturesIQ = from s in _context.Desk
                                                 select s;
            switch (sortOrder)
            {
                case "Book":
                    scripturesIQ = scripturesIQ.OrderByDescending(s => s.CustomerName);
                    break;
                case "Date":
                    scripturesIQ = scripturesIQ.OrderBy(s => s.DateCreated);
                    break;
                case "InsertDate":
                    scripturesIQ = scripturesIQ.OrderByDescending(s => s.DateCreated);
                    break;
                default:
                    scripturesIQ = scripturesIQ.OrderBy(s => s.DateCreated);
                    break;
            }

            Desk = await scripturesIQ.AsNoTracking().ToListAsync();

        }
    }
}
