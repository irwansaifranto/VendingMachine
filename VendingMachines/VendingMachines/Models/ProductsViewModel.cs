using System.ComponentModel.DataAnnotations;

namespace VendingMachines.Models
{
    public class ProductsViewModel
    {
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Products")]
        public string ProductName { get; set; }

        [Required]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        public int ProdQuantity { get; set; }

        public string PriceString { get; set; }
    }
}
