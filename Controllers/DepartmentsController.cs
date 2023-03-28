using Microsoft.AspNetCore.Mvc;
using SaleProject.Models;

namespace SaleProject.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> deptList = new List<Department>();
            deptList.Add(new Department { Id = 1, Name = "Eletronics" });
            deptList.Add(new Department { Id = 2, Name = "Fashion" });
            
            return View(deptList);
        }
    }
}
