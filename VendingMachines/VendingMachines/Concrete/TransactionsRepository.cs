using VendingMachines.Abstract;
using VendingMachines.Entities;

namespace VendingMachines.Concrete
{
    public class TransactionsRepository : EFRepository<Transactions>, ITransactionsRepository
    {
        public TransactionsRepository(VendingMachinesDbContext context) : base(context)
        {
        }
    }
}
