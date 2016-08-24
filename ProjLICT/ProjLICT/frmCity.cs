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
    public partial class frmCity : Form
    {
        public frmCity()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmCityNew cityNew = new frmCityNew();
            cityNew.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            System.Data.SqlClient.SqlConnection cn = new System.Data.SqlClient.SqlConnection();
            cn.ConnectionString = ProjLICT.Properties.Settings.Default.MyCon;
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = " select id, name from city";


            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            cn.Close();

            dgvData.DataSource = ds.Tables[0];

            this.Cursor = Cursors.Default;
        }
    }
}
