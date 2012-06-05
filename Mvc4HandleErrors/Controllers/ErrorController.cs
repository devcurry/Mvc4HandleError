using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc4HandleErrors.Controllers
{
    public class ErrorController : Controller
    {
        // The 404 action handler
        // Get: /FailWhale/
        public ActionResult FailWhale()
        {
            Response.StatusCode = 404;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }

    }
}
