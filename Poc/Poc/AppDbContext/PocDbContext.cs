using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Poc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poc.AppDBContext
{
    public class PocDBContext : IdentityDbContext<Employee>
    {
        public PocDBContext(DbContextOptions<PocDBContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder
               .Entity<Company>()
               .HasMany(u => u.EmployeeList)
               .WithOne(u => u.Company)
               .OnDelete(DeleteBehavior.ClientCascade);
        }
        //public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }
        
    }
}
