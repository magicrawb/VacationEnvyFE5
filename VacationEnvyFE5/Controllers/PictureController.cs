using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VacationEnvyFE5.Data;
using VacationEnvyFE5.Models;
using System.Data.Entity;
using VacationEnvyFE5.Data.Models;

namespace VacationEnvyFE5.Controllers
{
    public class PictureController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        // GET: Picture
        public ActionResult Index(int id)           
        {
            PictureViewModel pVm = new PictureViewModel();

            pVm.CityAlbum = _db.CityAlbums
                            .Include(c => c.City.State.Country)
                            .Include(c => c.Pictures)
                            .FirstOrDefault(c => c.CityId == id);

            var pic = pVm.CityAlbum.Pictures.FirstOrDefault();
            if (pic == null)
            {
                pVm.UrlName = Url.Content("~/Content/Images/placeholder.png");
                pVm.PictureCaption = "No picture available";

            }
            else
            {
                pVm.UrlName = pic.UrlName;
                pVm.PictureCaption = pic.Caption;
            }

            pVm.CityId = id;

            return View(pVm);
        }

        // GET: Picture/Details/5
        public ActionResult Details(int id) // Not using the Details action
        {
            return View();
        }

        // GET: Picture/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Picture/Create
        [HttpPost]
        public ActionResult Create(CreatePictureViewModel cPVm)
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

        // GET: Picture/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Picture/Edit/5
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

        // GET: Picture/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Picture/Delete/5
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
