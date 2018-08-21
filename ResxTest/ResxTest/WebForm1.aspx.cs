using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Resources;
using System.Globalization;
using System.Threading;
using System.Reflection;

namespace ResxTest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ResourceManager rm;
        CultureInfo ci;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Lang"] == null)
            {
                Session["Lang"] = Request.UserLanguages[0]; // if nothing is set lets set the system default culture.
            }

            if (!IsPostBack)
            {
                LoadString();
            }
        }

        private void LoadString()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(Session["Lang"].ToString()); // to the current thread lets set the culture provided by user dropdown
            rm = new ResourceManager("ResxTest.App_GlobalResources.Lang", Assembly.GetExecutingAssembly()); // Add the resources to the executing assemblies so that they are included in the project
            ci = Thread.CurrentThread.CurrentCulture; // get the culture the user is in.

            lblName.Text = rm.GetString("Name", ci); // now fetch the values
            lblAddress.Text = rm.GetString("Address", ci);
            lblState.Text = rm.GetString("State", ci);
            lblCountry.Text = rm.GetString("Country", ci);
            btnSave.Text = rm.GetString("Save", ci);
            btnCancel.Text = rm.GetString("Cancel", ci);
        }
        protected void ddLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["Lang"] = ddLang.SelectedValue;
            LoadString();
        }
    }
}
// Link: http://www.dotnetawesome.com/2014/06/how-to-create-multilingual-application-aspnet.html
// the resource file properties needs to be in "Embedded Resource".
