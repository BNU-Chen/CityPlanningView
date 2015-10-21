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
using DevExpress.XtraBars.Ribbon;

namespace CityPlanningView
{
    public partial class frmMain3 : Form
    {
        private frmStartPanel frmStart = null;

        private string thumbGuihuaPath = @"E:\项目 - 2014 沈阳经济区\data2\规划地图\规划图";
        private string thumbFenxiPath = @"E:\项目 - 2014 沈阳经济区\data2\规划地图\分析图";
        private string thumbXianzhuangPath = @"E:\项目 - 2014 沈阳经济区\data2\规划地图\现状图";

        public frmMain3(frmStartPanel _frmStart)
        {
            InitializeComponent();
            frmStart = _frmStart;
        }

        private void frmMain3_Load(object sender, EventArgs e)
        {
            LoadPlanningMap();
        }
        private void LoadPlanningMap()
        {
            LoadMapThumb(thumbGuihuaPath, 0);
            LoadMapThumb(thumbFenxiPath, 1);
            LoadMapThumb(thumbXianzhuangPath, 2);

        }
        private void LoadMapThumb(string path,int groupIndex)
        {
            if (!Directory.Exists(path))
            {
                return;
            }
            string pathThumb = path + "\\thumb";
            this.gallery_Main.Gallery.Groups[groupIndex].Items.Clear();

            DirectoryInfo di = new DirectoryInfo(pathThumb);
            FileSystemInfo[] files = di.GetFileSystemInfos();
            for (int i = 0; i < files.Length; i++)
            {
                //如果是文件
                if (files[i] is FileInfo)
                {
                    FileInfo file = files[i] as FileInfo;
                    string ext = file.Extension;                    
                    if (ext.ToLower() != ".jpg")
                    {
                        return;
                    }
                    string title = Path.GetFileNameWithoutExtension(file.FullName);
                    string hoverImgPath = path + "\\hover\\" + file.Name;


                    Image img = Image.FromFile(file.FullName);
                    GalleryItem gi = new GalleryItem();
                    gi.Image = Image.FromFile(file.FullName);
                    if (File.Exists(hoverImgPath))
                    {
                        gi.HoverImage = new Bitmap(hoverImgPath);
                    }
                    gi.Caption = title;
                    gi.Description = title;
                    gi.Tag = path + "\\" + title + ".mxd";

                    this.gallery_Main.Gallery.Groups[groupIndex].Items.Add(gi);
                }
            }
        }

        private void galleryControlGallery1_ItemClick(object sender, GalleryItemClickEventArgs e)
        {
            string mapPath = e.Item.Tag.ToString();
            frmMapMain frmMap = new frmMapMain(this);
            frmMap.MapPath = mapPath;
            frmMap.MapTitle = Path.GetFileNameWithoutExtension(mapPath);
            frmMap.Show();
        }

        private void frmMain3_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmStart != null)
            {
                frmStart.Close();
            }
        }
    }
}
