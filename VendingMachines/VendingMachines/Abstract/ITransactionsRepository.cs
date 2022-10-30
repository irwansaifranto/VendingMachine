using VendingMachines.Entities;
namespace VendingMachines.Abstract
{
    public interface ITransactionsRepository : IAsyncRepository<Transactions>
    {
    }
}
