using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvcTestProject.Models;

namespace mvcTestProject.Controllers
{
    public class LockscreenController : Controller
    {
        private readonly ILogger<LockscreenController> _logger;

        public LockscreenController(ILogger<LockscreenController> logger)
        {
            _logger = logger;
        }

        public IActionResult Lockscreen()
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

