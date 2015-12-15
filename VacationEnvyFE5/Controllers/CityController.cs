using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VacationEnvyFE5.Data;
using VacationEnvyFE5.Data.Models;

namespace VacationEnvyFE5.Controllers
{
    public class CityController : Controller
    {
        ApplicationDbContext _db = new ApplicationDbContext();
        // GET: City
        public ActionResult Index()
        {
            IQueryable<City> cities = from m in _db.Cities select m;
            return View(cities.ToList());
        }

        // GET: City/Details/5
        public ActionResult Details(int id)
        {
            City city = _db.Cities.Find(id);

            return View(city);
        }

        // GET: City/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: City/Create
        [HttpPost]
        public ActionResult Create(City city)
        {
            if(ModelState.IsValid)
            {
                _db.Cities.Add(city);
                _db.SaveChanges();

                return RedirectToAction("Index");
            };

            return View();
        }

        // GET: City/Edit/5
        public ActionResult Edit(int id)
        {
            City city = _db.Cities.Find(id);

            return View(city);
        }

        // POST: City/Edit/5
        [HttpPost]
        public ActionResult Edit(City city)
        {
            if(ModelState.IsValid)
            {
                _db.Entry(city).State = EntityState.Modified;
                _db.SaveChanges();

                return RedirectToAction("Index");
            };

            return View();
        }

        // GET: City/Delete/5
        public ActionResult Delete(int id)
        {
            City city = _db.Cities.Find(id);

            return View(city);
        }

        // POST: City/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, int? Dummy)
        {
            City cityToDelete = _db.Cities.Find(id);
            _db.Cities.Remove(cityToDelete);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
