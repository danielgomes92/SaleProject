using Microsoft.AspNetCore.Mvc;

namespace SaleProject.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
