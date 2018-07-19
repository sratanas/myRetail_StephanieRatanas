using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myRetail_StephanieRatanas.Models;
using myRetail_StephanieRatanas.Services;

namespace myRetail_StephanieRatanas.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRedSkyService _redSkyService;

        public HomeController(IRedSkyService redSkyService)
        {
            _redSkyService = redSkyService;
        }

        public async Task<IActionResult> Index()
        {
            var model = new MyRetailModel();

            model.JsonFromApi = await _redSkyService.ReturnAllApiData();

            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
