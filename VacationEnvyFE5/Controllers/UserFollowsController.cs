using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VacationEnvyFE5.Data;
using VacationEnvyFE5.Data.Models;
using VacationEnvyFE5.Models;
using Microsoft.AspNet.Identity;

namespace VacationEnvyFE5.Controllers
{
//    //IN PROGRESS - NEEDS WORK - AC 7-17

    public class UserFollowsController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        private ApplicationUserManager _userManager;
      

    //    // GET: UserFollows
    //    public ActionResult Index()
    //    {
    //        var CurrentUser = User.Identity.GetUserId();
    //        var Users = _userManager.Users.ToListAsync();  //displays all registered users
    //        return View(Users);
    //    }

    public ActionResult ShowFollowings(string id)
{
     FollowingViewModel fligVm = new FollowingViewModel();

        fligVm.Followings = _db.UserFollows.Where(u => u.FromId == id).Select(u =>u.ToUser).ToList();
         
     //    Select(u => new ApplicationUser 
     //{ 
     //   ToUser = followings.FirstOrDefault().
     //}).ToList();
        return View(fligVm);
}

    public ActionResult ShowFollowers(string id)
    {
        FollowersViewModel flwrVm = new FollowersViewModel();

        flwrVm.Followers = _db.UserFollows.Where(u => u.ToId == id).Select(u => u.FromUser).ToList();

        //    Select(u => new ApplicationUser 
        //{ 
        //   ToUser = followings.FirstOrDefault().
        //}).ToList();
        return View(flwrVm);
    }



    //    public ActionResult FollowUser(string toId)
    //    {
    //        var CurrentUser = User.Identity.GetUserId();
    //        //var receiverOfFollow = //id of user's profile you're viewing;
    //        var ImFollowing = db.UserFollows.Where(f => f.FromId == CurrentUser).Select(f => f.ToId).ToList();
            
    //        return View();
    //    }

    //    public ActionResult BeFollowed(string fromId)
    //    {
    //        var CurrentUser = User.Identity.GetUserId();
    //        var FollowingMe = db.UserFollows.Where(f => f.ToId == CurrentUser).Select(f => f.FromId).ToList();

    //        return View();
    //    }

        //public void FollowUser(string id)
        //{
        //    return View(id);
        //}
        //    ViewData["test"] = "test";
               
        //    currentUser.FollowingId = id;           //left off on this after currentUser
        //    n.FollowerId = User.Identity.Name;
        //    string message = string.Empty;
        //    var list = new List<FollowingUser>();

        //    list = (from a in db.FollowingUsers where a.FollowerId == User.Identity.Name && a.FollowingId == id select a).ToList();

        //    if (list.Count() == 0)
        //    {

        //        try
        //        {
        //            db.AddToFollowingUsers(n);
        //            db.SaveChanges();
        //        }

        //        catch (Exception ex)
        //        {
        //            message = ex.Message;
        //        }
        //    }

        //    else
        //    {
        //        db.DeleteObject((from a in db.FollowingUsers where a.FollowerId == User.Identity.Name select a).FirstOrDefault());
        //        db.SaveChanges();
        //    }
        //}

    //    //***** different solution/original code:
            
    //        //ProfileViewModel pVm = new ProfileViewModel();
    //        //pVm.FromId = db.UserFollows.FromId
    //        //var userFollows = db.UserFollows.Include(u => u.FromUser).Include(u => u.ToUser);
    //        //return View(userFollows.ToList());
    //    }

    //    // GET: UserFollows/Details/5
    //    public ActionResult Details(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        UserFollow userFollow = db.UserFollows.Find(id);
    //        if (userFollow == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        return View(userFollow);
    //    }

    //    // GET: UserFollows/Create
    //    public ActionResult Create()
    //    {
    //        ViewBag.FromId = new SelectList(db.Users, "Id", "FirstName");
    //        ViewBag.ToId = new SelectList(db.Users, "Id", "FirstName");
    //        return View();
    //    }

    //    // POST: UserFollows/Create
    //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Create([Bind(Include = "UserFollowId,FromId,ToId")] UserFollow userFollow)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            db.UserFollows.Add(userFollow);
    //            db.SaveChanges();
    //            return RedirectToAction("Index");
    //        }

    //        ViewBag.FromId = new SelectList(db.Users, "Id", "FirstName", userFollow.FromId);
    //        ViewBag.ToId = new SelectList(db.Users, "Id", "FirstName", userFollow.ToId);
    //        return View(userFollow);
    //    }

    //    // GET: UserFollows/Edit/5
    //    public ActionResult Edit(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        UserFollow userFollow = db.UserFollows.Find(id);
    //        if (userFollow == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        ViewBag.FromId = new SelectList(db.Users, "Id", "FirstName", userFollow.FromId);
    //        ViewBag.ToId = new SelectList(db.Users, "Id", "FirstName", userFollow.ToId);
    //        return View(userFollow);
    //    }

    //    // POST: UserFollows/Edit/5
    //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Edit([Bind(Include = "UserFollowId,FromId,ToId")] UserFollow userFollow)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            db.Entry(userFollow).State = EntityState.Modified;
    //            db.SaveChanges();
    //            return RedirectToAction("Index");
    //        }
    //        ViewBag.FromId = new SelectList(db.Users, "Id", "FirstName", userFollow.FromId);
    //        ViewBag.ToId = new SelectList(db.Users, "Id", "FirstName", userFollow.ToId);
    //        return View(userFollow);
    //    }

    //    // GET: UserFollows/Delete/5
    //    public ActionResult Delete(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        UserFollow userFollow = db.UserFollows.Find(id);
    //        if (userFollow == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        return View(userFollow);
    //    }

    //    // POST: UserFollows/Delete/5
    //    [HttpPost, ActionName("Delete")]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult DeleteConfirmed(int id)
    //    {
    //        UserFollow userFollow = db.UserFollows.Find(id);
    //        db.UserFollows.Remove(userFollow);
    //        db.SaveChanges();
    //        return RedirectToAction("Index");
    //    }

    //    protected override void Dispose(bool disposing)
    //    {
    //        if (disposing)
    //        {
    //            db.Dispose();
    //        }
    //        base.Dispose(disposing);
    //    }
    }
}

