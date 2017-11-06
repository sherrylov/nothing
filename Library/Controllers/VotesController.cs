using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Library.Models;
using Library.Filters;

namespace Library.Controllers
{
    public class VotesController : Controller
    {
        private LibraryContext db = new LibraryContext();

        // GET: Votes
        [CheckLogin]
        public ActionResult Index()
        {
            var votes = db.Votes.Include(v => v.Option).Include(v => v.User);
            return View(votes.ToList());
        }

        // GET: Votes/Details/5
        [CheckLogin]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vote vote = db.Votes.Find(id);
            if (vote == null)
            {
                return HttpNotFound();
            }
            return View(vote);
        }

        // GET: Votes/Create
        [CheckLogin]
        public ActionResult Create()
        {
            ViewBag.OptionId = new SelectList(db.Options, "Id", "Name");
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserName");
            return View();
        }

        // POST: Votes/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [CheckLogin]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,UserId,OptionId")] Vote vote)
        {
            if (ModelState.IsValid)
            {
                db.Votes.Add(vote);
                db.SaveChanges();
                return RedirectToAction("Create");
            }

            ViewBag.OptionId = new SelectList(db.Options, "Id", "Name", vote.OptionId);
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserName", vote.UserId);
            return View(vote);
        }

        // GET: Votes/Edit/5
        [CheckLogin]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vote vote = db.Votes.Find(id);
            if (vote == null)
            {
                return HttpNotFound();
            }
            ViewBag.OptionId = new SelectList(db.Options, "Id", "Name", vote.OptionId);
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserName", vote.UserId);
            return View(vote);
        }

        // POST: Votes/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [CheckLogin]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,UserId,OptionId")] Vote vote)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vote).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.OptionId = new SelectList(db.Options, "Id", "Name", vote.OptionId);
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserName", vote.UserId);
            return View(vote);
        }

        // GET: Votes/Delete/5
        [CheckLogin]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vote vote = db.Votes.Find(id);
            if (vote == null)
            {
                return HttpNotFound();
            }
            return View(vote);
        }

        // POST: Votes/Delete/5

        [HttpPost, ActionName("Delete")]
        [CheckLogin]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vote vote = db.Votes.Find(id);
            db.Votes.Remove(vote);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
