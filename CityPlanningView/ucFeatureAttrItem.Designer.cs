namespace CityPlanningView
{
    partial class ucFeatureAttrItem
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
            this.lbl_AttrContent = new System.Windows.Forms.Label();
            this.lbl_AttrTitle = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // lbl_AttrContent
            // 
            this.lbl_AttrContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_AttrContent.AutoSize = true;
            this.lbl_AttrContent.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_AttrContent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_AttrContent.Location = new System.Drawing.Point(45, 29);
            this.lbl_AttrContent.Name = "lbl_AttrContent";
            this.lbl_AttrContent.Size = new System.Drawing.Size(56, 13);
            this.lbl_AttrContent.TabIndex = 4;
            this.lbl_AttrContent.Text = "context";
            this.lbl_AttrContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_AttrTitle
            // 
            this.lbl_AttrTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AttrTitle.Appearance.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_AttrTitle.Location = new System.Drawing.Point(29, 8);
            this.lbl_AttrTitle.Name = "lbl_AttrTitle";
            this.lbl_AttrTitle.Size = new System.Drawing.Size(25, 14);
            this.lbl_AttrTitle.TabIndex = 3;
            this.lbl_AttrTitle.Text = "title";
            // 
            // ucFeatureAttrItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_AttrContent);
            this.Controls.Add(this.lbl_AttrTitle);
            this.Name = "ucFeatureAttrItem";
            this.Size = new System.Drawing.Size(130, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AttrContent;
        private DevExpress.XtraEditors.LabelControl lbl_AttrTitle;
    }
}
