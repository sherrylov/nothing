using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class AccountController : Controller
    {
        private LibraryContext db = new LibraryContext();

        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login", "Account");
        }
        public ActionResult Register()
        {
            ViewBag.Sex = new List<SelectListItem>() {
                new SelectListItem(){Value="男",Text="男"},
                new SelectListItem(){Value="女",Text="女"}
            };
            ViewBag.CulturalLevel = new List<SelectListItem>() {
                new SelectListItem(){Value="大学",Text="大学"},
                new SelectListItem(){Value="高中",Text="高中"},
                new SelectListItem(){Value="初中",Text="初中"},
                new SelectListItem(){Value="小学",Text="小学"},
                new SelectListItem(){Value="博士",Text="博士"},
                new SelectListItem(){Value="研究生",Text="研究生"},
            };
            ViewBag.RoleId = new SelectList(db.Roles, "Id", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            var item = db.Users.FirstOrDefault(u => u.UserName == user.UserName && u.PassWord == user.PassWord);
            if (item != null)
            {
                Session["User"] = item;
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Login Error");
            return View(user);

        }
        [HttpPost]
     
        public ActionResult Register([Bind(Include = "UserName,Sex,Age,CulturalLevel,Email,PassWord")] User user)
        {
            ViewBag.Sex = new List<SelectListItem>() {
                new SelectListItem(){Value="男",Text="男"},
                new SelectListItem(){Value="女",Text="女"}
            };
            ViewBag.CulturalLevel = new List<SelectListItem>() {
                new SelectListItem(){Value="大学",Text="大学"},
                new SelectListItem(){Value="高中",Text="高中"},
                new SelectListItem(){Value="初中",Text="初中"},
                new SelectListItem(){Value="小学",Text="小学"},
                new SelectListItem(){Value="博士",Text="博士"},
                new SelectListItem(){Value="研究生",Text="研究生"},
            };
            ViewBag.RoleId = new SelectList(db.Roles, "Id", "Name");
            if (ModelState.IsValid)
            {
                if (db.Users.FirstOrDefault(u => u.UserName == user.UserName) != null)
                {
                    ModelState.AddModelError("", "This UserName has exits");
                    return View(user);
                }
                Role role=db.Roles.FirstOrDefault(r => r.Name == "普通用户");
                user.Role = role;
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Login", "Account");
            }
            return View(user);
        }
    }
}