using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SaleProject.Models;
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
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create([Bind("Id,Name,Email,BirthDate,BaseSalary")] Seller seller)
		{
			_sellerService.Insert(seller);
			return RedirectToAction(nameof(Index));
		}
	}
}