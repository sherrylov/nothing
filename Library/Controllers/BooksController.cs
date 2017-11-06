using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Library.Models;
using System.Collections;
using Library.Filters;

namespace Library.Controllers
{
    public class BooksController : Controller
    {
        private LibraryContext db = new LibraryContext();

        // GET: Books
        [CheckLogin]
        public ActionResult Index(string sortOreder, string searchString)
        {
            var CategoryList = new List<string>();
            var Categories = from c in db.Categories
                             orderby c.Name
                             select c.Name;
            CategoryList.Add("All");
            CategoryList.AddRange(Categories);

            ViewBag.sortOreder = new SelectList(CategoryList);
            var tushu = from u in db.Books                        
                        select u;
            if (!String.IsNullOrEmpty(searchString))
            {
                tushu = tushu.Where(u => u.Name.Contains(searchString));
            }
            if (!String.IsNullOrEmpty(sortOreder))
            {
                if (sortOreder != "All")
                {
                    tushu = tushu.Where(x => x.Category.Name == sortOreder);
                }
            }
            return View(tushu.ToList());
        }
        //public ActionResult Index(string sortOreder, string searchString)
        //{
        //    var tushu = from u in db.Books
        //                select u;
        //    //ViewBag.classList = listClass;
        //    ViewBag.NameSortParm = string.IsNullOrEmpty(sortOreder) ? "name_desc" : "";

        //    if (!string.IsNullOrEmpty(searchString))
        //    {
        //        tushu = tushu.Where(u => u.Name.Contains(searchString));
        //    }
        //    switch (sortOreder)
        //    {
        //        case "name_desc":
        //            tushu = tushu.OrderByDescending(u => u.Name);
        //            break;
        //        default:
        //            tushu = tushu.OrderBy(u => u.Name);
        //            break;
        //    }
        //    return View(tushu.ToList());
        //}

        // GET: Books/Details/5
        [CheckLogin]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // GET: Books/Create
        [CheckLogin]
        [CheckAdmin]
        public ActionResult Create()
        {
            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "Name");
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name");
            ViewBag.PressId = new SelectList(db.Presses, "Id", "Name");
            return View();
        }

        // POST: Books/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        [CheckLogin]
        [CheckAdmin]
        public ActionResult Create([Bind(Include = "Id,Name,PubDate,Price,Number,AuthorId,CategoryId,PressId")] Book book)
        {
            if (ModelState.IsValid)
            {
                db.Books.Add(book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "Name", book.AuthorId);
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", book.CategoryId);
            ViewBag.PressId = new SelectList(db.Presses, "Id", "Name", book.PressId);
            return View(book);
        }


        //public ActionResult Borrow()
        //{

        //    int id = Request.QueryString["id"] == null ? 0 : int.Parse(Request.QueryString["id"].ToString());
        //    BorrowBook borrowbook = new BorrowBook();

        //    borrowbook.Time = DateTime.Now;
        //    User user = (User)Session["User"];
        //    borrowbook.UserId = user.Id;
        //    borrowbook.Type = true;
        //    borrowbook.BookId = id;

        //    db.BorrowBooks.Add(borrowbook);
        //    db.SaveChanges();

        //    return RedirectToAction("Index");
        //}


        // GET: Books/Edit/5
        [CheckLogin]
        [CheckAdmin]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "Name", book.AuthorId);
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", book.CategoryId);
            ViewBag.PressId = new SelectList(db.Presses, "Id", "Name", book.PressId);
            return View(book);
        }

        // POST: Books/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        [CheckLogin]
        [CheckAdmin]
        public ActionResult Edit([Bind(Include = "Id,Name,PubDate,Price,Number,AuthorId,CategoryId,PressId")] Book book)
        {
            if (ModelState.IsValid)
            {
                db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "Name", book.AuthorId);
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", book.CategoryId);
            ViewBag.PressId = new SelectList(db.Presses, "Id", "Name", book.PressId);
            return View(book);
        }



        // GET: Books/Delete/5
        [CheckLogin]
        [CheckAdmin]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [CheckLogin]
        [CheckAdmin]
        public ActionResult DeleteConfirmed(int id)
        {
            Book book = db.Books.Find(id);
            db.Books.Remove(book);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [CheckLogin]
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
