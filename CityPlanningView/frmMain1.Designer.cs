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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox_Xianzhuang = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel_Xianzhuang = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox_Fenxi = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel_Fenxi = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox_Guihua = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel_Guihua = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox_Xianzhuang.SuspendLayout();
            this.groupBox_Fenxi.SuspendLayout();
            this.groupBox_Guihua.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.groupBox_Fenxi);
            this.flowLayoutPanel1.Controls.Add(this.groupBox_Xianzhuang);
            this.flowLayoutPanel1.Controls.Add(this.groupBox_Guihua);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(937, 717);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Resize += new System.EventHandler(this.flowLayoutPanel1_Resize);
            // 
            // groupBox_Xianzhuang
            // 
            this.groupBox_Xianzhuang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Xianzhuang.Controls.Add(this.flowLayoutPanel_Xianzhuang);
            this.groupBox_Xianzhuang.Location = new System.Drawing.Point(3, 203);
            this.groupBox_Xianzhuang.Name = "groupBox_Xianzhuang";
            this.groupBox_Xianzhuang.Size = new System.Drawing.Size(890, 117);
            this.groupBox_Xianzhuang.TabIndex = 5;
            this.groupBox_Xianzhuang.TabStop = false;
            this.groupBox_Xianzhuang.Text = "现状图";
            // 
            // flowLayoutPanel_Xianzhuang
            // 
            this.flowLayoutPanel_Xianzhuang.AutoScroll = true;
            this.flowLayoutPanel_Xianzhuang.AutoSize = true;
            this.flowLayoutPanel_Xianzhuang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Xianzhuang.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanel_Xianzhuang.Name = "flowLayoutPanel_Xianzhuang";
            this.flowLayoutPanel_Xianzhuang.Size = new System.Drawing.Size(884, 97);
            this.flowLayoutPanel_Xianzhuang.TabIndex = 0;
            // 
            // groupBox_Fenxi
            // 
            this.groupBox_Fenxi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Fenxi.Controls.Add(this.flowLayoutPanel_Fenxi);
            this.groupBox_Fenxi.Location = new System.Drawing.Point(3, 3);
            this.groupBox_Fenxi.Name = "groupBox_Fenxi";
            this.groupBox_Fenxi.Size = new System.Drawing.Size(890, 194);
            this.groupBox_Fenxi.TabIndex = 4;
            this.groupBox_Fenxi.TabStop = false;
            this.groupBox_Fenxi.Text = "分析图";
            // 
            // flowLayoutPanel_Fenxi
            // 
            this.flowLayoutPanel_Fenxi.AutoScroll = true;
            this.flowLayoutPanel_Fenxi.AutoSize = true;
            this.flowLayoutPanel_Fenxi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Fenxi.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanel_Fenxi.Name = "flowLayoutPanel_Fenxi";
            this.flowLayoutPanel_Fenxi.Size = new System.Drawing.Size(884, 174);
            this.flowLayoutPanel_Fenxi.TabIndex = 0;
            // 
            // groupBox_Guihua
            // 
            this.groupBox_Guihua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Guihua.Controls.Add(this.flowLayoutPanel_Guihua);
            this.groupBox_Guihua.Location = new System.Drawing.Point(3, 326);
            this.groupBox_Guihua.Name = "groupBox_Guihua";
            this.groupBox_Guihua.Size = new System.Drawing.Size(890, 162);
            this.groupBox_Guihua.TabIndex = 6;
            this.groupBox_Guihua.TabStop = false;
            this.groupBox_Guihua.Text = "规划";
            // 
            // flowLayoutPanel_Guihua
            // 
            this.flowLayoutPanel_Guihua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Guihua.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanel_Guihua.Name = "flowLayoutPanel_Guihua";
            this.flowLayoutPanel_Guihua.Size = new System.Drawing.Size(884, 142);
            this.flowLayoutPanel_Guihua.TabIndex = 0;
            // 
            // frmMain1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(949, 741);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmMain1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "沈阳经济区";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain1_FormClosed);
            this.Load += new System.EventHandler(this.frmMain1_Load);
            this.Resize += new System.EventHandler(this.frmMain1_Resize);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox_Xianzhuang.ResumeLayout(false);
            this.groupBox_Xianzhuang.PerformLayout();
            this.groupBox_Fenxi.ResumeLayout(false);
            this.groupBox_Fenxi.PerformLayout();
            this.groupBox_Guihua.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox_Xianzhuang;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Xianzhuang;
        private System.Windows.Forms.GroupBox groupBox_Fenxi;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Fenxi;
        private System.Windows.Forms.GroupBox groupBox_Guihua;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Guihua;


    }
}