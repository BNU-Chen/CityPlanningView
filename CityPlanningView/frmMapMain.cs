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

namespace CityPlanningView
{
    public partial class frmMapMain : Form
    {
        private Control ctrl = null;
        private DataTable dt = new DataTable();

        //uc
        private ucMapDescription ucDesc = new ucMapDescription();
        private ucChartAndTableShow ucChart = new ucChartAndTableShow();
        private ucMapContrast ucContrast = new ucMapContrast();

        public frmMapMain(Control _ctrl)
        {
            InitializeComponent();
            ctrl = _ctrl;
            ctrl.Visible = false;
        }

        private void frmMapMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            ctrl.Visible = true;
        }


        #region //封装变量
        private string mapFolder = "";

        public string MapFolder
        {
            get { return mapFolder; }
        }
        private string mapPath = "";
        public string MapPath
        {
            get
            {
                return mapPath;
            }
            set
            {
                string path = value;
                if (!File.Exists(path))
                {
                    return;
                }
                this.ucMapControl1.MapPath = value;
                string title = Path.GetFileNameWithoutExtension(value);
                this.Text = title;
                //Folder
                mapFolder = Path.GetDirectoryName(value);
            }
        }
        #endregion

        private void frmMapMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Close();
            ctrl.Visible = true;
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {

        }

        //介绍
        private void btn_Description_Click(object sender, EventArgs e)
        {
            this.panel_Home.Controls.Clear();
            ucDesc.Dock = DockStyle.Fill;
            this.panel_Home.Controls.Add(ucDesc);
        }

        private void btn_Chart_Click(object sender, EventArgs e)
        {
            dt.Columns.Add("区域",typeof(string));
            dt.Columns.Add("数据", typeof(int));

            DataRow dr1 = dt.NewRow();
            dr1["区域"] = "沈阳";
            dr1["数据"] = 100;
            dt.Rows.Add(dr1);

            DataRow dr2 = dt.NewRow();
            dr2["区域"] = "沈阳";
            dr2["数据"] = 100;
            dt.Rows.Add(dr2);

            DataRow dr3 = dt.NewRow();
            dr3["区域"] = "沈阳";
            dr3["数据"] = 100;
            dt.Rows.Add(dr3);

            DataRow dr4 = dt.NewRow();
            dr4["区域"] = "沈阳";
            dr4["数据"] = 100;
            dt.Rows.Add(dr4);

            this.panel_Home.Controls.Clear();
            ucChart.Dock = DockStyle.Fill;
            this.panel_Home.Controls.Add(ucChart);
        }

        private void btn_MapContrast_Click(object sender, EventArgs e)
        {
            this.panel_Home.Controls.Clear();
            ucContrast.Dock = DockStyle.Fill;
            ucContrast.DataPath = mapFolder;
            this.panel_Home.Controls.Add(ucContrast);
        }

        private void frmMapMain_ResizeEnd(object sender, EventArgs e)
        {
            
        }


    }
}
