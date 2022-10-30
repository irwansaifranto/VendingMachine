using System.ComponentModel.DataAnnotations;

namespace VendingMachines.Models
{
    public class DenominationsViewModel
    {
        [Required]
        [Display(Name = "Denomination")]
        public decimal Denomination { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        public int DenoQuantity { get; set; }
    }
}
