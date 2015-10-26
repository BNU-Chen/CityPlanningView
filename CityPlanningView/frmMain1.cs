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
    public partial class frmMain1 : Form
    {
        private string thumbGuihuaPath = @"D:\项目 - 沈阳经济区\data2\规划地图\规划图";
        private string thumbFenxiPath = @"D:\项目 - 沈阳经济区\data2\规划地图\分析图";
        private string thumbXianzhuangPath = @"D:\项目 - 沈阳经济区\data2\规划地图\现状图";

        private Form frmPre = null;

        public frmMain1(Form _frmPre)
        {
            InitializeComponent();
            frmPre = _frmPre;
        }

        private void btn_Guihua_Click(object sender, EventArgs e)
        {
            frmMain3 frm3 = new frmMain3(this);
            frm3.DataPath = thumbGuihuaPath;
            frm3.Show();
        }

        private void btn_Xianzhuang_Click(object sender, EventArgs e)
        {
            frmMain3 frm3 = new frmMain3(this);
            frm3.DataPath = thumbFenxiPath;
            frm3.Show();
        }

        private void btn_Fenxi_Click(object sender, EventArgs e)
        {
            frmMain3 frm3 = new frmMain3(this);
            frm3.DataPath = thumbXianzhuangPath;
            frm3.Show();
        }

        private void frmMain1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmPre != null)
            {
                frmPre.Close();
            }
        }

        private void tabControl1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
