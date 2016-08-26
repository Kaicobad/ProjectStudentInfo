using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ProjLICTWeb
{
    public partial class city : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = ProjLICTWeb.Properties.Settings.Default.MyCon;
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = " select id, name from city where admin = 0";


            if (txtSearch.Text != "")
            {
                cmd.CommandText += " and name like '%" + txtSearch.Text + "%' ";
            }


            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            cn.Close();

            dgvData.DataSource = ds.Tables[0];
            dgvData.DataBind();
        }
    }
}