using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
	public class Planner
	{
		public int PlannerId { get; set; }

		[Display(Name = "Meeting Date")]
		public DateTime MeetingDate { get; set; }

		[Display(Name = "Conducting")]
		public int BishopricId { get; set; }

		[Display(Name = "Opening Prayer")]
		public string OpenPrayer { get; set; }

		[Display(Name = "Closing Prayer")]
		public string ClosePrayer { get; set; }

		public Bishopric Bishopric { get; set; }
		public ICollection<Speaker> Speakers { get; set; }
		public ICollection<Song> Songs { get; set; }
	}
}
