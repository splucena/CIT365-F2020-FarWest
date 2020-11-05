using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorMegaDesk.Data;
using RazorMegaDesk.Models;

namespace RazorMegaDesk.Pages.SurfaceMaterials

{
    public class IndexModel : PageModel
    {
        private readonly RazorMegaDesk.Data.RazorMegaDeskContext _context;

        public IndexModel(RazorMegaDesk.Data.RazorMegaDeskContext context)
        {
            _context = context;
        }

        public IList<SurfaceMaterial> SurfaceMaterial { get;set; }

        public async Task OnGetAsync()
        {
            SurfaceMaterial = await _context.SurfaceMaterial.ToListAsync();
        }
    }
}
