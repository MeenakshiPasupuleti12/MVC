using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult EnterNewProduct()
        {
            return View();
        }
        public ActionResult SaveProduct(Product p)
        {
             
            return View("DisplayProduct", p);
        }


       
    }
}