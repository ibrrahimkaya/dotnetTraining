using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvcTestProject.Models;

namespace mvcTestProject.Controllers
{
    public class TypographyController : Controller
    {
        private readonly ILogger<TypographyController> _logger;

        public TypographyController(ILogger<TypographyController> logger)
        {
            _logger = logger;
        }

        public IActionResult Typography()
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
