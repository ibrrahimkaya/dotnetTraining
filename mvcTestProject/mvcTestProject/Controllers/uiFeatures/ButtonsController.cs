using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvcTestProject.Models;

namespace mvcTestProject.Controllers
{
    public class ButtonsController : Controller
    {
        private readonly ILogger<ButtonsController> _logger;

        public ButtonsController(ILogger<ButtonsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Buttons()
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
