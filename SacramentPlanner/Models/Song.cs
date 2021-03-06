﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
	public class Song
	{
		public int SongId { get; set; }
		public int PlannerId { get; set; }

		[Display(Name = "Opening Hymn #")]
		public int OpenSongNum { get; set; }

		[Display(Name = "Title")]
		[RegularExpression(@"^[A-Z]+[a-zA-Z ]*$")]
		public string OpenSongTitle { get; set; }

		[Display(Name = "Sacrament Hymn #")]
		public int SacramentSongNum { get; set; }

		[Display(Name = "Title")]
		[RegularExpression(@"^[A-Z]+[a-zA-Z ]*$")]
		public string SacramentSongTitle { get; set; }

		[Display(Name = "Interlude")]
		public int? InterSongNum { get; set; }

		[Display(Name = "Title")]
		[RegularExpression(@"^[A-Z]+[a-zA-Z ]*$")]
		public string InterSongTitle { get; set; }

		[Display(Name = "Closing Hymn #")]
		public int CloseSongNum { get; set; }

		[Display(Name = "Title")]
		[RegularExpression(@"^[A-Z]+[a-zA-Z ]*$")]
		public string CloseSongTitle { get; set; }
	}
}
