namespace CityPlanningView
{
    partial class frmMapMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMapMain));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel_Right = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btn_Description = new System.Windows.Forms.ToolStripButton();
            this.btn_Chart = new System.Windows.Forms.ToolStripButton();
            this.btn_MapContrast = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Home = new System.Windows.Forms.ToolStripButton();
            this.btn_Return = new System.Windows.Forms.ToolStripButton();
            this.btn_Close = new System.Windows.Forms.ToolStripButton();
            this.panel_Home = new System.Windows.Forms.Panel();
            this.panel_Map = new System.Windows.Forms.Panel();
            this.ucMapControl1 = new CityPlanningView.ucMapControl();
            this.panel_Right.SuspendLayout();
            this.panel_Top.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel_Map.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home_services_icon.png");
            // 
            // panel_Right
            // 
            this.panel_Right.Controls.Add(this.panel_Home);
            this.panel_Right.Controls.Add(this.panel_Top);
            this.panel_Right.Controls.Add(this.panel1);
            this.panel_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Right.Location = new System.Drawing.Point(924, 0);
            this.panel_Right.Name = "panel_Right";
            this.panel_Right.Size = new System.Drawing.Size(260, 666);
            this.panel_Right.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CityPlanningView.Properties.Resources.legend;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 538);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 128);
            this.panel1.TabIndex = 5;
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.toolStrip2);
            this.panel_Top.Controls.Add(this.toolStrip1);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(260, 94);
            this.panel_Top.TabIndex = 6;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Description,
            this.btn_Chart,
            this.btn_MapContrast});
            this.toolStrip2.Location = new System.Drawing.Point(0, 47);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(260, 39);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btn_Description
            // 
            this.btn_Description.Image = global::CityPlanningView.Properties.Resources.text;
            this.btn_Description.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Description.Name = "btn_Description";
            this.btn_Description.Size = new System.Drawing.Size(67, 36);
            this.btn_Description.Text = "介绍";
            this.btn_Description.Click += new System.EventHandler(this.btn_Description_Click);
            // 
            // btn_Chart
            // 
            this.btn_Chart.Image = global::CityPlanningView.Properties.Resources.chart1;
            this.btn_Chart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Chart.Name = "btn_Chart";
            this.btn_Chart.Size = new System.Drawing.Size(67, 36);
            this.btn_Chart.Text = "图表";
            this.btn_Chart.Click += new System.EventHandler(this.btn_Chart_Click);
            // 
            // btn_MapContrast
            // 
            this.btn_MapContrast.Image = global::CityPlanningView.Properties.Resources.map;
            this.btn_MapContrast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_MapContrast.Name = "btn_MapContrast";
            this.btn_MapContrast.Size = new System.Drawing.Size(67, 36);
            this.btn_MapContrast.Text = "对比";
            this.btn_MapContrast.Click += new System.EventHandler(this.btn_MapContrast_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Home,
            this.btn_Return,
            this.btn_Close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(260, 47);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Home
            // 
            this.btn_Home.Image = global::CityPlanningView.Properties.Resources.home_black;
            this.btn_Home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(75, 44);
            this.btn_Home.Text = "主页";
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // btn_Return
            // 
            this.btn_Return.Image = global::CityPlanningView.Properties.Resources.return_black;
            this.btn_Return.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(75, 44);
            this.btn_Return.Text = "返回";
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Image = global::CityPlanningView.Properties.Resources.close;
            this.btn_Close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 44);
            this.btn_Close.Text = "关闭";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // panel_Home
            // 
            this.panel_Home.BackColor = System.Drawing.Color.White;
            this.panel_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Home.Location = new System.Drawing.Point(0, 94);
            this.panel_Home.Name = "panel_Home";
            this.panel_Home.Size = new System.Drawing.Size(260, 444);
            this.panel_Home.TabIndex = 7;
            // 
            // panel_Map
            // 
            this.panel_Map.Controls.Add(this.ucMapControl1);
            this.panel_Map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Map.Location = new System.Drawing.Point(0, 0);
            this.panel_Map.Name = "panel_Map";
            this.panel_Map.Size = new System.Drawing.Size(924, 666);
            this.panel_Map.TabIndex = 4;
            // 
            // ucMapControl1
            // 
            this.ucMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMapControl1.Location = new System.Drawing.Point(0, 0);
            this.ucMapControl1.MapPath = "";
            this.ucMapControl1.Name = "ucMapControl1";
            this.ucMapControl1.Size = new System.Drawing.Size(924, 666);
            this.ucMapControl1.TabIndex = 1;
            // 
            // frmMapMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 666);
            this.Controls.Add(this.panel_Map);
            this.Controls.Add(this.panel_Right);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmMapMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "地图标题";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMapMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMapMain_Load);
            this.ResizeEnd += new System.EventHandler(this.frmMapMain_ResizeEnd);
            this.panel_Right.ResumeLayout(false);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel_Map.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel_Right;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btn_Description;
        private System.Windows.Forms.ToolStripButton btn_Chart;
        private System.Windows.Forms.ToolStripButton btn_MapContrast;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Home;
        private System.Windows.Forms.ToolStripButton btn_Return;
        private System.Windows.Forms.ToolStripButton btn_Close;
        private System.Windows.Forms.Panel panel_Home;
        private System.Windows.Forms.Panel panel_Map;
        private ucMapControl ucMapControl1;

    }
}