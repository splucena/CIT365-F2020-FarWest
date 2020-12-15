using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
	public class Speaker
	{
		public int SpeakerId { get; set; }
		public int PlannerId { get; set; }

        [Required]
        [Display(Name = "Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z ]*$"), StringLength(80)]
        public string SpeakerName { get; set; }

        [Required]
        [Display(Name = "Topic")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z ]*$"), StringLength(50)]
        public string SpeakerTopic { get; set; }
	}
}
