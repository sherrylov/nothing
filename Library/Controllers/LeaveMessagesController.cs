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
    public class LeaveMessagesController : Controller
    {
        private LibraryContext db = new LibraryContext();

        // GET: LeaveMessages
        [CheckLogin]
        public ActionResult Index()
        {
            var leaveMessages = db.LeaveMessages.OrderByDescending(l=>l.Time).Include(l => l.Author);
            return View(leaveMessages.ToList());
        }

        // GET: LeaveMessages/Details/5
        [CheckLogin]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LeaveMessage leaveMessage = db.LeaveMessages.Find(id);
            if (leaveMessage == null)
            {
                return HttpNotFound();
            }
            return View(leaveMessage);
        }

        // GET: LeaveMessages/Create
        [CheckLogin]
        public ActionResult Create()
        {
            ViewBag.AuthorId = new SelectList(db.Users, "Id", "UserName");
            return View();
        }

        // POST: LeaveMessages/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        [CheckLogin]
        public ActionResult Create([Bind(Include = "Id,Body,AuthorId,Time")] LeaveMessage leaveMessage)
        {
            if (ModelState.IsValid)
            {
                db.LeaveMessages.Add(leaveMessage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AuthorId = new SelectList(db.Users, "Id", "UserName", leaveMessage.AuthorId);
            return View(leaveMessage);
        }

        // GET: LeaveMessages/Edit/5
        [CheckLogin]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LeaveMessage leaveMessage = db.LeaveMessages.Find(id);
            if (leaveMessage == null)
            {
                return HttpNotFound();
            }
            ViewBag.AuthorId = new SelectList(db.Users, "Id", "UserName", leaveMessage.AuthorId);
            return View(leaveMessage);
        }

        // POST: LeaveMessages/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        [CheckLogin]
        public ActionResult Edit([Bind(Include = "Id,Body,AuthorId,Time")] LeaveMessage leaveMessage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(leaveMessage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AuthorId = new SelectList(db.Users, "Id", "UserName", leaveMessage.AuthorId);
            return View(leaveMessage);
        }

        // GET: LeaveMessages/Delete/5
        [CheckLogin]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LeaveMessage leaveMessage = db.LeaveMessages.Find(id);
            if (leaveMessage == null)
            {
                return HttpNotFound();
            }
            return View(leaveMessage);
        }

        // POST: LeaveMessages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [CheckLogin]
        public ActionResult DeleteConfirmed(int id)
        {
            LeaveMessage leaveMessage = db.LeaveMessages.Find(id);
            db.LeaveMessages.Remove(leaveMessage);
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
