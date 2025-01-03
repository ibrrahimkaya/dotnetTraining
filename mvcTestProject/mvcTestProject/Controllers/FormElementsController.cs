using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvcTestProject.Models;

namespace mvcTestProject.Controllers
{
    public class FormElementsController : Controller
    {
        private readonly ILogger<FormElementsController> _logger;

        public FormElementsController(ILogger<FormElementsController> logger)
        {
            _logger = logger;
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
