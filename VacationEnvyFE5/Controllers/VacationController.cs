using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VacationEnvyFE5.Controllers
{
    public class VacationController : Controller
    {
        // GET: Vacation
        //public ActionResult Index()
        ////{
        ////    CityAlbumIndexViewModel cAIVm = new CityAlbumIndexViewModel(); 
        ////    string currentUserId = ""; 
        ////    User.Identity.GetUserId(); 
        ////    ICollection<CountryAlbum> vacations = _db.CountryAlbums.Where(c => c.ApplicationUser.Id == currentUserId).ToList();
        ////    cAIVm.CountryName = vacations;
        //    return View();
        ////}

        // GET: Vacation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Vacation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vacation/Create
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

        // GET: Vacation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Vacation/Edit/5
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

        // GET: Vacation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Vacation/Delete/5
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
