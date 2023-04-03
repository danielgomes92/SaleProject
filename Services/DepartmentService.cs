using Microsoft.EntityFrameworkCore;
using SaleProject.Data;
using SaleProject.Models;

namespace SaleProject.Services
{
	public class DepartmentService
	{
		private SaleProjectContext _context;

		public DepartmentService(SaleProjectContext context)
		{
			_context = context;
		}

		public async Task<List<Department>> FindAllAsync()
		{
			return await _context.Department.OrderBy(x => x.Name).ToListAsync();
		}
	}
}
