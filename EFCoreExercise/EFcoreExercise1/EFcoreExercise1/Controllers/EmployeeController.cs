using EFcoreExercise1.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EFcoreExercise1.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly CompanyContext companyContext;

        public EmployeeController(CompanyContext companyContext)
        {
            this.companyContext = companyContext;
        }

        public IActionResult Index()
        {
            return View(this.companyContext.Employee.Include(s => s.Department));
        }

        #region Entity Framework Core CRUD Operations – CREATE RECORDS
        public IActionResult Create()
        {
            List<SelectListItem> depts = new List<SelectListItem>();
            depts = this.companyContext.Department
                .Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() })
                .ToList();
            ViewBag.Department = depts;

            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> Create(Employee emp)
        //{
        //    this.companyContext.Add(emp);
        //    await this.companyContext.SaveChangesAsync();

        //    return RedirectToAction(nameof(Index));
        //}

        [HttpPost]
        [ActionName("Create")]
        public async Task<IActionResult> Create_Post()
        {
            var emptyEmployee = new Employee();

            if (await TryUpdateModelAsync<Employee>(emptyEmployee, "", s => s.Name, s => s.DepartmentId, s => s.Designation))
            {
                this.companyContext.Employee.Add(emptyEmployee);
                await this.companyContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }
        #endregion
    }
}
