using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Filters
{
    public class CheckAdminAttribute:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            if (filterContext.HttpContext.Session == null || filterContext.HttpContext.Session["User"] == null)
            {

                filterContext.HttpContext.Response.Redirect("~/Account/Login");
                
            }
            else
            {
                User u = (User)(filterContext.HttpContext.Session["User"]);
                if (u.RoleId != 1)
                {
                    // filterContext.HttpContext.Response.RedirectToRoute("Account", "Login");
                    filterContext.HttpContext.Response.Write("<script>alert('需要管理员登录')</script>");
                }
            }
            
        }

    }
}