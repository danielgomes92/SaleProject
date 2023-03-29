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
        public SaleProjectContext (DbContextOptions<SaleProjectContext> options)
            : base(options)
        {
        }

        public DbSet<SaleProject.Models.Department> Department { get; set; } = default!;
    }
}
