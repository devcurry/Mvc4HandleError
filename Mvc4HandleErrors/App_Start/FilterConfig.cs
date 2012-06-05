using System.Web;
using System.Web.Mvc;

namespace Mvc4HandleErrors
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleAndLogErrorAttribute());
        }
    }

    public class HandleAndLogErrorAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            // Log the filterContext.Exception details
            base.OnException(filterContext);
        }
    }
}