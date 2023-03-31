using SaleProject.Data;
using SaleProject.Models;
using System.Security.Policy;

namespace SaleProject.Services
{
    public class SellerService
    {
        private readonly SaleProjectContext _context;

        public SellerService(SaleProjectContext context)
        {
            _context = context;
        }
        
        public List<Seller> GetSellerList()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller insertSeller)
        {
            _context.Add(insertSeller);
            _context.SaveChanges();
        }
    }
}
