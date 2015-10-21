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
        private string mapPath = "";

        public string MapPath
        {
            get { return mapPath; }
            set
            {
                mapPath = value;
                if (File.Exists(mapPath))
                {
                    this.axMapControl1.LoadMxFile(mapPath);
                    this.axMapControl1.Refresh();
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
    }
}
