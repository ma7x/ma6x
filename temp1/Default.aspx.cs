using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace temp1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = 111;
        }
        private string GetString()
        {
            /*string constr = System.Configuration.ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
            SqlConnection conn = new SqlConnection(constr);
            //conn.ConnectionString = constr;
            conn.Open();
            string cmdText = "select * from persons";
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            string value = dt.Rows[0][0].ToString();
            cmd.Dispose();
            conn.Close();
            sdr.Close();
            return value;*/
        }
    }
}