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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = GetString();
        }
        private string GetString()
        {
            string constr = System.Configuration.ConfigurationManager.ConnectionStrings["connstr1"].ConnectionString;
            SqlConnection conn = new SqlConnection(constr);
            //conn.ConnectionString = constr;
            conn.Open();
            string cmdText = "select * from persons";
            //string cmdText = "insert into persons ( Id_P )  values (120)";
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            //SqlDataReader sdr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(sdr);
            //string value = dt.Rows[0][0].ToString();

            SqlDataReader sdr = cmd.ExecuteReader();
            string value = "";
            if (sdr.Read()) {
                value= sdr.GetString(sdr.GetOrdinal("LastName"));
            }

            cmd.Dispose();
            conn.Close();
            sdr.Close();
            return value;
        }
    }
}