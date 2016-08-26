using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace ProjLICTWeb
{
    public partial class city_new : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int er = 0;

            if (txtName.Text == "")
            {
                er++;
                lbleName.Text = "Required";
            }
            if (er == 0)
            {

                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = ProjLICTWeb.Properties.Settings.Default.MyCon;
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into city(name) values ('" + txtName.Text + "')";

                try
                {
                    cmd.ExecuteNonQuery();
                    lblMessage.Text = "New city Added";
                    lblMessage.ForeColor = Color.Green;
                    txtName.Text = "";
                    txtName.Focus();
                }
                catch (Exception ex)
                {

                    lblMessage.Text = ex.Message;
                    lblMessage.ForeColor = Color.Red;

                }
                finally
                {
                    cn.Close();
                }

            }

        }
    }
}