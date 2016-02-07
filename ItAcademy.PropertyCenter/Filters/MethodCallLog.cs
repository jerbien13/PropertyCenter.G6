
using System.Diagnostics;
using System.Web.Mvc;

namespace ItAcademy.PropertyCenter.Filters
{
    public class MethodCallLogAttribute : ActionFilterAttribute
    {
        private Stopwatch sw;
        private string methodName;

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            methodName = filterContext.ActionDescriptor.ActionName;
            sw = new Stopwatch();
            sw.Start();
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            sw.Stop();

            Debug.WriteLine("{0} elaped : {1} ms", methodName, sw.ElapsedMilliseconds);
        }
    }
}