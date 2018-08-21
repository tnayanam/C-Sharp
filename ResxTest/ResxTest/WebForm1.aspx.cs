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
                Session["Lang"] = Request.UserLanguages[0];
            }

            if (!IsPostBack)
            {
                LoadString();
            }
        }

        private void LoadString()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(Session["Lang"].ToString());
            rm = new ResourceManager("ResxTest.App_GlobalResources.Lang", Assembly.GetExecutingAssembly());
            ci = Thread.CurrentThread.CurrentCulture;

            lblName.Text = rm.GetString("Name", ci);
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
