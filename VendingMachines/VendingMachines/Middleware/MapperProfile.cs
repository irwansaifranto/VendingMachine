using AutoMapper;
using VendingMachines.Entities;
using VendingMachines.Models;

namespace VendingMachines.Middleware
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Products, ProductsViewModel>();
            CreateMap<Denominations, DenominationsViewModel>();
        }
    }
}
