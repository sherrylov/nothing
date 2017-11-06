using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Filters
{
    public class CheckLoginAttribute:ActionFilterAttribute
    {
      
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            
            if (filterContext.HttpContext.Session == null || filterContext.HttpContext.Session["User"] == null)
            {
                 //filterContext.HttpContext.Response.Redirect("~/Account/Login");
                filterContext.Result = new RedirectResult("~/Account/Login");
            }
            /*
            else
            {
                base.OnActionExecuting(filterContext);
            }
            */
            
        }
        

    }
}