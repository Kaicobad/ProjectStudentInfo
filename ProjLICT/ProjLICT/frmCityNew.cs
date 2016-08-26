using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjLICT
{
    public partial class frmCityNew : Form
    {
        public frmCityNew()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int er = 0;

            string msg = "";

            if (txtName.Text == "") // if (txtName.Text == String.Empty) same as  if (txtName.Text == "")
            {
                er++;
                msg += "Name required\n";
            }

            if (er == 0)
            {

                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = ProjLICT.Properties.Settings.Default.MyCon;
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into city(name) values('" + txtName.Text + "')";
                

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New City is been inserted");
                    txtName.Text = "";
                    txtName.Focus();
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close(); //finally is not mendatory if we just write the code cn.close only it will also work because after all it will com to an end!!
                }
            }
            else
            {
                MessageBox.Show(msg);
            }
        }
    }
}
