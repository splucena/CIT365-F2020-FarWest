﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentPlanner.Models;

namespace SacramentPlanner.Pages.Speakers
{
    public class IndexModel : PageModel
    {
        private readonly SacramentPlanner.Models.MeetingContext _context;

        public IndexModel(SacramentPlanner.Models.MeetingContext context)
        {
            _context = context;
        }

        public IList<Speaker> Speaker { get;set; }

        public async Task OnGetAsync()
        {
            Speaker = await _context.Speakers.ToListAsync();
        }
    }
}
