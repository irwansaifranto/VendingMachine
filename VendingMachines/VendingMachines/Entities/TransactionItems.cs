using System.ComponentModel.DataAnnotations;

namespace VendingMachines.Entities
{
    public class TransactionItems
    {
        [Required]
        public Guid TransactionItemId { get; set; }

        [Required]
        public Guid TransactionId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int TrxQuantity { get; set; }

        [Required]
        public decimal SubTotal { get; set; }

        public virtual Transactions Transactions { get; set; }

        public virtual Products Products { get; set; }
    }
}
