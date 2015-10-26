using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityPlanningView
{
    public partial class frmStartPanel : Form
    {
        public frmStartPanel()
        {
            InitializeComponent();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmMain1 frm1 = new frmMain1(this);
            frm1.Show();
            this.Visible = false;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frmMain2 frm2 = new frmMain2(this);
            frm2.Show();
            this.Visible = false;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            frmMain3 frm3 = new frmMain3(this);
            frm3.Show();
            this.Visible = false;
        }
    }
}
