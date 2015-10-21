namespace CityPlanningView
{
    partial class ucChartAndTableShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucChartAndTableShow));
            this.xtraTabControl_ChartAndTable = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage_Chart = new DevExpress.XtraTab.XtraTabPage();
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            this.xtraTabPage_Table = new DevExpress.XtraTab.XtraTabPage();
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.icbeChartType = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.icChartTypeImage = new DevExpress.Utils.ImageCollection(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.checkedDataFields = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.checkPercentShow = new DevExpress.XtraEditors.CheckEdit();
            this.btnOutPut = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_ChartAndTable)).BeginInit();
            this.xtraTabControl_ChartAndTable.SuspendLayout();
            this.xtraTabPage_Chart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            this.xtraTabPage_Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbeChartType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icChartTypeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedDataFields.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPercentShow.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl_ChartAndTable
            // 
            this.xtraTabControl_ChartAndTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.xtraTabControl_ChartAndTable.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl_ChartAndTable.Name = "xtraTabControl_ChartAndTable";
            this.xtraTabControl_ChartAndTable.SelectedTabPage = this.xtraTabPage_Chart;
            this.xtraTabControl_ChartAndTable.Size = new System.Drawing.Size(400, 272);
            this.xtraTabControl_ChartAndTable.TabIndex = 0;
            this.xtraTabControl_ChartAndTable.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage_Chart,
            this.xtraTabPage_Table});
            // 
            // xtraTabPage_Chart
            // 
            this.xtraTabPage_Chart.Controls.Add(this.chartControl);
            this.xtraTabPage_Chart.Name = "xtraTabPage_Chart";
            this.xtraTabPage_Chart.Size = new System.Drawing.Size(394, 243);
            this.xtraTabPage_Chart.Text = "统计图";
            // 
            // chartControl
            // 
            this.chartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl.Location = new System.Drawing.Point(0, 0);
            this.chartControl.Name = "chartControl";
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            sideBySideBarSeriesLabel1.LineVisible = true;
            this.chartControl.SeriesTemplate.Label = sideBySideBarSeriesLabel1;
            this.chartControl.Size = new System.Drawing.Size(394, 243);
            this.chartControl.TabIndex = 0;
            this.chartControl.ObjectSelected += new DevExpress.XtraCharts.HotTrackEventHandler(this.chartControl_ObjectSelected);
            // 
            // xtraTabPage_Table
            // 
            this.xtraTabPage_Table.Controls.Add(this.spreadsheetControl1);
            this.xtraTabPage_Table.Name = "xtraTabPage_Table";
            this.xtraTabPage_Table.Size = new System.Drawing.Size(394, 243);
            this.xtraTabPage_Table.Text = "数据表";
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.AllowDrop = true;
            this.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl1.Location = new System.Drawing.Point(0, 0);
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Options.Export.Csv.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl1.Options.Export.Txt.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl1.Options.Export.Txt.ValueSeparator = ',';
            this.spreadsheetControl1.Options.Import.Csv.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl1.Options.Import.ThrowExceptionOnInvalidDocument = false;
            this.spreadsheetControl1.Options.Import.Txt.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl1.Size = new System.Drawing.Size(394, 243);
            this.spreadsheetControl1.TabIndex = 0;
            this.spreadsheetControl1.Text = "spreadsheetControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl1.Location = new System.Drawing.Point(3, 278);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "图表类型：";
            // 
            // icbeChartType
            // 
            this.icbeChartType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.icbeChartType.Location = new System.Drawing.Point(61, 275);
            this.icbeChartType.Name = "icbeChartType";
            this.icbeChartType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbeChartType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("柱状图", "柱状图", 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("饼状图", "饼状图", 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("折线图", "折线图", 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("散点图", "散点图", 3)});
            this.icbeChartType.Properties.LargeImages = this.icChartTypeImage;
            this.icbeChartType.Size = new System.Drawing.Size(62, 20);
            this.icbeChartType.TabIndex = 2;
            this.icbeChartType.SelectedIndexChanged += new System.EventHandler(this.icbeChartType_SelectedIndexChanged);
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
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl2.Location = new System.Drawing.Point(129, 278);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "数据字段：";
            // 
            // checkedDataFields
            // 
            this.checkedDataFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkedDataFields.Location = new System.Drawing.Point(187, 275);
            this.checkedDataFields.Name = "checkedDataFields";
            this.checkedDataFields.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedDataFields.Size = new System.Drawing.Size(78, 20);
            this.checkedDataFields.TabIndex = 4;
            this.checkedDataFields.EditValueChanged += new System.EventHandler(this.checkedDataFields_EditValueChanged);
            // 
            // checkPercentShow
            // 
            this.checkPercentShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkPercentShow.EditValue = true;
            this.checkPercentShow.Location = new System.Drawing.Point(271, 276);
            this.checkPercentShow.Name = "checkPercentShow";
            this.checkPercentShow.Properties.Caption = "百分比";
            this.checkPercentShow.Size = new System.Drawing.Size(58, 19);
            this.checkPercentShow.TabIndex = 5;
            this.checkPercentShow.CheckedChanged += new System.EventHandler(this.checkPercentShow_CheckedChanged);
            // 
            // btnOutPut
            // 
            this.btnOutPut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOutPut.Location = new System.Drawing.Point(354, 274);
            this.btnOutPut.Name = "btnOutPut";
            this.btnOutPut.Size = new System.Drawing.Size(40, 23);
            this.btnOutPut.TabIndex = 6;
            this.btnOutPut.Text = "导出";
            this.btnOutPut.Click += new System.EventHandler(this.btnOutPut_Click);
            // 
            // ucChartAndTableShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOutPut);
            this.Controls.Add(this.checkPercentShow);
            this.Controls.Add(this.checkedDataFields);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.icbeChartType);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.xtraTabControl_ChartAndTable);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "ucChartAndTableShow";
            this.Size = new System.Drawing.Size(400, 300);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_ChartAndTable)).EndInit();
            this.xtraTabControl_ChartAndTable.ResumeLayout(false);
            this.xtraTabPage_Chart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            this.xtraTabPage_Table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icbeChartType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icChartTypeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedDataFields.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPercentShow.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl_ChartAndTable;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage_Chart;
        private DevExpress.XtraCharts.ChartControl chartControl;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage_Table;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbeChartType;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedDataFields;
        private DevExpress.XtraEditors.CheckEdit checkPercentShow;
        private DevExpress.XtraEditors.SimpleButton btnOutPut;
        private DevExpress.Utils.ImageCollection icChartTypeImage;

    }
}
