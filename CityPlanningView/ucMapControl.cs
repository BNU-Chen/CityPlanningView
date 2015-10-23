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

        }
    }
}
