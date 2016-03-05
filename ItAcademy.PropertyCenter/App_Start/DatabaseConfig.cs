using ItAcademy.PropertyCenter.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebMatrix.WebData;

namespace ItAcademy.PropertyCenter.App_Start
{
    public class DatabaseConfig
    {
        public static void Configure()
        {
            Database.SetInitializer(new PropertyCenterDbInitializer());

            PropertyCenterDbContext context = new PropertyCenterDbContext();
            context.Database.Initialize(true);

            if (!WebSecurity.Initialized)
            {
                WebSecurity.InitializeDatabaseConnection(PropertyCenterDbContext.ConnectionStringName, "UserProfile", "Id", "UserName", true);
            }
        }
    }
}