using Microsoft.AspNetCore.Mvc;
using SaleProject.Services;

namespace SaleProject.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;
        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.GetSellerList();
            return View(list);
        }
    }
}