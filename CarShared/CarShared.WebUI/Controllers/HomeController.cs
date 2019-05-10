using CarShared.BLL.TripUC;
using CarShared.Shared.BTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarShared.WebUI.Controllers
{
    public class HomeController : Controller
    {
        TripServices tripservice = new TripServices();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddTrip()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTrip(TripBTO bto)
        {
            bto.TripDate = DateTime.Now;
            tripservice.AddTrip(bto);
            return RedirectToAction("GetAllTrip");
        }

        public ActionResult GetAllTrip()
        {
            var model = tripservice.GetAllTrips();
            return View(model);
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}