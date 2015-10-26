namespace CityPlanningView
{
    partial class frmMain1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Xianzhuang = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Fenxi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Guihua = new DevExpress.XtraEditors.SimpleButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(693, 462);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DoubleClick += new System.EventHandler(this.tabControl1_DoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Xianzhuang);
            this.tabPage1.Controls.Add(this.btn_Fenxi);
            this.tabPage1.Controls.Add(this.btn_Guihua);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(685, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "界面1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Xianzhuang
            // 
            this.btn_Xianzhuang.Appearance.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Xianzhuang.Appearance.Options.UseFont = true;
            this.btn_Xianzhuang.Location = new System.Drawing.Point(111, 253);
            this.btn_Xianzhuang.Name = "btn_Xianzhuang";
            this.btn_Xianzhuang.Size = new System.Drawing.Size(170, 77);
            this.btn_Xianzhuang.TabIndex = 1;
            this.btn_Xianzhuang.Text = "现状图";
            this.btn_Xianzhuang.Click += new System.EventHandler(this.btn_Xianzhuang_Click);
            // 
            // btn_Fenxi
            // 
            this.btn_Fenxi.Appearance.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Fenxi.Appearance.Options.UseFont = true;
            this.btn_Fenxi.Location = new System.Drawing.Point(404, 253);
            this.btn_Fenxi.Name = "btn_Fenxi";
            this.btn_Fenxi.Size = new System.Drawing.Size(170, 77);
            this.btn_Fenxi.TabIndex = 2;
            this.btn_Fenxi.Text = "分析图";
            this.btn_Fenxi.Click += new System.EventHandler(this.btn_Fenxi_Click);
            // 
            // btn_Guihua
            // 
            this.btn_Guihua.Appearance.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Guihua.Appearance.Options.UseFont = true;
            this.btn_Guihua.Location = new System.Drawing.Point(261, 106);
            this.btn_Guihua.Name = "btn_Guihua";
            this.btn_Guihua.Size = new System.Drawing.Size(170, 77);
            this.btn_Guihua.TabIndex = 3;
            this.btn_Guihua.Text = "规划图";
            this.btn_Guihua.Click += new System.EventHandler(this.btn_Guihua_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::CityPlanningView.Properties.Resources.QQ图片20151023090353;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(685, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "界面2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::CityPlanningView.Properties.Resources.QQ图片20151023090509;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(685, 436);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "界面3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // frmMain1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 462);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain1_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraEditors.SimpleButton btn_Xianzhuang;
        private DevExpress.XtraEditors.SimpleButton btn_Fenxi;
        private DevExpress.XtraEditors.SimpleButton btn_Guihua;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;

    }
}