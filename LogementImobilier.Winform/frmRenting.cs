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
        FlowLayoutPanel panel;
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
                
                show = new Guna2GradientButton();
                flpanel.Controls.Add(panel);
                panel.Controls.Add(picture);
                panel.Controls.Add(star);
                panel.Controls.Add(description);
                panel.Controls.Add(show);
                
                star.Value = h.NumberStart;


                star.BorderColor = System.Drawing.Color.Purple;
                star.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
                star.Name = "btnStars";
                star.RatingColor = System.Drawing.Color.Gold;
                star.Size = new System.Drawing.Size(95, 95);










                picture.Dock = DockStyle.Top;
                
                show.Dock = DockStyle.Bottom;
                show.Text = "show";
                description.Dock = DockStyle.Left;
                description.Text = h.Name ;
                description.ForeColor = Color.Red;
                panel.BorderStyle = BorderStyle.FixedSingle;

                panel.Size = new Size(new Point(150, 150));
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                

            }
                

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
