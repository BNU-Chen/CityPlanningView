using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using ESRI.ArcGIS.Controls;

namespace CityPlanningView
{
    public partial class ucMapControl : UserControl
    {

        public ucMapControl()
        {
            InitializeComponent();
        }

        public AxMapControl MapControl
        {
            get
            {
                return this.axMapControl1;
            }
        }
        
        //地图路径
        private string mapPath = "";
        public string MapPath
        {
            get { return mapPath; }
            set
            {
                mapPath = value;
                if (File.Exists(mapPath))
                {
                    //加载地图
                    this.axMapControl1.LoadMxFile(mapPath);
                    this.axMapControl1.Refresh();
                    //设置标题
                    string title = Path.GetFileNameWithoutExtension(mapPath);
                    this.lbl_Title.Text = title;
                    //图例
                    //string parentDir = Path.GetDirectoryName(mapPath);
                    //string legendPath = parentDir+"\\legend.jpg";
                    //this.pic_Legend.BackgroundImage = new Bitmap(legendPath);
                }
            }
        }

        private void ucMapControl_Resize(object sender, EventArgs e)
        {
            int x = (this.Width - this.lbl_Title.Width) / 2;
            this.lbl_Title.Location = new Point(x, 20);

            int y = (this.Height - this.toolStrip_MapTool.Height) / 2;
            this.toolStrip_MapTool.Location = new Point(20, y);
        }

        #region //MapControl事件
        private void axMapControl1_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {
            if (e.button == 4)
            {
                axMapControl1.ActiveView.ScreenDisplay.PanStart(axMapControl1.ActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(e.x, e.y));
                axMapControl1.MousePointer = esriControlsMousePointer.esriPointerPan;
            }
        }

        private void axMapControl1_OnMouseMove(object sender, IMapControlEvents2_OnMouseMoveEvent e)
        {
            if (e.button == 4 && axMapControl1.ActiveView != null)
            {
                axMapControl1.ActiveView.ScreenDisplay.PanMoveTo(axMapControl1.ActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(e.x, e.y));
            }
        }

        private void axMapControl1_OnMouseUp(object sender, IMapControlEvents2_OnMouseUpEvent e)
        {
            if (e.button == 4 && axMapControl1.ActiveView != null)   //中键
            {
                axMapControl1.MousePointer = esriControlsMousePointer.esriPointerArrow;
                axMapControl1.ActiveView.ScreenDisplay.PanStop();
                axMapControl1.ActiveView.Refresh();
            }
        }

        #endregion

        private void axMapControl1_OnDoubleClick(object sender, IMapControlEvents2_OnDoubleClickEvent e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("value", typeof(string));

            DataRow dr = dt.NewRow();
            dr["name"] = "行政区";
            dr["value"] = "沈阳";
            dt.Rows.Add(dr);

            DataRow dr2 = dt.NewRow();
            dr2["name"] = "面积";
            dr2["value"] = "1234.345";
            dt.Rows.Add(dr2);

            DataRow dr3 = dt.NewRow();
            dr3["name"] = "交通轨道长度";
            dr3["value"] = "1235.223";
            dt.Rows.Add(dr3);

            DataRow dr4 = dt.NewRow();
            dr4["name"] = "GDP总量";
            dr4["value"] = "234345";
            dt.Rows.Add(dr4);

            Control control = (Control)sender;
            System.Drawing.Point pt = control.PointToScreen(new System.Drawing.Point(e.x, e.y));
            frmMapFeatureAttr pFrmMapFeatureAttr = new frmMapFeatureAttr();
            pFrmMapFeatureAttr.AttrDataTable = dt;
            pFrmMapFeatureAttr.Location = pt;
            pFrmMapFeatureAttr.Show();
        }
    }
}
