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
    public partial class frmMapMain : Form
    {
        private Control ctrl = null;

        
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
        public string MapTitle
        {
            get
            {
                return this.Text;
            }
            set
            {
                this.Text = value;
            }
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
                this.ucMapControl1.MapPath = value;
            }
        }
        #endregion


    }
}
