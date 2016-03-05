using System;
using System.Globalization;
using System.Threading;
using System.Web.Mvc;

namespace ItAcademy.PropertyCenter.Core
{
    public class LocalizableController : Controller
    {
        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            var culture = Session["culture"] as string;
            
            if (culture == null) culture = CultureHelper.DefaultCulture;

            Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            return base.BeginExecuteCore(callback, state);
        }
    }
}
