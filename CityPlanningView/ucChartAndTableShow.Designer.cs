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
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            this.xtraTabControl_ChartAndTable = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage_Chart = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage_Table = new DevExpress.XtraTab.XtraTabPage();
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.icbeChartType = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.checkedDataFields = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_ChartAndTable)).BeginInit();
            this.xtraTabControl_ChartAndTable.SuspendLayout();
            this.xtraTabPage_Chart.SuspendLayout();
            this.xtraTabPage_Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbeChartType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedDataFields.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
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
            this.xtraTabPage_Chart.Size = new System.Drawing.Size(394, 239);
            this.xtraTabPage_Chart.Text = "统计图";
            // 
            // xtraTabPage_Table
            // 
            this.xtraTabPage_Table.Controls.Add(this.spreadsheetControl1);
            this.xtraTabPage_Table.Name = "xtraTabPage_Table";
            this.xtraTabPage_Table.Size = new System.Drawing.Size(394, 243);
            this.xtraTabPage_Table.Text = "数据表";
            // 
            // chartControl
            // 
            this.chartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl.Location = new System.Drawing.Point(0, 0);
            this.chartControl.Name = "chartControl";
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            sideBySideBarSeriesLabel1.LineVisible = true;
            this.chartControl.SeriesTemplate.Label = sideBySideBarSeriesLabel1;
            this.chartControl.Size = new System.Drawing.Size(394, 239);
            this.chartControl.TabIndex = 0;
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
            this.icbeChartType.Size = new System.Drawing.Size(62, 20);
            this.icbeChartType.TabIndex = 2;
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
            // 
            // checkEdit1
            // 
            this.checkEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkEdit1.EditValue = true;
            this.checkEdit1.Location = new System.Drawing.Point(271, 276);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "百分比";
            this.checkEdit1.Size = new System.Drawing.Size(58, 19);
            this.checkEdit1.TabIndex = 5;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton1.Location = new System.Drawing.Point(354, 274);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(40, 23);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "导出";
            // 
            // ucChartAndTableShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.checkEdit1);
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
            this.xtraTabPage_Table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbeChartType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedDataFields.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
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
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;

    }
}
