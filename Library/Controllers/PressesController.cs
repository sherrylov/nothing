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
    public class PressesController : Controller
    {
        private LibraryContext db = new LibraryContext();

        // GET: Presses
        [CheckAdmin]
        public ActionResult Index()
        {
            return View(db.Presses.ToList());
        }

        // GET: Presses/Details/5
        [CheckAdmin]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Press press = db.Presses.Find(id);
            if (press == null)
            {
                return HttpNotFound();
            }
            return View(press);
        }

        // GET: Presses/Create
        [CheckAdmin]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Presses/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        [CheckAdmin]
        public ActionResult Create([Bind(Include = "Id,Name")] Press press)
        {
            if (ModelState.IsValid)
            {
                db.Presses.Add(press);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(press);
        }

        // GET: Presses/Edit/5
        [CheckAdmin]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Press press = db.Presses.Find(id);
            if (press == null)
            {
                return HttpNotFound();
            }
            return View(press);
        }

        // POST: Presses/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [CheckAdmin]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Press press)
        {
            if (ModelState.IsValid)
            {
                db.Entry(press).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(press);
        }

        // GET: Presses/Delete/5
        [CheckAdmin]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Press press = db.Presses.Find(id);
            if (press == null)
            {
                return HttpNotFound();
            }
            return View(press);
        }

        // POST: Presses/Delete/5
        [CheckAdmin]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Press press = db.Presses.Find(id);
            db.Presses.Remove(press);
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
