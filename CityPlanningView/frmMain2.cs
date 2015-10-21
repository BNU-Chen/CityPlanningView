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

using DevExpress.XtraEditors;

namespace CityPlanningView
{
    public partial class frmMain2 : Form
    {
        private frmStartPanel frmStart = null;

        private string thumbGuihuaPath = @"E:\项目 - 2014 沈阳经济区\data2\规划地图\规划图\thumb";
        private string thumbFenxiPath = @"E:\项目 - 2014 沈阳经济区\data2\规划地图\分析图\thumb";
        private string thumbXianzhuangPath = @"E:\项目 - 2014 沈阳经济区\data2\规划地图\现状图\thumb";

        public frmMain2(frmStartPanel _frmStart)
        {
            InitializeComponent();
            frmStart = _frmStart;
        }

        private void frmMain2_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmStart.Close();
        }

        //规划图
        private void btn_Guihua_Click(object sender, EventArgs e)
        {
            LoadMapThumb(thumbGuihuaPath);
            ResetButtons(this.btn_Guihua);
            
        }
        //分析图
        private void btn_Fenxi_Click(object sender, EventArgs e)
        {
            LoadMapThumb(thumbFenxiPath);
            ResetButtons(this.btn_Fenxi);
        }
        //现状图
        private void btn_Xianzhuang_Click(object sender, EventArgs e)
        {
            LoadMapThumb(thumbXianzhuangPath);
            ResetButtons(this.btn_Xianzhuang);
        }

        private void ResetButtons(SimpleButton btnCur)
        {
            this.btn_Guihua.Appearance.BackColor = Color.Silver;
            this.btn_Fenxi.Appearance.BackColor = Color.Silver;
            this.btn_Xianzhuang.Appearance.BackColor = Color.Silver;
            btnCur.Appearance.BackColor = Color.White;
            this.Refresh();
        }

        private void LoadMapThumb(string path)
        {
            if (!Directory.Exists(path))
            {
                return;
            }
            this.flowLayout_Main.Controls.Clear();

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
                    flowLayout_Main.Controls.Add(thumbImage);
                }
            }
        }
    }
}
