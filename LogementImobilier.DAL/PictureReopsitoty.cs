using LogementImobilier.BO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogementImobilier.DAL
{
    public class PictureReopsitoty
    {
        public void CopyPicture(string fileName, string targetPath)
        {

            // Use Path class to manipulate file and directory paths.
            // To copy a file to another location and
            // overwrite the destination file if it already exists.

            FileInfo fileInfo = new FileInfo(targetPath);
            if (!fileInfo.Directory.Exists)
                fileInfo.Directory.Create();
            System.IO.File.Copy(fileName, targetPath, true);
        }
        //public void showPicturePanel(List<HousingPicture> pictures, PictureBox box,string path ,HousingPicture picture,FlowLayoutPanel layoutPanel)
        //{
        //    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
        //    OpenFileDialog openFile = new OpenFileDialog();
        //    if (openFile.ShowDialog() == DialogResult.OK)
        //    {
        //        int n = 0;
        //        path = $"Data/Img/{openFile.SafeFileName}";
        //        var a = File.ReadAllBytes(openFile.FileName);
        //        box = new PictureBox();
        //        picture = new HousingPicture(File.ReadAllBytes(openFile.FileName), openFile.FileName);
        //        box.Image = ((Image)(resources.GetObject("box.Image")));
        //        box.Name = $"img{n++}";
        //        box.Size = new Size(100, 100);
        //        box.SizeMode = PictureBoxSizeMode.StretchImage;
        //        box.TabStop = false;
        //        box.ImageLocation = path;
        //        box.Cursor = Cursors.Hand;
        //        //box.BackColor = Color.Black;
        //        layoutPanel.Controls.Add(box);
        //        pictures.Add(picture);

        //    }
        //}
    }
}
