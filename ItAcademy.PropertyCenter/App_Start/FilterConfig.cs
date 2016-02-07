using System.Web;
using System.Web.Mvc;
using ItAcademy.PropertyCenter.Filters;

namespace ItAcademy.PropertyCenter
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new MethodCallLogAttribute());
        }
    }
}
