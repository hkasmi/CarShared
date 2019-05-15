using CarShared.BLL.CityUC;
using CarShared.Shared.BTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarShared.WebUI.Controllers
{
    [Authorize]
    public class CityController : Controller
    {
        CityServices cityService = new CityServices();
        // GET: City
        public ActionResult Index(string name)
        {
            ViewBag.message = name;
            return View();
        }
        public ActionResult AddCity()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCity(CityBTO city)
        {
            cityService.AddCity(city);
            return RedirectToAction("Index",new { city.Name });
        }

        // GET: City/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: City/Create
        public ActionResult GetAllCities()
        {
            cityService.GetAllCities();
            return View(cityService.GetAllCities());
        }

        // POST: City/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: City/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: City/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: City/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: City/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
    }
}
