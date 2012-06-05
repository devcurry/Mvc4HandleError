using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc4HandleErrors.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to kick-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult ServerSide404(int id)
        {
            this.HttpContext.AddError(new HttpException(404, "Invalid Id - " + id));
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";
            throw new ApplicationException(" Testing Exception Handling Page");
            //return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}
