using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentPlanner.Models;


namespace SacramentPlanner.Pages.Planners
{
    public class DetailsModel : PageModel
    {
        private readonly MeetingContext _context;

        public DetailsModel(MeetingContext context)
        {
            _context = context;
        }

        public Planner Planner { get; set; }
		public Bishopric Bishopric { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

			Planner = await _context.Planner
						.Include(s => s.Speakers)
						.Include(s => s.Songs)
						.AsNoTracking()
						.FirstOrDefaultAsync(m => m.PlannerId == id);

			Bishopric = await _context.Bishopric.FirstOrDefaultAsync(m => m.BishopricId == Planner.BishopricId);

			if (Planner == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
