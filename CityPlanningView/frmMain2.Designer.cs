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
            this.btn_Guihua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Fenxi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xianzhuang = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayout_Main = new System.Windows.Forms.FlowLayoutPanel();
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
            // flowLayout_Main
            // 
            this.flowLayout_Main.AutoScroll = true;
            this.flowLayout_Main.Location = new System.Drawing.Point(36, 68);
            this.flowLayout_Main.Name = "flowLayout_Main";
            this.flowLayout_Main.Size = new System.Drawing.Size(826, 536);
            this.flowLayout_Main.TabIndex = 1;
            // 
            // frmMain2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 616);
            this.Controls.Add(this.flowLayout_Main);
            this.Controls.Add(this.btn_Xianzhuang);
            this.Controls.Add(this.btn_Fenxi);
            this.Controls.Add(this.btn_Guihua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmMain2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "沈阳经济区";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain2_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Guihua;
        private DevExpress.XtraEditors.SimpleButton btn_Fenxi;
        private DevExpress.XtraEditors.SimpleButton btn_Xianzhuang;
        private System.Windows.Forms.FlowLayoutPanel flowLayout_Main;

    }
}