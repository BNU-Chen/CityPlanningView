namespace CityPlanningView
{
    partial class ucMapThumb
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
            this.picBox_Map = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Map)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_Map
            // 
            this.picBox_Map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox_Map.Location = new System.Drawing.Point(3, 3);
            this.picBox_Map.Name = "picBox_Map";
            this.picBox_Map.Size = new System.Drawing.Size(144, 94);
            this.picBox_Map.TabIndex = 0;
            this.picBox_Map.TabStop = false;
            this.picBox_Map.Click += new System.EventHandler(this.picBox_Map_Click);
            this.picBox_Map.MouseEnter += new System.EventHandler(this.picBox_Map_MouseEnter);
            this.picBox_Map.MouseLeave += new System.EventHandler(this.picBox_Map_MouseLeave);
            this.picBox_Map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox_Map_MouseMove);
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(3, 102);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(41, 12);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "label1";
            // 
            // ucMapThumb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.picBox_Map);
            this.Name = "ucMapThumb";
            this.Size = new System.Drawing.Size(150, 120);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Map)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_Map;
        private System.Windows.Forms.Label lbl_title;
    }
}
