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

        #region Entity Framework Core CRUD Operations – UPDATE RECORDS
        public async Task<IActionResult> Update(int id)
        {
            Employee? emp = await this.companyContext.Employee
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            List<SelectListItem> dept = new List<SelectListItem>();
            dept = this.companyContext.Department
                .AsNoTracking()
                .Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() })
                .ToList();
            ViewBag.Department = dept;

            return View(emp);
        }

        //[HttpPost]
        //public async Task<IActionResult> Update(Employee emp)
        //{
        //    this.companyContext.Update(emp);
        //    await this.companyContext.SaveChangesAsync();

        //    return RedirectToAction("Index");
        //}

        #region TryUpdateModelAsync
        [HttpPost]
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empToUpdate = await this.companyContext.Employee
                .FirstOrDefaultAsync(x => x.Id == id);
            if (await TryUpdateModelAsync<Employee>((empToUpdate ?? new Employee()), "", s => s.Name, s => s.DepartmentId, s => s.Designation))
            {
                try
                {
                    await this.companyContext.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                catch (DbUpdateException ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }

            return View(empToUpdate);
        }
        #endregion

        #endregion

        #region Entity Framework Core CRUD Operations – DELETE RECORDS
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var emp = new Employee() { Id = id };
            // 若無對應資料，會抛出異常：DbUpdateConcurrencyException
            this.companyContext.Remove(emp);
            await this.companyContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}
