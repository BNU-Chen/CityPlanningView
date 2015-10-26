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
    public partial class ucMapContrast : UserControl
    {
        
        public ucMapContrast()
        {
            InitializeComponent();
        }
        private string dataPath = "";

        public string DataPath
        {
            get { return dataPath; }
            set
            {
                dataPath = value;
                string map1 = dataPath + "\\8 国土开发战略格局图.mxd";
                string map2 = dataPath + "\\12 城市开发边界图.mxd";
                if (File.Exists(map1))
                {
                    this.axMapControl1.LoadMxFile(map1);
                }
                if (File.Exists(map2))
                {
                    this.axMapControl2.LoadMxFile(map2);
                }
            }
        }

        public AxMapControl Map1
        {
            get
            {
                return this.axMapControl1;
            }
        }

        public AxMapControl Map2
        {
            get
            {
                return this.axMapControl2;
            }
        }

        #region //MapControl事件
        private void axMapControl1_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {
            AxMapControl MapControl = (AxMapControl)sender;
            if (e.button == 4)
            {
                MapControl.ActiveView.ScreenDisplay.PanStart(axMapControl1.ActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(e.x, e.y));
                MapControl.MousePointer = esriControlsMousePointer.esriPointerPan;
            }
        }

        private void axMapControl1_OnMouseMove(object sender, IMapControlEvents2_OnMouseMoveEvent e)
        {
            AxMapControl MapControl = (AxMapControl)sender;
            if (e.button == 4 && axMapControl1.ActiveView != null)
            {
                MapControl.ActiveView.ScreenDisplay.PanMoveTo(axMapControl1.ActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(e.x, e.y));
            }
        }

        private void axMapControl1_OnMouseUp(object sender, IMapControlEvents2_OnMouseUpEvent e)
        {
            AxMapControl MapControl = (AxMapControl)sender;
            if (e.button == 4 && axMapControl1.ActiveView != null)   //中键
            {
                MapControl.MousePointer = esriControlsMousePointer.esriPointerArrow;
                MapControl.ActiveView.ScreenDisplay.PanStop();
                MapControl.ActiveView.Refresh();
            }
        }

        #endregion
    }
}

