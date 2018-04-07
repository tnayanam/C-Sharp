using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["First"] = "Tanuj"; // Indexer
            //Session["Last"] = "Nayanam"; // Indexer

            //Response.Write(Session["First"]);
            //Response.Write("<br/>");
            //Response.Write(Session["Last"]);

            // User defined Indexer
            Company c1 = new Company();
            //Response.Write("Employee 1 is " + c1[1]);

            //Response.Write("<br/>");
            //Response.Write("Changing name of emp 1");
            //Response.Write("<br/>");
            //c1[1] = "Nesta";
            //Response.Write("Employee 1 is " + c1[1]);
            Response.Write("Number of male are:" + c1["Male"]);
            c1["Male"] = "Female";
            Response.Write("<br/>");
            Response.Write("Number of male are:" + c1["Male"]);
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }

    public class Company
    {
        private List<Employee> _lstEmp { get; set; }

        public Company()
        {
            _lstEmp = new List<Employee>();
            _lstEmp.Add(new Employee { Gender = "Male", Id = 1, Name = "John" });
            _lstEmp.Add(new Employee { Gender = "FeMale", Id = 2, Name = "Reva" });
            _lstEmp.Add(new Employee { Gender = "FeMale", Id = 3, Name = "July" });
            _lstEmp.Add(new Employee { Gender = "FeMale", Id = 4, Name = "Lily" });
            _lstEmp.Add(new Employee { Gender = "Male", Id = 5, Name = "Johnathon" });
            _lstEmp.Add(new Employee { Gender = "FeMale", Id = 6, Name = "Christina" });
            _lstEmp.Add(new Employee { Gender = "Male", Id = 7, Name = "Rick" });
        }

        public string this[int id]
        {
            get
            {
                return _lstEmp.FirstOrDefault(e => e.Id == id).Name.ToString();
            }
            set
            {
                _lstEmp.FirstOrDefault(e => e.Id == id).Name = value;
            }
        }

        public string this[string gender]
        {
            get
            {
                return _lstEmp.Count(emp => emp.Gender == gender).ToString();
            }
            set
            {
                foreach (var emp in _lstEmp)
                {
                    if (emp.Gender == gender)
                        emp.Gender = value;
                }
            }
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

    // OUTPUT
    Number of male are:3
Number of male are:0
 */
