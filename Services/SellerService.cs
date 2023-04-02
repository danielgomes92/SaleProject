using Microsoft.EntityFrameworkCore;
using SaleProject.Data;
using SaleProject.Models;
using SaleProject.Services.Exceptions;
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
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Seller obj)
        {
            if(!_context.Seller.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException error)
            {
                throw new DbCurrencyException(error.Message);
            }
        }
    }
}
