using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPICF;

namespace WebAPICF.Data
{
    public class EmployeesDbContext : DbContext
    {
        public EmployeesDbContext (DbContextOptions<EmployeesDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPICF.Employee> Employee { get; set; } = default!;
    }
}
