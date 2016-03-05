﻿using System.Web.Optimization;

namespace ItAcademy.PropertyCenter
{
    public class BundleMobileConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquerymobile")
                .Include("~/Scripts/jquery.mobile-{version}.js"));
            
            bundles.Add(new StyleBundle("~/Content/jquerymobile/css")
                .Include("~/Content/jquery.mobile-{version}.css"));
        }
    }
}