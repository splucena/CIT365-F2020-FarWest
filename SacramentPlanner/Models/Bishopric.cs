using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
	public class Bishopric
	{


		public int BishopricId { get; set; }
		public Boolean Active { get; set; }

		[Display(Name = "Name")]
		public string BishopricName { get; set; }

		public ICollection<Planner> Planners { get; set; }
	}
}
