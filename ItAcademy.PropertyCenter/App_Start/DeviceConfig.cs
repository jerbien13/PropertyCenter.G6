using System;
using System.Web.WebPages;

namespace ItAcademy.PropertyCenter
{
    public class DeviceConfig
    {
        public const string PhoneDeviceType = "Phone";

        public static void ConfigureDisplayMode()
        {
            DisplayModeProvider.Instance.Modes.Insert(0, new DefaultDisplayMode(PhoneDeviceType)
            {
                ContextCondition = (ctx =>
                    (ctx.GetOverriddenUserAgent() != null) &&
                    (
                        (ctx.GetOverriddenUserAgent().IndexOf("Windows Phone", StringComparison.OrdinalIgnoreCase) >= 0) ||
                        (ctx.GetOverriddenUserAgent().IndexOf("Android", StringComparison.OrdinalIgnoreCase) >= 0) ||
                        (ctx.GetOverriddenUserAgent().IndexOf("iPhone", StringComparison.OrdinalIgnoreCase) >= 0) ||
                        (ctx.GetOverriddenUserAgent().IndexOf("iPod", StringComparison.OrdinalIgnoreCase) >= 0)
                        )
                    )
            });
        }
    }
}