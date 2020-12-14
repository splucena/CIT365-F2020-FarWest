﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SacramentPlanner.Models;

namespace SacramentPlanner.Pages.Planners
{
    public class CreateModel : PageModel
    {
        private readonly SacramentPlanner.Models.MeetingContext _context;

        public CreateModel(SacramentPlanner.Models.MeetingContext context)
        {
            _context = context;
        }

		[BindProperty]
		public Planner Planner { get; set; }
		public ICollection<Bishopric> Bishopric { get; set; }

		public IActionResult OnGet()
        {
			Bishopric = _context.Bishopric.Where(b => b.Active == true).ToList();
			return Page();
        }

		//[HttpGet("/Create?action")]
		//public string Action { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

			//_context.Planner.Add(Planner);
			//await _context.SaveChangesAsync();
			var emptyPlanner = new Planner();

			if (await TryUpdateModelAsync<Planner>(
				emptyPlanner,
				"planner",   // Prefix for form value.
				p => p.MeetingDate, p => p.BishopricId, p => p.OpenPrayer, p => p.ClosePrayer))
			{
				_context.Planner.Add(emptyPlanner);
				await _context.SaveChangesAsync();
				//if (Request.Form["addSongs"].Clicked)
				//{
				//	return RedirectToPage("./Details");
				//}
				return RedirectToPage("./Index");
			}
			//if ( == "AddSongs")
			//if (Request.Form["addSongs"] == true)
			//{
			//	return RedirectToPage("./Details");
			//}
			return RedirectToPage("./Index");
        }

        //[HttpGet("/Create?action=")]
        public async Task<IActionResult> OnPostAddSpeakersAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //_context.Planner.Add(Planner);
            //await _context.SaveChangesAsync();
            var emptyPlanner = new Planner();

            if (await TryUpdateModelAsync<Planner>(
                emptyPlanner,
                "planner",   // Prefix for form value.
                p => p.MeetingDate, p => p.BishopricId, p => p.OpenPrayer, p => p.ClosePrayer))
            {
                _context.Planner.Add(emptyPlanner);
                await _context.SaveChangesAsync();

                return RedirectToPage("/Speakers/Create", new { id = emptyPlanner.PlannerId });
            }

            return RedirectToPage("./Index");
        }

        //[HttpGet("/Create?action=")]
        public async Task<IActionResult> OnPostAddSongsAsync()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}

			//_context.Planner.Add(Planner);
			//await _context.SaveChangesAsync();
			var emptyPlanner = new Planner();

			if (await TryUpdateModelAsync<Planner>(
				emptyPlanner,
				"planner",   // Prefix for form value.
				p => p.MeetingDate, p => p.BishopricId, p => p.OpenPrayer, p => p.ClosePrayer))
			{
				_context.Planner.Add(emptyPlanner);
				await _context.SaveChangesAsync();
				
				return RedirectToPage("/Songs/Create", new { id = emptyPlanner.PlannerId });
			}
			
			return RedirectToPage("./Index");
		}
	}
}