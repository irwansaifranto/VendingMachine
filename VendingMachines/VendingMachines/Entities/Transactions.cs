using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendingMachines.Entities
{
    public class Transactions : EntityBase
    {
        public Transactions()
        {
            TransactionItems = new HashSet<TransactionItems>();
        }

        [Required]
        public Guid TransactionId { get; set; }

        [Required]
        public decimal Total { get; set; }

        [Required]
        public decimal Paid { get; set; }
        
        [Required]
        public decimal Change { get; set; }

        public virtual ICollection<TransactionItems> TransactionItems { get; set; }
    }
}
