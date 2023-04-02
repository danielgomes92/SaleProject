using System.Security.Cryptography.X509Certificates;

namespace SaleProject.Services.Exceptions
{
	public class NotFoundException : ApplicationException
	{
		public NotFoundException(string message) : base(message)
		{
		}
	}
}
