﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using DevExpress.XtraCharts;
using DevExpress.Utils;
using DevExpress.XtraSpreadsheet;
using DevExpress.Spreadsheet;
using DevExpress.Docs;

namespace CityPlanningView
{
    public partial class ucChartAndTableShow : UserControl
    {
        private DataTable dataSource;   //数据源
        private ChartControl chartShowControl;
        private SpreadsheetControl spreadsheetControl;

        public DataTable DataSource    //数据源
        {
            set { this.dataSource = value; }
            get { return this.dataSource; }
        }

        public ucChartAndTableShow()
        {
            InitializeComponent();
            this.icbeChartType.SelectedIndex = getIndexByViewType(ViewType.Bar);
            this.chartShowControl = (ChartControl)this.xtraTabPage_Chart.Controls[0];
            this.spreadsheetControl = (SpreadsheetControl)this.xtraTabPage_Table.Controls[0];
            this.checkPercentShow.Checked = true;
        }

        #region //图表显示设置
        //设置图表显示
        public void SetChartShow(DataTable dt, ViewType vt)
        {
            this.Clear();
            this.DataSource = null;
            this.DataSource = dt.Copy();
            this.icbeChartType.SelectedIndex = getIndexByViewType(vt);
            this.getDataFieldFromDataTable(dt);
            this.checkedDataFields.CheckAll();  
            try
            {
                XYDiagram diagram = (XYDiagram)(this.chartShowControl).Diagram;
                if (diagram != null)
                {
                    diagram.AxisX.GridLines.Visible = false;
                    diagram.AxisY.GridLines.Visible = false;
                }
            }
            catch { }
            this.chartShowControl.Refresh();
        }
        //图表显示控件重置
        private void ResetChartControl()
        {
            try
            {
                chartAddSeries();

                if (getViewTypByIndex(this.icbeChartType.SelectedIndex) == ViewType.Pie)
                    this.checkPercentShow.Visible = true;
                else
                    this.checkPercentShow.Visible = false;

                this.chartShowControl.Legend.Visible = true;
                XYDiagram diagram = (XYDiagram)(this.chartShowControl).Diagram;
                diagram.AxisX.GridLines.Visible = false;
                diagram.AxisY.GridLines.Visible = false;
            }
            catch { }
        }
        //添加数据系列
        private void chartAddSeries()
        {
            try
            {
                DataTable dt = this.dataSource;
                this.chartShowControl.Series.Clear();
                List<object> val_objs = this.checkedDataFields.Properties.Items.GetCheckedValues();
                ViewType vT = this.getViewTypByIndex(this.icbeChartType.SelectedIndex);
                if (vT == ViewType.Pie) val_objs.RemoveRange(1, val_objs.Count - 1);
                foreach (object val_obj in val_objs)
                {
                    string val = val_obj.ToString();
                    if (dt.Columns[val].DataType.Name == "String") continue;
                    Series series = new Series(val, vT);
                    this.chartShowControl.Series.Add(series);
                    series.DataSource = dt;
                    series.ArgumentScaleType = ScaleType.Qualitative;
                    series.ArgumentDataMember = dt.Columns[0].ColumnName.ToString();
                    series.ValueScaleType = ScaleType.Numerical;
                    series.ValueDataMembers.AddRange(new string[] { val });
                    if (vT == ViewType.Pie) settingOfPieChart(series);
                }
            }
            catch { }
        }
        //饼状图数据系列设置
        private void settingOfPieChart(Series ser)
        {
            Series series = ser;
            series.Label.PointOptions.PointView = PointView.ArgumentAndValues;
            if (this.checkPercentShow.Checked)
                series.Label.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent;
            else
                series.Label.PointOptions.ValueNumericOptions.Format = NumericFormat.Scientific;
            series.Label.PointOptions.ValueNumericOptions.Precision = 0;
            ((PieSeriesLabel)series.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;
        }
        //饼状图单击移出事件
        private void chartControl_ObjectSelected(object sender, HotTrackEventArgs e)
        {
            ViewType vT = this.getViewTypByIndex(this.icbeChartType.SelectedIndex);
            try
            {
                if (vT == ViewType.Pie)
                {
                    Series ser = (Series)e.HitInfo.Series;
                    SeriesPoint sp = e.HitInfo.SeriesPoint;

                    bool sp_exploded = false;
                    foreach (SeriesPoint spp in ((PieSeriesView)ser.View).ExplodedPoints)
                    {
                        if (sp == spp) sp_exploded = true;
                    }

                    if (sp_exploded == true) ((PieSeriesView)ser.View).ExplodedPoints.Remove(sp);
                    else if (e.HitInfo.SeriesPoint != null)
                        ((PieSeriesView)ser.View).ExplodedPoints.Add(e.HitInfo.SeriesPoint);
                }
            }
            catch { }
        }
        //清空控件内容
        public void Clear()
        {
            this.chartShowControl.Series.Clear();
            this.chartShowControl.Titles.Clear();
            try
            {
                XYDiagram diagram = (XYDiagram)(this.chartShowControl).Diagram;
                if (diagram != null) diagram.Dispose();
            }
            catch { }
        }
        #endregion

        #region //辅助转换函数
        //根据图表类型获取编号
        private int getIndexByViewType(ViewType vT)
        {
            int index;
            switch (vT)
            {
                case ViewType.Bar:
                    index = 0;
                    break;
                case ViewType.Pie:
                    index = 1;
                    break;
                case ViewType.Line:
                    index = 2;
                    break;
                case ViewType.Point:
                    index = 3;
                    break;
                default:
                    index = 0;
                    break;
            }
            return index;
        }
        //根据编号获取图表类型
        private ViewType getViewTypByIndex(int index)
        {
            ViewType vT;
            switch (index)
            {
                case 0:
                    vT = ViewType.Bar;
                    break;
                case 1:
                    vT = ViewType.Pie;
                    break;
                case 2:
                    vT = ViewType.Line;
                    break;
                case 3:
                    vT = ViewType.Point;
                    break;
                default:
                    vT = ViewType.Bar;
                    break;
            }
            return vT;
        }
        //从数据源获取数据字段
        private void getDataFieldFromDataTable(DataTable dt)
        {
            try
            {
                foreach (DataColumn dc in dt.Columns)
                {
                    //this.cbeAxisXDataField.Properties.Items.Add(dc.ColumnName);
                    decimal val;
                    if (decimal.TryParse(dt.Rows[0][dc.ColumnName].ToString(), out val))
                        this.checkedDataFields.Properties.Items.Add(dc.ColumnName);
                }
            }
            catch { }
        }
        #endregion

        //图表类型变更事件
        private void icbeChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetChartControl();
            this.chartShowControl.Refresh();
        }
        //图表纵轴数据字段变更事件
        private void checkedDataFields_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                List<object> checkedItems = this.checkedDataFields.Properties.Items.GetCheckedValues();
                if (checkedItems.Count == 0) return;
                else ResetChartControl();
            }
            catch { }
        }
        //饼状图数据显示方式，百分比/数据
        private void checkPercentShow_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkPercentShow.Checked == true)
                foreach (Series series in this.chartShowControl.Series)
                    series.Label.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent;
            else
                foreach (Series series in this.chartShowControl.Series)
                    series.Label.PointOptions.ValueNumericOptions.Format = NumericFormat.General;
        }

        private void btnOutPut_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDlg = new SaveFileDialog();
            saveFileDlg.RestoreDirectory = true;
            if (this.xtraTabControl_ChartAndTable.SelectedTabPageIndex == 0)
            {
                saveFileDlg.Filter = "JPG文件（*.jpg）|*.jpg";
                if (saveFileDlg.ShowDialog() == DialogResult.OK)
                {
                    string localFilePath = saveFileDlg.FileName.ToString();
                    this.chartShowControl.ExportToImage(localFilePath, ImageFormat.Jpeg);
                }
            }
            else
            {
                saveFileDlg.Filter = "Excel文件（*.xls）|*.xls";
                if (saveFileDlg.ShowDialog() == DialogResult.OK)
                {
                    string localFilePath = saveFileDlg.FileName.ToString();
                    Worksheet worksheet = this.spreadsheetControl.ActiveWorksheet;
                    Range range = (Range)worksheet.Range;
                    bool rangeHasHeaders = true;
                    //DataTable dataTable = worksheet.CreateDataTable(range, rangeHasHeaders);
                }
            }

            /*
             if (saveFileDlg.ShowDialog() == DialogResult.OK)
                {
                    string localFilePath = saveFileDlg.FileName.ToString();
                    string fileNameExt = Path.GetExtension(localFilePath);
                    switch (fileNameExt)
                    {
                        case ".pdf":
                            this.chartShowControl.ExportToPdf(localFilePath);
                            break;
                        case ".xls":
                            this.chartShowControl.ExportToXls(localFilePath);
                            break;
                        case ".jpg":
                            this.chartShowControl.ExportToImage(localFilePath, ImageFormat.Jpeg);
                            break;
                        case ".png":
                            this.chartShowControl.ExportToImage(localFilePath, ImageFormat.Png);
                            break;
                        case ".tif":
                            this.chartShowControl.ExportToImage(localFilePath, ImageFormat.Tiff);
                            break;
                        case ".bmp":
                            this.chartShowControl.ExportToImage(localFilePath, ImageFormat.Bmp);
                            break;
                        default: break;
                    }
                }
             */
        }

    }
}
