using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;


namespace SidewalkUI.Filters
{
    public class MenuFilter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var rd = filterContext.RequestContext.RouteData;
            var action = rd.GetRequiredString("action");
            var controller = rd.GetRequiredString("controller");
            //if (action == "Index" && controller == "Home")
            //    filterContext.HttpContext.Session["HomePage"] = true;
            //else if (action == "GetAllAffidavit" && controller == "Home")
            //    filterContext.HttpContext.Session["HomePage"] = true;
            //else if (action == "GetAllTrackIT" && controller == "Home")
            //    filterContext.HttpContext.Session["HomePage"] = true;
            //else
                filterContext.HttpContext.Session["HomePage"] = false;
            base.OnActionExecuting(filterContext);
        }
    }
}