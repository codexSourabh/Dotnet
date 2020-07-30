using DemoMVC.DAL;
using DemoMVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVC.BLL
{
    public class BusinessBO
    {
        DAO dataAccess = new DAO();
        public void AddCustomer(Customer customer)
        {
            dataAccess.AddCustomer(customer);
        }
    }
}
