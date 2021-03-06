﻿using System;
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
    public partial class frmMapFeatureAttr : Form
    {

        private DataTable attrDataTable = new DataTable();
        private static int ColorIndex = 0;  //颜色索引

        public frmMapFeatureAttr()
        {
            InitializeComponent();
        }


        public DataTable AttrDataTable
        {
            get { return attrDataTable; }
            set
            {
                attrDataTable = value;
                this.flowLayoutPanel1.Controls.Clear();
                foreach (DataRow dr in attrDataTable.Rows)
                {
                    ucFeatureAttrItem ucItem = new ucFeatureAttrItem();
                    ucItem.AttrTitle = (string)dr["name"];
                    ucItem.AttrContent = (string)dr["value"];
                    ucItem.BackColor = GetRamdonColor();
                    this.flowLayoutPanel1.Controls.Add(ucItem);
                }
                int rowCount = (int)Math.Ceiling(attrDataTable.Rows.Count * 1.0 / 2);
                this.Height = 25 + 58 * rowCount;
            }
        }


        private Color GetRamdonColor()
        {
            Color color = Color.SandyBrown;

            Color color1 = Color.LightSalmon;
            Color color2 = Color.LightSeaGreen;
            Color color3 = Color.MediumSeaGreen;
            Color color4 = Color.MediumPurple;
            Color color5 = Color.Olive;

            int n = ColorIndex % 5;
            switch (n)
            {
                case 0:
                    color = color5;
                    break;
                case 1:
                    color = color1;
                    break;
                case 2:
                    color = color2;
                    break;
                case 3:
                    color = color3;
                    break;
                case 4:
                    color = color4;
                    break;
            }
            ColorIndex++;

            return color;
        }

    }
}
