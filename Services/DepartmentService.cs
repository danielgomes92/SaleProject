using SaleProject.Data;

namespace SaleProject.Services
{
	public class DepartmentService
	{
		private SaleProjectContext _context;

		public DepartmentService(SaleProjectContext context)
		{
			_context = context;
		}
	}
}
