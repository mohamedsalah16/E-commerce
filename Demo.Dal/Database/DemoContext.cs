using Demo.Dal.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Dal.Database
{
    public class DemoContext :DbContext
    {
        public DbSet<Department> Department { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-29F4G14\\SQLEXPRESS;database=DemoDb;Integrated Security=true;TrustServerCertificate=True;  ");
        }
    }
}
