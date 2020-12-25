using Microsoft.EntityFrameworkCore;
using ReposistryLayer.ContextModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReposistryLayer.EmployeeDBContext
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
        : base(options)
        {
        }
        public DbSet<CompanyEmployee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CompanyEmployee>()
                .HasIndex(u => u.Email)
                .IsUnique();
        }
    }
}
