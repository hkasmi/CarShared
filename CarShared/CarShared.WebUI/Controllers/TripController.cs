using CarShared.BLL.TripUC;
using CarShared.Shared.BTO;
using CarShared.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CarShared.WebUI.Controllers
{
    public class TripController : Controller
    {
        TripServices tripservice = new TripServices();
        // GET: Trip
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddTrip()
        {
            //using (var client = new HttpClient())
            //using (var request = new HttpRequestMessage())
            //{
            //    string url = "https://andruxnet-world-cities-v1.p.rapidapi.com/?query=paris&searchby=city";
            //    request.Headers.Add("X-RapidAPI-Host", "andruxnet-world-cities-v1.p.rapidapi.com");
            //    request.Headers.Add("X-RapidAPI-Key", "cf30c1e9d3msh1a52c8399b7da63p1dc7a2jsn6d1dd9b48d42");
            //    request.Method = HttpMethod.Get;
            //    request.RequestUri = new Uri(url);
            //    var result = await client.SendAsync(request);
            //    //Cities parsedResult = await result.Content.ReadAsAsync<Cities>();
            //    var parsedResult = await result.Content.ReadAsAsync<Cities>();

                
            //}

            //ViewBag.cityList = "";

            return View();
        }
        [HttpPost]
        public ActionResult AddTrip(TripBTO bto)
        {
            bto.TripDate = DateTime.Now;
            tripservice.AddTrip(bto);
            return RedirectToAction("GetAllTrip");
        }
        // GET: Trip/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        // GET: Trip/EditTrip/5
        public ActionResult EditTrip(int id)
        {
            return View();
        }

        // POST: Trip/EditTrip/5
        [HttpPost]
        public ActionResult EditTrip(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Trip/Delete/5
        public ActionResult DeleteTrip(int id)
        {
            return View();
        }

        // POST: Trip/Delete/5
        [HttpPost]
        public ActionResult DeleteTrip(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult GetAllTrip()
        {
            var model = tripservice.GetAllTrips();
            return View(model);
        }
    }
}
