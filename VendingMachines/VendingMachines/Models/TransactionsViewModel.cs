using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace VendingMachines.Models
{
    public class TransactionsViewModel
    {
        public List<ProductsViewModel> ProductsVwModel { get; set; }
        
        public decimal Denomination { get; set; }

        public List<SelectListItem> DenominationListItem { get; set; }
    }
}
