using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.Utils;

namespace CityPlanningView
{
    public partial class ucMapThumb : UserControl
    {
        string tooltipStr = "asdlfj";
        private ToolTipController tooltipController = null;

        public string Title
        {
            get
            {
                return this.lbl_title.Text.Trim();
            }
            set
            {
                this.lbl_title.Text = value;
            }
        }

        public PictureBox PictureBox
        {
            get
            {
                return this.picBox_Map;
            }
        }
        public ucMapThumb()
        {
            InitializeComponent();
            tooltipController = new ToolTipController();
            // Customize the controller's settings. 
            tooltipController.Appearance.BackColor = Color.AntiqueWhite;
            //tooltipController.Rounded = true;
            //tooltipController.ShowBeak = true;
            //tooltipController.InitialDelay = 10;
            tooltipController.ShowShadow = true;
            
        }
        
        private void picBox_Map_MouseEnter(object sender, EventArgs e)
        {
            PictureBox picBox = (PictureBox)sender;
            tooltipController.SetToolTip(picBox, Title);
        }

        private void picBox_Map_MouseLeave(object sender, EventArgs e)
        {

        }

        private void picBox_Map_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
    }
}
