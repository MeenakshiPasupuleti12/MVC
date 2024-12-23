using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Dal;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProductController : Controller
    {
        ProductContext dal = null;
        public ProductController() : base()
        {
            dal = new ProductContext();
        }

        public ActionResult Index()
        {
            List<Product>plist = new List<Product>();
            return View(plist);
        }
        [HttpGet]
        public ActionResult Create()
        {
           return View();
        }
        [HttpPost]
        public ActionResult Create(Product p)
        {
            if (ModelState.IsValid)
            {
                dal.Products.Add(p);
                dal.SaveChanges();
                List<Product> plist = new List<Product>();
                return View("Index", plist);
            }
            else
            {
                return View("Create",p);
            }
        

           
            
            
        }
    }
}