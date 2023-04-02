using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SaleProject.Models;
using SaleProject.Models.ViewModels;
using SaleProject.Services;

namespace SaleProject.Controllers
{
	public class SellersController : Controller
	{
		private readonly SellerService _sellerService;
		private readonly DepartmentService _departmentService;
		public SellersController(SellerService sellerService, DepartmentService departmentService)
		{
			_sellerService = sellerService;
			_departmentService = departmentService;
		}

		public IActionResult Index()
		{
			var list = _sellerService.GetSellerList();
			return View(list);
		}
		public IActionResult Create()
		{
			var departments = _departmentService.FindAll();
			var viewModel = new SellerFormViewModel { Departments = departments };
			return View(viewModel);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(Seller seller)
		{
			_sellerService.Insert(seller);
			return RedirectToAction(nameof(Index));
		}

		public IActionResult Delete(int? id)
		{
			if(id == null)
			{
				return NotFound("This ID doesnt exist in database");
			}
			var obj = _sellerService.FindById(id.Value);
			if(obj == null)
			{
				return NotFound(404);
			}

			return View(obj);
		}

		[HttpPost]
		public IActionResult Delete(int id)
		{
			_sellerService.Remove(id);
			return RedirectToAction(nameof(Index));
		}
	}
}