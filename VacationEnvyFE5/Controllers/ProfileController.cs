// Modified the old version of the ProfileController (KI 07/19/15)
// Uncertain about the security. See the comments under the edit action. (KI 07/19/15)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VacationEnvyFE5.Data;
using VacationEnvyFE5.Data.Models;
using VacationEnvyFE5.Models;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using System.Data;
using Microsoft.AspNet.Identity.EntityFramework;

namespace VacationEnvyFE5.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        private ApplicationUserManager _userManager; //added by AC 7-17 8:00

        // GET: Profile: Disabled because we don't need an index view.
        //public ActionResult Index()
        //{
        //    return View();
        //}

         //GET: Profile/Details/5
         //Binds the user profile details ViewModel to the database by KI. Not tested. (07/10/15)
        public ActionResult Index(string id)            
        {
            //var Users= _userManager.Users;
            ProfileViewModel pVm = new ProfileViewModel();
            string currentUserId = User.Identity.GetUserId();
            string otherUserId = id;
            if (otherUserId != null)
            {
                currentUserId = otherUserId;
            }
            ApplicationUser user = _db.Users.FirstOrDefault(u => u.Id == currentUserId);
            pVm.Id = currentUserId; // Added by KI 07/19/15
            pVm.UserName = user.UserName;
            pVm.Biography = user.Biography;
            //pVm.HomeCity = user.City.CityName;
            //pVm.HomeCountry = user.Country.CountryName; user1.Id
            pVm.Following = _db.UserFollows.Where(u => u.FromId == currentUserId).ToList();
            pVm.Followers = _db.UserFollows.Where(u => u.ToId == currentUserId).ToList();
            pVm.FollowerCount = pVm.Followers.Count;
            pVm.FollowingCount = pVm.Following.Count;
            pVm.CountryAlbums = _db.CountryAlbums
                .Include(c=>c.Country)
                .Include(c=>c.CityAlbums.Select(cc=>cc.Pictures))
                .Where(u => u.UserId == currentUserId).ToList();
            pVm.CountryCount = pVm.CountryAlbums.Count();

            return View(pVm);
        }

        // GET: Profile/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Profile/Create  // No need for the Create action as this will be taken care of when a guest creates a registered user account.
        //[HttpPost]             // KI 07/19/15
        //public ActionResult Create(CreateProfileViewModel cPVm)
        //{


        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Profile/Edit/5
        public ActionResult Edit(string id)
        {
            ProfileViewModel editProfileVm = _db.Users.Where(u => u.Id == id)
                .Select(m => new ProfileViewModel 
            { 
                Biography = m.Biography,
                Email = m.Email,
                HomeCity = m.City.CityName,
                HomeCountry = m.Country.CountryName,
                FirstName = m.FirstName,
                LastName = m.LastName,
                UserName = m.UserName,
                ViewId = id
            }).FirstOrDefault();

            return View(editProfileVm);
        }

        // POST: Profile/Edit/5
        [HttpPost]
        public ActionResult Edit(ProfileViewModel editProfileVm)
        {
            if(ModelState.IsValid)
            {
                ApplicationUser saveApplicationUser = _db.Users.Where(m => User.Identity.Name == m.UserName).FirstOrDefault();
                saveApplicationUser.Biography = editProfileVm.Biography;
                //saveApplicationUser.City.CityName = editProfileVm.HomeCity;
                //saveApplicationUser.Country.CountryName = editProfileVm.HomeCountry;
                saveApplicationUser.FirstName = editProfileVm.FirstName;
                saveApplicationUser.LastName = editProfileVm.LastName;
                saveApplicationUser.UserName = editProfileVm.UserName;

                _db.Entry(saveApplicationUser).State = EntityState.Modified; 
                _db.SaveChanges();

                return RedirectToAction("Index");

            }
                // TODO: Add update logic here
                // Completed by KI 07/19/15. Not certain if this is a secure method of modifing ApplicationUser properties.  
            return View();
        }

        // GET: Profile/Delete/5
        public ActionResult Delete(string id)
        {
            ApplicationUser deleteUser = _db.Users.Find(id);
            return View();
        }

        // POST: Profile/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, int? x)
        {
            try
            {
                // TODO: Add delete logic here
                ApplicationUser deleteUser = _db.Users.Where(m => User.Identity.Name == m.UserName).FirstOrDefault();
                _db.Users.Remove(deleteUser);
                _db.SaveChanges();
                return Redirect("/Home/Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
