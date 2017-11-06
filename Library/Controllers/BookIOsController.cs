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
    public class BookIOsController : Controller
    {
        private LibraryContext db = new LibraryContext();

        // GET: BookIOs
        [CheckAdmin]
        public ActionResult Index()
        {
            var bookIOs = db.BookIOs.Include(b => b.Book).Include(b => b.User).OrderByDescending(b=>b.Time);
            return View(bookIOs.ToList());
        }

        // GET: BookIOs/Details/5
        [CheckAdmin]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookIO bookIO = db.BookIOs.Find(id);
            if (bookIO == null)
            {
                return HttpNotFound();
            }
            return View(bookIO);
        }

        // GET: BookIOs/Create
        [CheckAdmin]
        public ActionResult Create()
        {
            ViewBag.BookId = new SelectList(db.Books, "Id", "Name");
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserName");
            return View();
        }

        // POST: BookIOs/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        [CheckAdmin]
        public ActionResult Create([Bind(Include = "Id,Number,BookId")] BookIO bookIO)
        {
            User user=(User)Session["User"];//n0trace
            bookIO.UserId = user.Id;
            bookIO.Time= DateTime.Now;
            if (ModelState.IsValid)
            {
                db.BookIOs.Add(bookIO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BookId = new SelectList(db.Books, "Id", "Name", bookIO.BookId);
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserName", bookIO.UserId);
            return View(bookIO);
        }

        // GET: BookIOs/Edit/5
        [CheckAdmin]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookIO bookIO = db.BookIOs.Find(id);
            if (bookIO == null)
            {
                return HttpNotFound();
            }
            ViewBag.BookId = new SelectList(db.Books, "Id", "Name", bookIO.BookId);
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserName", bookIO.UserId);
            return View(bookIO);
        }

        // POST: BookIOs/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        [CheckAdmin]
        public ActionResult Edit([Bind(Include = "Id,Number,BookId")] BookIO bookIO)
        {
            User user = (User)Session["User"];
            bookIO.UserId = user.Id;
            bookIO.Time = DateTime.Now;

            if (ModelState.IsValid)
            {
                db.Entry(bookIO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BookId = new SelectList(db.Books, "Id", "Name", bookIO.BookId);
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserName", bookIO.UserId);
            return View(bookIO);
        }

        // GET: BookIOs/Delete/5
        [CheckAdmin]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookIO bookIO = db.BookIOs.Find(id);
            if (bookIO == null)
            {
                return HttpNotFound();
            }
            return View(bookIO);
        }

        // POST: BookIOs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [CheckAdmin]
        public ActionResult DeleteConfirmed(int id)
        {
            BookIO bookIO = db.BookIOs.Find(id);
            db.BookIOs.Remove(bookIO);
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
