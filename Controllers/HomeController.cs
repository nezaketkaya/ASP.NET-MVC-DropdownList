using AspNetDropdownList.Helper;
using AspNetDropdownList.Models;
using AspNetDropdownList.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace AspNetDropdownList.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var countriesData = Countries.GetAll();
            var model = new HomeViewModel();
            model.CountriesSelectist = new List<SelectListItem>();

            foreach (var country in countriesData)
            {
                model.CountriesSelectist.Add(new SelectListItem { Text = country.Name, Value = country.Id });

            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(HomeViewModel model)
        {
            var selectedCountry = model.SelectedCountry;

            return RedirectToAction("Index");
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
