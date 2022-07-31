using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendingMachines.Entities
{
    public class Transactions : EntityBase
    {
        [Required]
        public Guid TransactionId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int TrxQuantity { get; set; }

        [Required]
        public decimal SubTotal { get; set; }

        [Required]
        public decimal Total { get; set; }

        [Required]
        public decimal Paid { get; set; }
        
        [Required]
        public decimal Change { get; set; }

        public virtual Products Products { get; set; }
    }
}
