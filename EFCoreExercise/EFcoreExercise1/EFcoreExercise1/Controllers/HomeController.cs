using EFcoreExercise1.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using System.Diagnostics;

namespace EFcoreExercise1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CompanyContext companyContext;

        public HomeController(ILogger<HomeController> logger, CompanyContext companyContext)
        {
            _logger = logger;
            this.companyContext = companyContext;
        }

        public IActionResult Index()
        {
            Department dept = new Department()
            {
                Name = "Designing"
            };
            this.companyContext.Entry(dept).State = EntityState.Added;
            this.companyContext.SaveChanges();

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
