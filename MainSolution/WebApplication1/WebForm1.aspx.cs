using System;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["First"] = "Tanuj"; // Indexer
            Session["Last"] = "Nayanam"; // Indexer

            Response.Write(Session["First"]);
            Response.Write("<br/>");
            Response.Write(Session["Last"]);
        }
    }
}

/* 
 * This is provided by Framework, which we are using above
 *     //
        // Summary:
        //     Gets or sets a session value by numerical index.
        //
        // Parameters:
        //   index:
        //     The numerical index of the session value.
        //
        // Returns:
        //     The session-state value stored at the specified index, or null if the item does
        //     not exist.
        public object this[int index] { get; set; }
        //
        // Summary:
        //     Gets or sets a session value by name.
        //
        // Parameters:
        //   name:
        //     The key name of the session value.
        //
        // Returns:
        //     The session-state value with the specified name, or null if the item does not
        //     exist.
        public object this[string name] { get; set; }
 */
