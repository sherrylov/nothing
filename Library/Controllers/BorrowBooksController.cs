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
    public class BorrowBooksController : Controller
    {
        private LibraryContext db = new LibraryContext();

        // GET: BorrowBooks
        [CheckLogin]
        public ActionResult Index()
        {
            var borrowBooks = db.BorrowBooks.Include(b => b.Book).Include(b => b.User);
            return View(borrowBooks.ToList());
        }

        // GET: BorrowBooks/Details/5
        [CheckLogin]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BorrowBook borrowBook = db.BorrowBooks.Find(id);
            if (borrowBook == null)
            {
                return HttpNotFound();
            }
            return View(borrowBook);
        }

        // GET: BorrowBooks/Create
        [CheckLogin]
        public ActionResult Create()
        {
            ViewBag.BookId = new SelectList(db.Books, "Id", "Name");
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserName");
            return View();
        }

        // POST: BorrowBooks/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        //[ValidateAntiForgeryToken]
        [CheckLogin]
        public ActionResult Create([Bind(Include = "Id,Type,UserId,BookId")] BorrowBook borrowBook)
        {

            borrowBook.Time = DateTime.Now;
        

            if (ModelState.IsValid)
            {
                db.BorrowBooks.Add(borrowBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BookId = new SelectList(db.Books, "Id", "Name", borrowBook.BookId);
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserName", borrowBook.UserId);
            return View(borrowBook);
        }

        // GET: BorrowBooks/Edit/5
        [CheckLogin]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BorrowBook borrowBook = db.BorrowBooks.Find(id);
            if (borrowBook == null)
            {
                return HttpNotFound();
            }
            ViewBag.BookId = new SelectList(db.Books, "Id", "Name", borrowBook.BookId);
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserName", borrowBook.UserId);
            return View(borrowBook);
        }

        // POST: BorrowBooks/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        [CheckLogin]
        public ActionResult Edit([Bind(Include = "Id,Time,Type,UserId,BookId")] BorrowBook borrowBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(borrowBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BookId = new SelectList(db.Books, "Id", "Name", borrowBook.BookId);
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserName", borrowBook.UserId);
            return View(borrowBook);
        }

        // GET: BorrowBooks/Delete/5
        [CheckLogin]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BorrowBook borrowBook = db.BorrowBooks.Find(id);
            if (borrowBook == null)
            {
                return HttpNotFound();
            }
            return View(borrowBook);
        }

        // POST: BorrowBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        [CheckLogin]
        public ActionResult DeleteConfirmed(int id)
        {
            BorrowBook borrowBook = db.BorrowBooks.Find(id);
            db.BorrowBooks.Remove(borrowBook);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [CheckLogin]
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
