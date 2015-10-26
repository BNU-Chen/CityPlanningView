using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityPlanningView
{
    public partial class ucFeatureAttrItem : UserControl
    {
        //设置标题
        public string AttrTitle
        {
            get { return this.lbl_AttrTitle.Text; }
            set { this.lbl_AttrTitle.Text = value; }
        }

        //设置内容
        public string AttrContent
        {
            get { return this.lbl_AttrContent.Text; }
            set { this.lbl_AttrContent.Text = value; }
        }

        public ucFeatureAttrItem()
        {
            InitializeComponent();
        }
    }
}
