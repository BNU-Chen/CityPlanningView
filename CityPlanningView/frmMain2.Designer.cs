namespace CityPlanningView
{
    partial class frmMain2
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
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            this.btn_Guihua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Fenxi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xianzhuang = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.galleryControl1 = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).BeginInit();
            this.galleryControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Guihua
            // 
            this.btn_Guihua.Appearance.BackColor = System.Drawing.Color.White;
            this.btn_Guihua.Appearance.Options.UseBackColor = true;
            this.btn_Guihua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_Guihua.Location = new System.Drawing.Point(36, 25);
            this.btn_Guihua.Name = "btn_Guihua";
            this.btn_Guihua.Size = new System.Drawing.Size(92, 36);
            this.btn_Guihua.TabIndex = 0;
            this.btn_Guihua.Text = "规划图";
            this.btn_Guihua.Click += new System.EventHandler(this.btn_Guihua_Click);
            // 
            // btn_Fenxi
            // 
            this.btn_Fenxi.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btn_Fenxi.Appearance.Options.UseBackColor = true;
            this.btn_Fenxi.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_Fenxi.Location = new System.Drawing.Point(134, 25);
            this.btn_Fenxi.Name = "btn_Fenxi";
            this.btn_Fenxi.Size = new System.Drawing.Size(92, 36);
            this.btn_Fenxi.TabIndex = 0;
            this.btn_Fenxi.Text = "分析图";
            this.btn_Fenxi.Click += new System.EventHandler(this.btn_Fenxi_Click);
            // 
            // btn_Xianzhuang
            // 
            this.btn_Xianzhuang.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btn_Xianzhuang.Appearance.Options.UseBackColor = true;
            this.btn_Xianzhuang.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_Xianzhuang.Location = new System.Drawing.Point(232, 25);
            this.btn_Xianzhuang.Name = "btn_Xianzhuang";
            this.btn_Xianzhuang.Size = new System.Drawing.Size(92, 36);
            this.btn_Xianzhuang.TabIndex = 0;
            this.btn_Xianzhuang.Text = "现状图";
            this.btn_Xianzhuang.Click += new System.EventHandler(this.btn_Xianzhuang_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.galleryControl1);
            this.panel1.Location = new System.Drawing.Point(2, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 549);
            this.panel1.TabIndex = 1;
            // 
            // galleryControl1
            // 
            this.galleryControl1.Controls.Add(this.galleryControlClient1);
            this.galleryControl1.DesignGalleryGroupIndex = 0;
            this.galleryControl1.DesignGalleryItemIndex = 0;
            this.galleryControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // galleryControlGallery1
            // 
            this.galleryControl1.Gallery.AllowHoverImages = true;
            galleryItemGroup1.Caption = "Group1";
            this.galleryControl1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.galleryControl1.Gallery.HoverImageSize = new System.Drawing.Size(250, 200);
            this.galleryControl1.Gallery.ImageSize = new System.Drawing.Size(150, 120);
            this.galleryControl1.Gallery.ShowItemText = true;
            this.galleryControl1.Gallery.ItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.galleryControl1_Gallery_ItemClick);
            this.galleryControl1.Location = new System.Drawing.Point(0, 0);
            this.galleryControl1.Name = "galleryControl1";
            this.galleryControl1.Size = new System.Drawing.Size(879, 549);
            this.galleryControl1.TabIndex = 0;
            this.galleryControl1.Text = "galleryControl1";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.galleryControl1;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(858, 545);
            // 
            // frmMain2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 616);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Xianzhuang);
            this.Controls.Add(this.btn_Fenxi);
            this.Controls.Add(this.btn_Guihua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmMain2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "沈阳经济区";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain2_FormClosed);
            this.Load += new System.EventHandler(this.frmMain2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).EndInit();
            this.galleryControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Guihua;
        private DevExpress.XtraEditors.SimpleButton btn_Fenxi;
        private DevExpress.XtraEditors.SimpleButton btn_Xianzhuang;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.Ribbon.GalleryControl galleryControl1;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;

    }
}