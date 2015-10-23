namespace CityPlanningView
{
    partial class ucChartTableShow
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucChartTableShow));
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            this.spreadsheetControl = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOutPut = new DevExpress.XtraEditors.SimpleButton();
            this.checkPercentShow = new DevExpress.XtraEditors.CheckEdit();
            this.checkedDataFields = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.icbeChartType = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.icChartTypeImage = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkPercentShow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedDataFields.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbeChartType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icChartTypeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl
            // 
            this.chartControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.chartControl.Location = new System.Drawing.Point(0, 0);
            this.chartControl.Name = "chartControl";
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            sideBySideBarSeriesLabel1.LineVisible = true;
            this.chartControl.SeriesTemplate.Label = sideBySideBarSeriesLabel1;
            this.chartControl.Size = new System.Drawing.Size(300, 280);
            this.chartControl.TabIndex = 13;
            // 
            // spreadsheetControl
            // 
            this.spreadsheetControl.AllowDrop = true;
            this.spreadsheetControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl.Location = new System.Drawing.Point(0, 280);
            this.spreadsheetControl.Name = "spreadsheetControl";
            this.spreadsheetControl.Options.Export.Csv.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl.Options.Export.Txt.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl.Options.Export.Txt.ValueSeparator = ',';
            this.spreadsheetControl.Options.Import.Csv.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl.Options.Import.ThrowExceptionOnInvalidDocument = false;
            this.spreadsheetControl.Options.Import.Txt.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl.Size = new System.Drawing.Size(300, 320);
            this.spreadsheetControl.TabIndex = 14;
            this.spreadsheetControl.Text = "spreadsheetControl1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOutPut);
            this.panel1.Controls.Add(this.checkPercentShow);
            this.panel1.Controls.Add(this.checkedDataFields);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.icbeChartType);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 565);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 35);
            this.panel1.TabIndex = 15;
            // 
            // btnOutPut
            // 
            this.btnOutPut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOutPut.Location = new System.Drawing.Point(244, 7);
            this.btnOutPut.Name = "btnOutPut";
            this.btnOutPut.Size = new System.Drawing.Size(40, 23);
            this.btnOutPut.TabIndex = 18;
            this.btnOutPut.Text = "导出";
            this.btnOutPut.Click += new System.EventHandler(this.btnOutPut_Click);
            // 
            // checkPercentShow
            // 
            this.checkPercentShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkPercentShow.EditValue = true;
            this.checkPercentShow.Location = new System.Drawing.Point(207, 9);
            this.checkPercentShow.Name = "checkPercentShow";
            this.checkPercentShow.Properties.Caption = "%";
            this.checkPercentShow.Size = new System.Drawing.Size(58, 19);
            this.checkPercentShow.TabIndex = 17;
            this.checkPercentShow.CheckedChanged += new System.EventHandler(this.checkPercentShow_CheckedChanged);
            // 
            // checkedDataFields
            // 
            this.checkedDataFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkedDataFields.Location = new System.Drawing.Point(149, 8);
            this.checkedDataFields.Name = "checkedDataFields";
            this.checkedDataFields.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedDataFields.Size = new System.Drawing.Size(50, 20);
            this.checkedDataFields.TabIndex = 16;
            this.checkedDataFields.EditValueChanged += new System.EventHandler(this.checkedDataFields_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl2.Location = new System.Drawing.Point(116, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "数据：";
            // 
            // icbeChartType
            // 
            this.icbeChartType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.icbeChartType.Location = new System.Drawing.Point(69, 8);
            this.icbeChartType.Name = "icbeChartType";
            this.icbeChartType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbeChartType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("柱状图", "柱状图", 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("饼状图", "饼状图", 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("折线图", "折线图", 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("散点图", "散点图", 3)});
            this.icbeChartType.Properties.LargeImages = this.icChartTypeImage;
            this.icbeChartType.Size = new System.Drawing.Size(40, 20);
            this.icbeChartType.TabIndex = 14;
            this.icbeChartType.SelectedIndexChanged += new System.EventHandler(this.icbeChartType_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl1.Location = new System.Drawing.Point(11, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "图表类型：";
            // 
            // icChartTypeImage
            // 
            this.icChartTypeImage.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icChartTypeImage.ImageStream")));
            this.icChartTypeImage.InsertGalleryImage("bar_16x16.png", "images/chart/bar_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/chart/bar_16x16.png"), 0);
            this.icChartTypeImage.Images.SetKeyName(0, "bar_16x16.png");
            this.icChartTypeImage.InsertGalleryImage("pie_16x16.png", "images/chart/pie_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/chart/pie_16x16.png"), 1);
            this.icChartTypeImage.Images.SetKeyName(1, "pie_16x16.png");
            this.icChartTypeImage.InsertGalleryImage("line_16x16.png", "images/chart/line_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/chart/line_16x16.png"), 2);
            this.icChartTypeImage.Images.SetKeyName(2, "line_16x16.png");
            this.icChartTypeImage.InsertGalleryImage("point_16x16.png", "images/chart/point_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/chart/point_16x16.png"), 3);
            this.icChartTypeImage.Images.SetKeyName(3, "point_16x16.png");
            // 
            // ucChartTableShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.spreadsheetControl);
            this.Controls.Add(this.chartControl);
            this.MinimumSize = new System.Drawing.Size(300, 600);
            this.Name = "ucChartTableShow";
            this.Size = new System.Drawing.Size(300, 600);
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkPercentShow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedDataFields.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbeChartType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icChartTypeImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnOutPut;
        private DevExpress.XtraEditors.CheckEdit checkPercentShow;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedDataFields;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbeChartType;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.ImageCollection icChartTypeImage;
    }
}
