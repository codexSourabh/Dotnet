using DemoMVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVC.DAL
{
    public class DAO
    {
        DemoMVCDbContext dbContext = new DemoMVCDbContext();
        public void AddCustomer(Customer customer)
        {
            dbContext.customerTable.Add(customer);
            dbContext.SaveChanges();
        }
    }
}
