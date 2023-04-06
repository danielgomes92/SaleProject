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

		public async Task<List<Seller>> FindAllAsync()
		{
			return await _context.Seller.ToListAsync();
		}

		public async Task InsertAsync(Seller insertSeller)
		{
			_context.Add(insertSeller);
			await _context.SaveChangesAsync();
		}

		public async Task<Seller> FindByIdAsync(int id)
		{
			return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
		}

		public async Task RemoveAsync(int id)
		{
			try
			{
				var obj = await _context.Seller.FindAsync(id);
				_context.Seller.Remove(obj);
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateException dbError)
			{
				throw new IntegrityException(dbError.Message);
			}

		}

		public async Task UpdateAsync(Seller obj)
		{
			bool hasAny = await _context.Seller.AnyAsync(x => x.Id == obj.Id);

			if (!hasAny)
			{
				throw new NotFoundException("Id not found");
			}
			try
			{
				_context.Update(obj);
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException error)
			{
				throw new DbCurrencyException(error.Message);
			}
		}
	}
}