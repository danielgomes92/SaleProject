using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SaleProject.Models;

namespace SaleProject.Data
{
    public class SaleProjectContext : DbContext
    {
        public SaleProjectContext(DbContextOptions<SaleProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; } // = default!;
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }
    }
}
