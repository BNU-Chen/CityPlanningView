namespace CityPlanningView
{
    partial class frmMain3
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
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup2 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup3 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup4 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain3));
            this.gallery_Main = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            ((System.ComponentModel.ISupportInitialize)(this.gallery_Main)).BeginInit();
            this.gallery_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // gallery_Main
            // 
            this.gallery_Main.Controls.Add(this.galleryControlClient1);
            this.gallery_Main.DesignGalleryGroupIndex = 0;
            this.gallery_Main.DesignGalleryItemIndex = 0;
            this.gallery_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // galleryControlGallery1
            // 
            galleryItemGroup1.Caption = "规划图";
            galleryItem1.Caption = "Item2";
            galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1});
            galleryItemGroup2.Caption = "分析图";
            galleryItemGroup3.Caption = "现状图";
            galleryItemGroup4.Caption = "Group4";
            galleryItem2.Caption = "Item3";
            galleryItem2.Description = "asd";
            galleryItem2.HoverImage = ((System.Drawing.Image)(resources.GetObject("galleryItem2.HoverImage")));
            galleryItem2.Image = ((System.Drawing.Image)(resources.GetObject("galleryItem2.Image")));
            galleryItem2.Tag = "zxc";
            galleryItemGroup4.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem2});
            this.gallery_Main.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1,
            galleryItemGroup2,
            galleryItemGroup3,
            galleryItemGroup4});
            this.gallery_Main.Gallery.HoverImageSize = new System.Drawing.Size(150, 120);
            this.gallery_Main.Gallery.ImageSize = new System.Drawing.Size(120, 90);
            this.gallery_Main.Gallery.ShowItemText = true;
            this.gallery_Main.Gallery.ItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.galleryControlGallery1_ItemClick);
            this.gallery_Main.Location = new System.Drawing.Point(0, 0);
            this.gallery_Main.Name = "gallery_Main";
            this.gallery_Main.Size = new System.Drawing.Size(621, 464);
            this.gallery_Main.TabIndex = 0;
            this.gallery_Main.Text = "地图浏览";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.gallery_Main;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 24);
            this.galleryControlClient1.Size = new System.Drawing.Size(600, 438);
            // 
            // frmMain3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 464);
            this.Controls.Add(this.gallery_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmMain3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "沈阳经济区";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain3_FormClosed);
            this.Load += new System.EventHandler(this.frmMain3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gallery_Main)).EndInit();
            this.gallery_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.GalleryControl gallery_Main;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
    }
}