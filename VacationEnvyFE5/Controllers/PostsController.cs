// Added Index logic: KI 07/14/15 (Pending)
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VacationEnvyFE5.Data;
using VacationEnvyFE5.Data.Models;
using VacationEnvyFE5.Models;

namespace VacationEnvyFE5.Controllers
{
    //** NOT USING POST ANYMORE

    //public class PostsController : Controller
    //{
    //    private ApplicationDbContext _db = new ApplicationDbContext();
    //    // GET: Posts
    //    public ActionResult Index() // takes the postId from the View
    //    {
    //        // Modify this section: KI 07/14/15
    //        //PostIndexViewModel pIVm = new PostIndexViewModel();
    //        //Post CurrentPost = _db.Posts.FirstOrDefault(p => p.PostId == postId);
    //        //pIVm.Description = CurrentPost.Description;
    //        //pIVm.DatePost = CurrentPost.DatePost;
    //        //return View(pIVm);

    //        //IQueryable<Post> posts = from p in _db.Posts select p;
    //        //return View(posts.ToList());
    //        return View();
    //    }

    //    // GET: Posts/Details/5
    //    public ActionResult Details(int id)
    //    {
    //        return View();
    //    }

    //    // GET: Posts/Create
    //    public ActionResult Create()
    //    {
    //        return View();
    //    }

    //    // POST: Posts/Create
    //    [HttpPost]
    //    public ActionResult Create(Post post)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            _db.Posts.Add(post);
    //            _db.SaveChanges();
    //        }
    //        return View();
    //    }

    //    // GET: Posts/Edit/5
    //    public ActionResult Edit(int id = 0)
    //    {
    //        Post post = _db.Posts.Find(id);
    //        return View(post);
    //    }

    //    // POST: Posts/Edit/5
    //    [HttpPost]
    //    [ActionName("Edit")]

    //    public ActionResult Edit(Post post)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            _db.Entry(post).State = EntityState.Modified;
    //            _db.SaveChanges();
    //            return RedirectToAction("Index");
    //        }
    //        return View();
    //    }

    //    // GET: Posts/Delete/5
    //    public ActionResult Delete(int id)
    //    {
    //        Post post = _db.Posts.Find(id);
    //        return View(post);

    //    }

    //    // POST: Posts/Delete/5
    //    [HttpPost]
    //    [ActionName("Delete")]
    //    public ActionResult DeleteReally(int id)
    //    {
    //        var original = _db.Posts.Find(id);
    //        _db.Posts.Remove(original);
    //        _db.SaveChanges();
    //        return RedirectToAction("Index");
    //    }
    //}
}
