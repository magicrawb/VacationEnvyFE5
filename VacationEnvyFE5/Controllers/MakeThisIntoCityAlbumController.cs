using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VacationEnvyFE5.Data;
using VacationEnvyFE5.Data.Models;

namespace VacationEnvyFE5.Controllers
{                           
    //Transferred to non-API framework - ALC 7/13
    public class CountryAlbumController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        // GET: CountryAlbum
        public ActionResult Index()
        {
            // Modify this section: KI 07/14/15
            //IList<CityAlbum> cityAlbums = _db.CityAlbums.ToList(); //from c in _db.CountryAlbums select c;
            return View();
            
        }

        // GET: CountryAlbum/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CountryAlbum/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CountryAlbum/Create
        [HttpPost]
        public ActionResult Create(CountryAlbum countryalbum)
        {
            if (ModelState.IsValid)
            {
                _db.CountryAlbums.Add(countryalbum);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: CountryAlbum/Edit/5
        public ActionResult Edit(int id)
        {
            CountryAlbum countryalbum = _db.CountryAlbums.Find(id);

            return View(countryalbum);
        }

        // POST: CountryAlbum/Edit/5
        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit(CountryAlbum countryalbum)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(countryalbum).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: CountryAlbum/Delete/5
        public ActionResult Delete(int id)
        {
            CountryAlbum countryalbum = _db.CountryAlbums.Find(id);
            return View(countryalbum);
        }

        // POST: CountryAlbum/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteReally(int id)
        {
            var original = _db.CountryAlbums.Find(id);
            _db.CountryAlbums.Remove(original);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
