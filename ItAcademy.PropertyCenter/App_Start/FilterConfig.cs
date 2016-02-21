using System;
using System.Web.Mvc;
using ItAcademy.PropertyCenter.Filters;

namespace ItAcademy.PropertyCenter
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new HandleErrorAttribute() { ExceptionType = typeof(ArgumentNullException), View = "AboutError" });
            filters.Add(new MethodCallLogAttribute());
        }
    }
}
