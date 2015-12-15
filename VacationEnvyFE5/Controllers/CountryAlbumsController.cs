using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VacationEnvyFE5.Data;
using VacationEnvyFE5.Models;
using System.Data.Entity;
using VacationEnvyFE5.Data.Models;
using Microsoft.AspNet.Identity;



namespace VacationEnvyFE5.Controllers
{
    public class CountryAlbumsController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
         //GET: CountryAlbums
        public ActionResult Index(int id)                       //country album id
        {
            CountryAlbumViewModel cntyAVm = new CountryAlbumViewModel();
            
            cntyAVm.CityAlbums = _db.CityAlbums.Include(c=>c.City).Include(c=>c.Pictures).Where(c => c.CountryAlbumId == id).ToList();            //added by AC 7-20

            cntyAVm.CityAlbums = _db.CityAlbums.Where(cntry => cntry.CountryAlbumId == id).Include(c => c.City).Include(s => s.City.State).Include(p => p.Pictures).ToList();            //added by AC 7-20

            cntyAVm.CountryAlbumDescription = _db.CountryAlbums.Where(c => c.CountryAlbumId == id).Select(ca => ca.Description).FirstOrDefault();               //added by AC 7-20

            cntyAVm.CityAlbumCount = cntyAVm.CityAlbums.Count;
           
            cntyAVm.CityAlbumTitle = _db.CityAlbums.Where(a => a.CountryAlbumId == id).Select(ca => ca.Title).FirstOrDefault();
         
            cntyAVm.CountryName = _db.CountryAlbums.Where(a => a.CountryAlbumId == id).Select(a => a.Country.CountryName).FirstOrDefault();

            //var albumCoverPic = _db.Pictures.Where(c => c.CountryAlbumId == id).FirstOrDefault(c => c.IsCountryCoverPic);           // CountryAlbum cover picture display by Nick/KI 07/20/15
            //cntyAVm.CityAlbumCover = albumCoverPic != null ? albumCoverPic.UrlName : default(string);      // CountryAlbum cover picture error check by Nick/KI 07/20/15

          
            //cntyAVm.StateName = _db.CityAlbums.Where(c => c.CountryAlbumId == id).Select(c => c.City.State.StateName).FirstOrDefault();    //added by Anna 7.21- doesnt work - try doing an include for state
        

            return View(cntyAVm);
        }


        // GET: CountryAlbums/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CountryAlbums/Create
        public ActionResult CreateCountryAlbum()
        {            
            return View();
        }

        //// POST: CountryAlbums/Create
        [HttpPost]
        public ActionResult CreateCountryAlbum(CreateCountryAlbumViewModel cAVm)
        {
            try
            {
                CountryAlbum createCountryAlbum = new CountryAlbum();
                createCountryAlbum.CountryId = cAVm.CountryId;
                createCountryAlbum.Description = cAVm.Description;
                //createCountryAlbum.DatePosted = new DateTime.Now;
                createCountryAlbum.UserId = User.Identity.GetUserId();
                createCountryAlbum.CountryAlbumId = cAVm.CountryAlbumId;
                _db.CountryAlbums.Add(createCountryAlbum);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
          
        }

        // GET: CountryAlbums/Edit/5
        public ActionResult Edit(int id)
        {
            EditCityAlbumViewModel editCityVm = new EditCityAlbumViewModel();
            CityAlbum tempCityAlbum = _db.CityAlbums.FirstOrDefault(c => c.CityAlbumId == id);
            editCityVm.Description = tempCityAlbum.Description;
            editCityVm.DateUpdated = tempCityAlbum.DateUpdated;
            editCityVm.Title = tempCityAlbum.Title;
            return View(editCityVm);
        }

        // POST: CountryAlbums/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, EditCityAlbumViewModel eCAVm)
        {
            try
            {
                CityAlbum saveCityAlbum = _db.CityAlbums.FirstOrDefault(c => c.CityAlbumId == eCAVm.CityAlbumId);
                saveCityAlbum.Description = eCAVm.Description;
                saveCityAlbum.Title = eCAVm.Title;
                saveCityAlbum.DateUpdated = eCAVm.DateUpdated;
                _db.Entry(saveCityAlbum).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CountryAlbums/Delete/5
        public ActionResult Delete(int id)
        {
            CityAlbum deleteCityAlbum = _db.CityAlbums.Find(id);
            return View();
        }

        // POST: CountryAlbums/Delete/5
        [HttpPost]
        public ActionResult DeleteFinal(int id)
        {
            try
            {
                CityAlbum deleteCityAlbum = _db.CityAlbums.Find(id);
                _db.CityAlbums.Remove(deleteCityAlbum);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
