using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorMegaDesk.Models
{
    public class SurfaceMaterial
    {
        [Key]
        public int SurfaceMaterialID { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "A Material Description is required")]
        public string Material { get; set; }

        public IList<Desk> Desks { get; set; }
    }
}
