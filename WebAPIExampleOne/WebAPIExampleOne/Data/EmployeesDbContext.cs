using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPIExampleOne.Models;

namespace WebAPIExampleOne.Data
{
    public class EmployeesDbContext : DbContext
    {
        public EmployeesDbContext (DbContextOptions<EmployeesDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPIExampleOne.Models.Employee> Employee { get; set; } = default!;
    }
}
