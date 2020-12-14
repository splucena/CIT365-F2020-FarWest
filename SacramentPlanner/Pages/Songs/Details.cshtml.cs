﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentPlanner.Models;

namespace SacramentPlanner.Pages.Songs
{
    public class DetailsModel : PageModel
    {
        private readonly SacramentPlanner.Models.MeetingContext _context;

        public DetailsModel(SacramentPlanner.Models.MeetingContext context)
        {
            _context = context;
        }

        public Song Song { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Song = await _context.Songs.FirstOrDefaultAsync(m => m.SongId == id);

            if (Song == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
