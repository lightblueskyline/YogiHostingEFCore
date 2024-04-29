using EFcoreExercise1.Models;

using Microsoft.AspNetCore.Mvc;

namespace EFcoreExercise1.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly CompanyContext companyContext;

        public DepartmentController(CompanyContext companyContext)
        {
            this.companyContext = companyContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region Entity Framework Core CRUD Operations – CREATE RECORDS
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Department dept)
        {
            this.companyContext.Add(dept);
            await this.companyContext.SaveChangesAsync();

            return View();
        }
        #endregion
    }
}
