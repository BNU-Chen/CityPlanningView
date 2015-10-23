namespace CityPlanningView
{
    partial class ucMapControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMapControl));
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.lbl_Title = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip_MapTool = new System.Windows.Forms.ToolStrip();
            this.tsbtn_ZoomIn = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_ZoomOut = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_FullExtent = new System.Windows.Forms.ToolStripButton();
            this.pic_Legend = new System.Windows.Forms.PictureBox();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            this.toolStrip_MapTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Legend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(139, 238);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 1;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Location = new System.Drawing.Point(285, 30);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(70, 14);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "labelControl1";
            // 
            // toolStrip_MapTool
            // 
            this.toolStrip_MapTool.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip_MapTool.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip_MapTool.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip_MapTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_ZoomIn,
            this.tsbtn_ZoomOut,
            this.tsbtn_FullExtent});
            this.toolStrip_MapTool.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip_MapTool.Location = new System.Drawing.Point(35, 140);
            this.toolStrip_MapTool.Name = "toolStrip_MapTool";
            this.toolStrip_MapTool.Size = new System.Drawing.Size(37, 147);
            this.toolStrip_MapTool.TabIndex = 4;
            this.toolStrip_MapTool.Text = "toolStrip1";
            // 
            // tsbtn_ZoomIn
            // 
            this.tsbtn_ZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_ZoomIn.Image = global::CityPlanningView.Properties.Resources.zoomIn_32;
            this.tsbtn_ZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_ZoomIn.Name = "tsbtn_ZoomIn";
            this.tsbtn_ZoomIn.Size = new System.Drawing.Size(35, 36);
            this.tsbtn_ZoomIn.Text = "放大";
            // 
            // tsbtn_ZoomOut
            // 
            this.tsbtn_ZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_ZoomOut.Image = global::CityPlanningView.Properties.Resources.zoomOut_32;
            this.tsbtn_ZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_ZoomOut.Name = "tsbtn_ZoomOut";
            this.tsbtn_ZoomOut.Size = new System.Drawing.Size(35, 36);
            this.tsbtn_ZoomOut.Text = "缩小";
            // 
            // tsbtn_FullExtent
            // 
            this.tsbtn_FullExtent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_FullExtent.Image = global::CityPlanningView.Properties.Resources.fullExtent_32;
            this.tsbtn_FullExtent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_FullExtent.Name = "tsbtn_FullExtent";
            this.tsbtn_FullExtent.Size = new System.Drawing.Size(35, 36);
            this.tsbtn_FullExtent.Text = "全图";
            // 
            // pic_Legend
            // 
            this.pic_Legend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Legend.Location = new System.Drawing.Point(561, 366);
            this.pic_Legend.Name = "pic_Legend";
            this.pic_Legend.Size = new System.Drawing.Size(137, 125);
            this.pic_Legend.TabIndex = 2;
            this.pic_Legend.TabStop = false;
            // 
            // axMapControl1
            // 
            this.axMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl1.Location = new System.Drawing.Point(0, 0);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(698, 494);
            this.axMapControl1.TabIndex = 0;
            this.axMapControl1.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl1_OnMouseDown);
            this.axMapControl1.OnMouseUp += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseUpEventHandler(this.axMapControl1_OnMouseUp);
            this.axMapControl1.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl1_OnMouseMove);
            // 
            // ucMapControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip_MapTool);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.pic_Legend);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.axMapControl1);
            this.Name = "ucMapControl";
            this.Size = new System.Drawing.Size(698, 494);
            this.Resize += new System.EventHandler(this.ucMapControl_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.toolStrip_MapTool.ResumeLayout(false);
            this.toolStrip_MapTool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Legend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private System.Windows.Forms.PictureBox pic_Legend;
        private DevExpress.XtraEditors.LabelControl lbl_Title;
        private System.Windows.Forms.ToolStrip toolStrip_MapTool;
        private System.Windows.Forms.ToolStripButton tsbtn_ZoomIn;
        private System.Windows.Forms.ToolStripButton tsbtn_ZoomOut;
        private System.Windows.Forms.ToolStripButton tsbtn_FullExtent;
    }
}
