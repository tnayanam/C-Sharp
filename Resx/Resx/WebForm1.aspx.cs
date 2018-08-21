using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;
using System.Resources;
using System.Globalization;

namespace Resx
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ResourceManager rm = new ResourceManager("Resx.Resource1",
Assembly.GetExecutingAssembly());
            var t = Assembly.GetExecutingAssembly(); // this gives the resources that are getting loaded
            String strWebsite = rm.GetString("Website", CultureInfo.CurrentCulture);
            String strName = rm.GetString("Name");
            form1.InnerText = "Website: " + strWebsite + "--Name: " + strName;
        }
    }
}