using VendingMachines.Abstract;
using VendingMachines.Entities;

namespace VendingMachines.Concrete
{
    public class DenominationsRepository : EFRepository<Denominations>, IDenominationsRepository
    {
        public DenominationsRepository(VendingMachinesDbContext context) : base(context)
        {
        }
    }
}
