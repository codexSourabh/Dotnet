using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVC.Entities
{
    public class DemoMVCDbContext : DbContext
    {
        public DemoMVCDbContext() : base("name=connection")
        {
        }
        public DbSet<Customer> customerTable { get; set; }
    }
}
