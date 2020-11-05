using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RazorMegaDesk.Models
{   
    
    public class Desk
    {
        private decimal _width = 12M;

        [Key]
        public int DeskID { get; set; }

        [Display(Name = "Customer Name")]
        [Required]
        [StringLength(255)]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Width must be between 24 and 96")]
        [DefaultValue(24)]
        [Range(24, 96)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Width { get { return _width; } set { _width = value; } }

        [Required(ErrorMessage = "Height must be between 12 and 48")]
        [DefaultValue(12)]
        [Range(12, 48)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Height { get; set; }
        
        [Display(Name = "Surface Material")]
        public int SurfaceMaterialID { get; set; }

        [Display(Name = "Surface Material")]
        public SurfaceMaterial SurfaceMaterial { get; set; }

        [Display(Name = "Number of Drawer")]
        [Range(0, 7)]
        [DefaultValue(0)]
        public int NumberOfDrawer { get; set; }

        [Display(Name = "Production Time")]
        public int ProductionTimeID { get; set; }

        [Display(Name = "Prodution Time")]
        public ProductionTime ProductionTime { get; set; }

        [Display(Name = "Date Created")]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [DefaultValue(0.0)]
        public decimal Amount { get; set; }

    }
}
