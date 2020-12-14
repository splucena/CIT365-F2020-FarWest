﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentPlanner.Models;

namespace SacramentPlanner.Pages.Planners
{
    public class IndexModel : PageModel
    {
        private readonly SacramentPlanner.Models.MeetingContext _context;

        public IndexModel(SacramentPlanner.Models.MeetingContext context)
        {
            _context = context;
        }

        public IList<Planner> Planner { get;set; }
		//public Song Songs { get; set; }
		//public Planner Planners { get; set; }
		//public Bishopric Bishopric { get; set; }

		public async Task OnGetAsync()
        {
            Planner = await _context.Planner.Include(b => b.Bishopric).Include(s => s.Songs).ToListAsync();
			//foreach (var conducting in Planner)
			//{
			//	Bishopric = await _context.Bishopric.FirstOrDefaultAsync(m => m.BishopricId == conducting.Bishopric);
			//}
		}
    }
}
