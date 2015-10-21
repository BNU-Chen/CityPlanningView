using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;


namespace CityPlanningView
{
    public partial class frmMain1 : Form
    {
        private frmStartPanel frmStart = null;

        private string thumbGuihuaPath = @"E:\项目 - 2014 沈阳经济区\data2\规划地图\规划图\thumb";
        private string thumbFenxiPath = @"E:\项目 - 2014 沈阳经济区\data2\规划地图\分析图\thumb";
        private string thumbXianzhuangPath = @"E:\项目 - 2014 沈阳经济区\data2\规划地图\现状图\thumb";


        public frmMain1(frmStartPanel _frmStart)
        {
            InitializeComponent();
            frmStart = _frmStart;
        }

        private void frmMain1_Load(object sender, EventArgs e)
        {
            LoadPlanningMap();
        }

        private void LoadPlanningMap()
        {
            LoadMapThumb(thumbGuihuaPath, this.flowLayoutPanel_Guihua);
            LoadMapThumb(thumbFenxiPath, this.flowLayoutPanel_Fenxi);
            LoadMapThumb(thumbXianzhuangPath, this.flowLayoutPanel_Xianzhuang);
        
        }

        private void LoadMapThumb(string path, FlowLayoutPanel flow)
        {
            if (!Directory.Exists(path))
            {
                return;
            }
            flow.Controls.Clear();

            DirectoryInfo di = new DirectoryInfo(path);
            FileSystemInfo[] files = di.GetFileSystemInfos();
            for (int i = 0; i < files.Length; i++)
            {
                //如果不是文件
                if (files[i] is FileInfo)
                {
                    FileInfo file = files[i] as FileInfo;
                    string ext = file.Extension;
                    if (ext.ToLower() != ".jpg")
                    {
                        return;
                    }
                    string title = Path.GetFileNameWithoutExtension(file.FullName);

                    ucMapThumb thumbImage = new ucMapThumb();
                    thumbImage.PictureBox.Image = new Bitmap(file.FullName);
                    thumbImage.Title = title;
                    thumbImage.PictureBox.Click += PictureBox_Click;
                    flow.Controls.Add(thumbImage);
                }
            }
            ResizeForm();
        }

        void PictureBox_Click(object sender, EventArgs e)
        {
            frmMapMain frmMap = new frmMapMain(this);
            frmMap.Show();
        }

        private void flowLayoutPanel_Guihua_Resize(object sender, EventArgs e)
        {
            this.groupBox_Guihua.Size = new Size(this.flowLayoutPanel_Guihua.Width + 6, this.flowLayoutPanel_Guihua.Height + 20);
        }

        private void frmMain1_Resize(object sender, EventArgs e)
        {
            ResizeForm();
        }

        private void ResizeForm()
        {
            Control.ControlCollection controls = this.flowLayoutPanel1.Controls;
            foreach (Control ctrl in controls)
            {
                if(ctrl is GroupBox)
                {
                    if (ctrl.Controls.Count == 0)
                    {
                        continue;
                    }
                    Control flowCtrl = ctrl.Controls[0];
                    if(flowCtrl is FlowLayoutPanel)
                    {
                        int mapCount = flowCtrl.Controls.Count;
                        int rowCount = (int)Math.Ceiling((150 + 20) * mapCount * 1.0 / ctrl.Width);
                        ctrl.Height = (120 + 10) * rowCount + 25;
                    }
                }
            }
        }

        private void frmMain1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmStart != null)
            {
                frmStart.Close();
            }
        }

        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {
            int width = this.flowLayoutPanel1.Width - 20;
            this.groupBox_Guihua.Width = width;
            this.groupBox_Fenxi.Width = width;
            this.groupBox_Xianzhuang.Width = width;
        }
    }
}
