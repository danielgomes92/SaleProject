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

		public List<Department> FindAll()
		{
			return _context.Department.OrderBy(x => x.Name).ToList();
		}
	}
}
