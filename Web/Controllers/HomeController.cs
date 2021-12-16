using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ITemplateService _templateService;

        public HomeController(ILogger<HomeController> logger, ITemplateService templateService)
        {
            _logger = logger;
            _templateService = templateService;
        }

        public IActionResult Index()
        {
            _templateService.Add(new Template()
            {
                Name = "Deneme"
            });
            return View();
        }

        public IActionResult Privacy()
        {
            var list = _templateService.GetList(x => x.Name == "Deneme");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}