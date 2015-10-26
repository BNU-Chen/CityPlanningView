using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;

namespace CityPlanningView
{
    public partial class frmMain3 : Form
    {
        private Form frmStart = null;

        private string dataPath = "";

        public string DataPath
        {
            get { return dataPath; }
            set { dataPath = value; }
        }

        public frmMain3(Form _frm)
        {
            InitializeComponent();
            frmStart = _frm;
            frmStart.Visible = false;
        }

        private void frmMain3_Load(object sender, EventArgs e)
        {
        }

        private void frmMain3_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmStart != null)
            {
                frmStart.Visible = true;
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            LabelControl lbl = (LabelControl)sender;
            string mapPath = dataPath + "\\" + lbl.Text + ".mxd";
            if (!File.Exists(mapPath))
            {
                MessageBox.Show("地图文件不存在.");
                return;
            }
            frmMapMain frmMap = new frmMapMain(this);
            frmMap.MapPath = mapPath;
            frmMap.Show();
        }

        private void labelControl1_MouseEnter(object sender, EventArgs e)
        {
            LabelControl lbl = (LabelControl)sender;
            lbl.BackColor = Color.LightGray;

            PreviewMap(lbl.Text);
        }

        private void labelControl1_MouseLeave(object sender, EventArgs e)
        {
            LabelControl lbl = (LabelControl)sender;
            lbl.BackColor = Color.White;
            RemovePreview();
        }

        private void PreviewMap(string title)
        {
            string picPath = dataPath + "\\thumb\\" + title + ".jpg";
            if (!File.Exists(picPath))
            {
                return;
            }
            this.pictureBox1.BackgroundImage = new Bitmap(picPath);
            this.lbl_preview.Text = title;
        }

        private void RemovePreview()
        {
            this.pictureBox1.BackgroundImage = null;
            this.lbl_preview.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
