using VendingMachines.Abstract;
using VendingMachines.Entities;

namespace VendingMachines.Concrete
{
    public class ProductsRepository : EFRepository<Products>, IProductsRepository
    {
        public ProductsRepository(VendingMachinesDbContext context) : base(context)
        {
        }
    }
}
