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
    public class NoticesController : Controller
    {
        private LibraryContext db = new LibraryContext();

        // GET: Notices
        [CheckAdmin]
        public ActionResult Index()
        {
            var notices = db.Notices.Include(n => n.Author);
            return View(notices.ToList());
        }

        // GET: Notices/Details/5
        [CheckAdmin]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notice notice = db.Notices.Find(id);
            if (notice == null)
            {
                return HttpNotFound();
            }
            return View(notice);
        }

        // GET: Notices/Create
        [CheckAdmin]
        public ActionResult Create()
        {
            ViewBag.AuthorId = new SelectList(db.Users, "Id", "UserName");
            return View();
        }

        // POST: Notices/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [CheckAdmin]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Body,AuthorId,Time")] Notice notice)
        {
            if (ModelState.IsValid)
            {
                db.Notices.Add(notice);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AuthorId = new SelectList(db.Users, "Id", "UserName", notice.AuthorId);
            return View(notice);
        }

        // GET: Notices/Edit/5
        [CheckAdmin]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notice notice = db.Notices.Find(id);
            if (notice == null)
            {
                return HttpNotFound();
            }
            ViewBag.AuthorId = new SelectList(db.Users, "Id", "UserName", notice.AuthorId);
            return View(notice);
        }

        // POST: Notices/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        [CheckAdmin]
        public ActionResult Edit([Bind(Include = "Id,Title,Body,AuthorId,Time")] Notice notice)
        {
            if (ModelState.IsValid)
            {
                db.Entry(notice).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AuthorId = new SelectList(db.Users, "Id", "UserName", notice.AuthorId);
            return View(notice);
        }

        // GET: Notices/Delete/5
        [CheckAdmin]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notice notice = db.Notices.Find(id);
            if (notice == null)
            {
                return HttpNotFound();
            }
            return View(notice);
        }

        // POST: Notices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [CheckAdmin]
        public ActionResult DeleteConfirmed(int id)
        {
            Notice notice = db.Notices.Find(id);
            db.Notices.Remove(notice);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [CheckAdmin]
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
