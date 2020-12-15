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

		[RegularExpression(@"^[A-Z]+[a-zA-Z ]*$")]
		[Display(Name = "Meeting Date")]
		public DateTime MeetingDate { get; set; }

		[RegularExpression(@"^[A-Z]+[a-zA-Z ]*$")]
		[Display(Name = "Conducting")]
		public int BishopricId { get; set; }

		[RegularExpression(@"^[A-Z]+[a-zA-Z ]*$")]
		[Display(Name = "Opening Prayer")]
		public string OpenPrayer { get; set; }

		[RegularExpression(@"^[A-Z]+[a-zA-Z ]*$")]
		[Display(Name = "Closing Prayer")]
		public string ClosePrayer { get; set; }

		public Bishopric Bishopric { get; set; }
		public ICollection<Speaker> Speakers { get; set; }
		public ICollection<Song> Songs { get; set; }
	}
}
