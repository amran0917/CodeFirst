using CodeFirst.Custom;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class EmployeeDBContext:DbContext
    {
        public EmployeeDBContext():base("EmployeeDbContext")
        {

            
        }


        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Properties().Configure(c =>
            {
                var name = c.ClrPropertyInfo.Name;
                var newName = name.ToSnakeCase();                      
                c.HasColumnName(newName);
            });
        }



    }
}