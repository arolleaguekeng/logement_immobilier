using Guna.UI2.WinForms;
using LogementImobilier.BLL;
using LogementImobilier.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogementImobilier.Winform
{
    public partial class frmRenting : Form
    {
        Guna2RatingStar star;
        Guna2GradientButton show;
        HousingManager housing;
        List<Housing> housings;
        Panel panel;
        PictureBox picture;
        Label description;
        public frmRenting()
        {
            InitializeComponent();
            housing = new HousingManager();
        }

        private void frmRenting_Load(object sender, EventArgs e)
        {

        }
        private void btnSeach_Click(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            housings = housing.Search(tbSearch.Text, cbbLocation.Text, (int)nudExibition.Value, (int)nudKitchens.Value,
            (int)nudRooms.Value, (int)nudShowers.Value, chbParking.Checked, chbTerasse.Checked, nudPrice.Value, btnStars.Value);
            foreach (var h in housings)
            {
               
                picture = new PictureBox();
                description = new Label();
                panel = new FlowLayoutPanel();
                star = new Guna2RatingStar();
                star.Value = h.NumberStart;
                star.RatingColor = System.Drawing.Color.Gold;
                //add the star
                show = new Guna2GradientButton();
                show.Dock = DockStyle.Bottom;
                show.Text = "More";
                show.Size = new System.Drawing.Size(140, 30);
                flpanel.Controls.Add(panel);
                panel.Controls.Add(picture);
                panel.Controls.Add(star);
                panel.Controls.Add(description);
                panel.Controls.Add(show);
                panel.Size = new System.Drawing.Size(200, 200);
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Size = new Size(new Point(150, 150));
                star.Enabled = false;
                show.Dock = DockStyle.Bottom;
                picture.Dock = DockStyle.Top;
                //picture.Size = new Size(new Point(400, 400));
                description.Dock = DockStyle.Top;
                description.Text = h.Name ;
                description.ForeColor = Color.Red;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;

                

            }
                

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
