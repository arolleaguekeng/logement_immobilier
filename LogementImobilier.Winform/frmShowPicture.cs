using LogementImobilier.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogementImobilier.Winform
{
    public partial class frmShowPicture : Form
    {
        int n = 0;
        PictureBox boxSingle;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddHouse));
        public List<HousingPicture> LiPicture;
        public frmShowPicture()
        {
            LiPicture = new List<HousingPicture>();
            InitializeComponent();
        }

        private void frmShowPicture_Load(object sender, EventArgs e)
        {
            LiPicture = Program.picture;
            ShowPic(n);
        }

        private void ShowPic(int n)
        {

            boxSingle = new PictureBox();
            this.Controls.Add(boxSingle);
            boxSingle.Image = global::LogementImobilier.Winform.Properties.Resources.wallpaper_meuble;
            boxSingle.Image = ((Image)(resources.GetObject("boxSingle.Image")));
            boxSingle.Dock = DockStyle.Fill;
            boxSingle.SizeMode = PictureBoxSizeMode.StretchImage;
            boxSingle.TabStop = false;
            boxSingle.ImageLocation = Program.picture[n].Title;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            n++;
            if (n >= 0 && n < LiPicture.Count)
            {
                this.Controls.Remove(boxSingle);
                ShowPic(n);
            }
            else
            {
                n = 0;
            }

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            n--;
            if (n >= 0 && n < LiPicture.Count)
            {
                this.Controls.Remove(boxSingle);
                ShowPic(n);
            }
            else
            {
                n = 0;
            }
        }
    }
}
