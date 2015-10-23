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
    }
}

