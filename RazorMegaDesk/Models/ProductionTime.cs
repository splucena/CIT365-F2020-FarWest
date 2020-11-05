using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorMegaDesk.Models
{
    public class ProductionTime
    {
        [Key]
        public int ProductionTimeID { get; set; }

        [Required]
        [Range(1, 14)]
        public int Days { get; set; }

        public string Description { get; set; }
    }
}
