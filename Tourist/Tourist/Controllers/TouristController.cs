using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tourist.Dal;
using Tourist.Models;

namespace Tourist.Controllers
{
    public class TouristController : Controller
    {
        TouristPlaceContext context = null;
        public TouristController()
        {
            context = new TouristPlaceContext();
        }
        public ActionResult uploadTouristPlace()
        {
            return View();
        }
        public ActionResult saveTouristPlace( TouristPlace tp)
        {
            tp.Files = Request.Files;
            HttpPostedFileBase file = tp.Files[0];
            string filepath = "~/Images/TouristPlaces/" + file.FileName;
            tp.ImagePath = filepath;
            file.SaveAs(Server.MapPath(filepath));
            context.Tourists.Add(tp);
            context .SaveChanges();
            List<TouristPlace> tplist=context.Tourists.ToList();
            return View("DisplayTouristPlace",tplist);
        }

    }
}