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

        public async Task<IActionResult> Index()
        {
            //Department dept = new Department()
            //{
            //    Name = "Designing"
            //};
            //this.companyContext.Entry(dept).State = EntityState.Added;
            //this.companyContext.SaveChanges();

            #region Eager Loading
            Employee? emp = await this.companyContext.Employee
                .Where(x => x.Name == "Matt")
                .Include(s => s.Department) // 通過導航屬性實現 Eager Loading
                .FirstOrDefaultAsync();
            // ThenInclude() 可以載入 Department 中包含的另一個導航屬性
            #endregion

            #region Explicit Loading in EF Core
            emp = await this.companyContext.Employee
                .Where(x => x.Name == "Matt")
                .FirstOrDefaultAsync();
            await this.companyContext.Entry<Employee>((emp ?? new Employee()))
                .Reference(x => x.Department)
                .LoadAsync();
            await this.companyContext.Entry<Employee>((emp ?? new Employee()))
                .Reference(x => x.Department)
                .Query()
                .Where(x => x.Name == "Admin")
                .LoadAsync();
            #endregion

            #region Lazy Loading in EF Core
            emp = await this.companyContext.Employee
                .Where(x => x.Name == "Matt")
                .FirstOrDefaultAsync();
            string deptName = (emp?.Department?.Name ?? "");
            #endregion

            #region No Tracking of Entities
            var emp1 = this.companyContext.Employee.AsNoTracking();
            #endregion

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

        #region EF Core - Code First Approach
        public IActionResult CreateInformation()
        {
            Information info = new Information()
            {
                Name = "YogiHosting",
                License = "XXYY",
                Revenue = 1000,
                Establshied = Convert.ToDateTime("2014/06/24")
            };
            this.companyContext.Entry(info).State = EntityState.Added;
            this.companyContext.SaveChanges();

            return View();
        }
        #endregion

        #region Insert/Create a Single Record on the Database
        public async Task<IActionResult> CreateDepartment()
        {
            var dept = new Department
            {
                Name = "Designing"
            };
            this.companyContext.Entry(dept).State = EntityState.Added;
            //this.companyContext.SaveChanges();
            await this.companyContext.SaveChangesAsync();

            return View();
        }
        #endregion

        #region TryUpdateModelAsync
        public async Task<IActionResult> CreateEmployee(Employee employee)
        {
            var emptyEmployee = new Employee();

            if (await TryUpdateModelAsync<Employee>(emptyEmployee, "", s => s.Name, s => s.DepartmentId, s => s.Designation))
            {
                this.companyContext.Employee.Add(emptyEmployee);
                await this.companyContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateDepartment(int id)
        {
            var department = await companyContext.Department.FindAsync(id);
            if (department == null)
            {
                return NotFound();
            }

            // 尝试将请求中的数据绑定到部门对象
            if (!await TryUpdateModelAsync(department))
            {
                // 如果数据绑定失败，返回错误信息
                return BadRequest();
            }

            // 保存更改到数据库中
            try
            {
                await companyContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                // 处理并发异常
                return Conflict();
            }

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Entity Framework Core Bulk Insert
        public async Task<IActionResult> BulkInsertDepartment()
        {
            var dept1 = new Department() { Name = "Development" };
            var dept2 = new Department() { Name = "HR" };
            var dept3 = new Department() { Name = "Marketing" };
            this.companyContext.AddRange(dept1, dept2, dept3);
            await this.companyContext.SaveChangesAsync();

            var depts = new List<Department>() { dept1, dept2, dept3 };
            this.companyContext.AddRange(dept1, dept2, dept3);
            await this.companyContext.SaveChangesAsync();

            return View();
        }
        #endregion

        #region Entity Framework Core Insert Related Records
        public async Task<IActionResult> InsertRelatedRecords()
        {
            var dept = new Department()
            {
                Name = "Admin"
            };
            var emp = new Employee()
            {
                Name = "Matt",
                Designation = "Head",
                Department = dept
            };
            this.companyContext.Add(emp);
            await this.companyContext.SaveChangesAsync();

            return View();
        }
        #endregion
    }
}
