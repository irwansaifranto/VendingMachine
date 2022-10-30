using VendingMachines.Entities;

namespace VendingMachines.Abstract
{
    public interface IProductsRepository : IAsyncRepository<Products>
    {
    }
}
