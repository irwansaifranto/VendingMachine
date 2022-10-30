using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using VendingMachines.Abstract;
using VendingMachines.Models;

namespace VendingMachines.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductsRepository ProductRepositories;
        private readonly IDenominationsRepository DenominationsRepositories;
        private readonly ITransactionsRepository TransactionsRepositories;
        private readonly IMapper Mapper;

        public HomeController(
            ILogger<HomeController> logger,
            IProductsRepository productRepositories,
            IDenominationsRepository denominationsRepositories,
            ITransactionsRepository transactionsRepositories,
            IMapper mapper)
        {
            _logger = logger;
            ProductRepositories = productRepositories;
            DenominationsRepositories = denominationsRepositories;
            TransactionsRepositories = transactionsRepositories;
            Mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var products = await ProductRepositories.GetAll();
            var denominations = await DenominationsRepositories.GetAll() ;
            var productVwModel = Mapper.Map<List<ProductsViewModel>>(products);

            foreach (var single in productVwModel)
                single.PriceString = string.Format("{0:C}", single.Price);

            TransactionsViewModel model = new TransactionsViewModel();
            model.ProductsVwModel = productVwModel;
            model.DenominationListItem = denominations.Select(c => new SelectListItem() { Text = string.Format("{0:C}", c.Denomination), Value = c.Denomination.ToString() }).ToList();
            
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(TransactionsViewModel model)
        {
           
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}