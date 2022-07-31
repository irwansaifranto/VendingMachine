using System.ComponentModel.DataAnnotations;

namespace VendingMachines.Entities
{
    public class Denominations : EntityBase
    {
        [Required]
        public decimal Denomination { get; set; }

        [Required]
        public int DenoQuantity { get; set; }
    }
}
