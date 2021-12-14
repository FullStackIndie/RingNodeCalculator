using Microsoft.AspNetCore.Mvc;
using RingNodeCalculator.Enums;
using RingNodeCalculator.Models;
using RingNodeCalculator.Services;
using System.Diagnostics;

namespace RingNodeCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CalculatorService _calculatorService;

        public HomeController(ILogger<HomeController> logger, 
            CalculatorService calculatorService)
        {
            _logger = logger;
            _calculatorService = calculatorService;
        }

        public IActionResult Index()
        {
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