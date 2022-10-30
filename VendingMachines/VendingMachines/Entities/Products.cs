using System.ComponentModel.DataAnnotations;

namespace VendingMachines.Entities
{
    public class Products : EntityBase
    {
        public Products()
        {
            TransactionItems = new HashSet<TransactionItems>();
        }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int ProdQuantity { get; set; }

        public virtual ICollection<TransactionItems> TransactionItems { get; set; }
    }
}
