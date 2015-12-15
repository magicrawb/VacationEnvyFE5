// Deleted the old version and the new CityAlbumController added by KI 07/16/15
// Completed CityAlbumController (KI 07/17/15)
// CityAlbumController is complete, but not tested (at least no red squiggly line :-))
// Removed the UrlName from the edit action class (KI 07/19/15)
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VacationEnvyFE5.Data;
using VacationEnvyFE5.Data.Models;
using VacationEnvyFE5.Models;
using Microsoft.AspNet.Identity;

namespace VacationEnvyFE5.Controllers
{
    public class CityAlbumController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
 
        // GET: CityAlbum
        public ActionResult Index(int id) // the id of the city album ID passed from CountryAlbum
        {
            CityAlbumViewModel cAVm = new CityAlbumViewModel();
            //CityAlbum cityA = _db.CityAlbums.Find(id);
            //IQueryable<Picture> picList = from m in _db.Pictures where m.CityAlbumId == cityA.CityAlbumId select m;
            //IList<Picture> finalList = picList.ToList();          
            //cAVm.PictureList = finalList;
            cAVm.CityDescription = _db.CityAlbums.FirstOrDefault(cty => cty.CityAlbumId == id).Description.ToString(); 
            cAVm.CountryName = _db.CityAlbums.Where(d => d.CityAlbumId == id).Select(c => c.CountryAlbum.Country.CountryName).FirstOrDefault();
            cAVm.CityName = _db.CityAlbums.Where(k => k.CityAlbumId == id).Select(t => t.City.CityName).FirstOrDefault();
            cAVm.ListOfPics = _db.Pictures.Where(c => c.CityAlbumId == id).ToList();
 
            return View(cAVm);
        }

        // GET: CityAlbum/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CityAlbum/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CityAlbum/Create
        [HttpPost]
        public ActionResult Create(CreatePictureViewModel pVm)
        {
            try
            {
                // TODO: Add insert logic here
                Picture createPicture = new Picture();
                createPicture.Caption = pVm.Caption;
                createPicture.UrlName = pVm.UrlName;
                createPicture.CountryAlbumId = pVm.CountryAlbumId;
                createPicture.CityAlbumId = pVm.CityAlbumId;
                createPicture.IsCityCoverPic = pVm.IsCityCoverPic;
                createPicture.IsCountryCoverPic = pVm.IsCountryCoverPic;
                createPicture.TagName = pVm.TagName;
                createPicture.UrlName = pVm.UrlName;
                _db.Pictures.Add(createPicture);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CityAlbum/Edit/5
        public ActionResult Edit(int id)
        {
            //EditPictureViewModel editPictureVm = new EditPictureViewModel();
            //Picture tempPicture = _db.Pictures.FirstOrDefault(p => p.PictureId == id);
            //editPictureVm.Caption = tempPicture.Caption;
            //editPictureVm.TagName = tempPicture.TagName;
            //editPictureVm.IsCityCoverPic = tempPicture.IsCityCoverPic;
            //editPictureVm.IsCountryCoverPic = tempPicture.IsCountryCoverPic;

            Picture pic = _db.Pictures.Find(id);

            return View(pic);
        }

        // POST: CityAlbum/Edit/5
        [HttpPost]
        public ActionResult Edit(Picture ePVm)
        {
            try
            {
                Picture savePicture = _db.Pictures.FirstOrDefault(p => p.PictureId == ePVm.PictureId);
                savePicture.Caption = ePVm.Caption;
                savePicture.TagName = ePVm.TagName;
                savePicture.IsCityCoverPic = ePVm.IsCityCoverPic;
                savePicture.IsCountryCoverPic = ePVm.IsCountryCoverPic;
                
                _db.Entry(savePicture).State = EntityState.Modified;
                _db.SaveChanges();
                return Redirect("/Profile/Index/?id=" + User.Identity.GetUserId());
            }
            catch
            {
                return View();
            }
        }

         //GET: CityAlbum/Delete/5
        public ActionResult Delete(int id)
        {
            Picture deletePicture = _db.Pictures.Find(id);
            return View();
        }

        // POST: CityAlbum/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, int? dummy)
        {
            try
            {
                // TODO: Add delete logic here
                Picture deletePicture = _db.Pictures.Find(id);
                _db.Pictures.Remove(deletePicture);
                _db.SaveChanges();
                return Redirect("/Profile/Index/?id=" + User.Identity.GetUserId());
            }
            catch
            {
                return View();
            }
        }
    }
}
