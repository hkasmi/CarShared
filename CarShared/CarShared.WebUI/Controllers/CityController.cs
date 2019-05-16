using CarShared.BLL.CityUC;
using CarShared.Common.Enums;
using CarShared.Shared.BTO;
using CarShared.Shared.DTO;
using Newtonsoft.Json;
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
        public ActionResult GetCityByCountry()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetCityByCountry(Country country)
        {
            var cities = JsonConvert.SerializeObject(cityService.GetCitiesByCountry(country));
            return RedirectToAction("DetailsCities", new { cities });
        }
        // GET: City/Create
        public ActionResult GetAllCities()
        {
            cityService.GetAllCities();
            return View(cityService.GetAllCities());
        }

        public ActionResult DetailsCities(string cities)
        {

            List<CityBTO> cities2 = JsonConvert.DeserializeObject<List<CityBTO>>(cities);
            return View(cities2);
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
        public ActionResult EditCity(int id)
        {
            CityBTO city = cityService.GetCityById(id);
            return View(city);
        }
        [HttpPost]
        public ActionResult EditCity(CityBTO city)
        {
            cityService.UpdateCity(city);
            return RedirectToAction("GetCityByCountry", new { city.Country });
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
        public ActionResult DeleteCity(int id)
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
