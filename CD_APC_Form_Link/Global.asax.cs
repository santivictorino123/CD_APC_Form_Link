using Dexon.module00;
using Dexon.module03.LogonProcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CD_APC_Form_Link
{
    public class MvcApplication : System.Web.HttpApplication
    {

        protected void Application_Start()
        {
            DBConfiguration db = new DBConfiguration()
            {
                dbEngine = "SqlServer",
                dbProvider = "SqlClient",
                dbName = "APCPruebas",
                server = "192.168.1.234",
                useIntegratedAuth = false,
                userName = "sa",
                password = "Colombia10"
            };

            db.Save();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
