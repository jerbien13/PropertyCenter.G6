using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ItAcademy.PropertyCenter.Core
{
    public class CultureHelper
    {
        public static readonly List<string> Cultures = new List<string>
        {
            "en-US", // first culture is the DEFAULT

            "fr-FR" // French culture
        };

        public static bool IsRighToLeft
        {
            get { return Thread.CurrentThread.CurrentCulture.TextInfo.IsRightToLeft; }
        }

        public static string DefaultCulture
        {
            get { return Cultures[0]; }
        }

        public static string CurrentCulture
        {
            get { return Thread.CurrentThread.CurrentCulture.Name; }
        }

        public static string CurrentNeutralCulture
        {
            get { return GetNeutralCulture(Thread.CurrentThread.CurrentCulture.Name); }
        }

        public static string GetImplementedCulture(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return DefaultCulture;

            //if (!ValidCultures.Contains(name)) return DefaultCulture;

            if (Cultures.Any(c => c.Equals(name, StringComparison.InvariantCultureIgnoreCase))) return name;

            var neutralCulture = GetNeutralCulture(name);

            foreach (var culture in Cultures)
            {
                if (culture.StartsWith(neutralCulture))
                    return culture;
            }

            return DefaultCulture;
        }

        public static string GetNeutralCulture(string name)
        {
            if (!name.Contains("-")) return name;

            return name.Split('-')[0];
        }
    }
}
