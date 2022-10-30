using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VendingMachines.Abstract;
using VendingMachines.Models;

namespace VendingMachines.Controllers
{
    public class DenominationsController : Controller
    {
        private readonly IDenominationsRepository DenominationsRepositories;
        private readonly IMapper Mapper;

        public DenominationsController(IDenominationsRepository denominatiosRepositories, IMapper mapper)
        {
            DenominationsRepositories = denominatiosRepositories;
            Mapper = mapper;
        }

        // GET: HomeController1
        public async Task<IActionResult> Index()
        {
            var denominations = await DenominationsRepositories.GetAll();
            var model = Mapper.Map<List<DenominationsViewModel>>(denominations);

            return View(model);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
