using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjLICT
{
    public partial class frmMain : Form
    {
        frmCity city = new frmCity();
        frmUnit unit = new frmUnit();
        frmCatagory catagory = new frmCatagory();
        frmBrand brand = new frmBrand();
        frmProduct product = new frmProduct();

        public frmMain()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblWatch.Text = "Date And Time :" + DateTime.Now.ToString();
        
        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (city.IsDisposed)
                city = new frmCity();

            city.BringToFront();
            city.Show();
            city.MdiParent = this;
        }

        private void unitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (unit.IsDisposed)
                unit = new frmUnit();

            unit.BringToFront();
            unit.Show();
            unit.MdiParent = this;
        }

        private void catagoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (catagory.IsDisposed)
                catagory = new frmCatagory();

            catagory.BringToFront();
            catagory.Show();
            catagory.MdiParent = this;
        }

        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (brand.IsDisposed)
                brand = new frmBrand();

            brand.BringToFront();
            brand.Show();
            brand.MdiParent = this;
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (brand.IsDisposed)
                brand = new frmBrand();

            product.BringToFront();
            product.Show();
            product.MdiParent = this;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
