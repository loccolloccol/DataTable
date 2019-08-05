using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataTable
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Name",typeof(string));
            dt.Columns.Add("Age", typeof(Int16));
            dt.Columns.Add("ADDR", typeof(string));
            dt.Columns.Add("MOBILE", typeof(string));
            dt.Columns.Add("Birtyday", typeof(DateTime));
        }
    }
}