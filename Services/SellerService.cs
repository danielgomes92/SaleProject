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
            // To fix Referencial Integrity EF
            // insertSeller.Department = _context.Department.First();  DO NOT NEED, IS INSTANCED
            _context.Add(insertSeller);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}
