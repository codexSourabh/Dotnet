using DemoMVC.BLL;
using DemoMVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.PresentationLayer.Controllers
{
    public class DemoMVCHomeController : Controller
    {
        // GET: DemoMVCHome
        BusinessBO business = new BusinessBO();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddCustomer(Customer customer)
        {
            business.AddCustomer(customer);
            return View("Index");
        }
    }
}