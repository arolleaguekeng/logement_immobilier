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
        HousingManager housing;
        Label description;
        Guna2RatingStar star;
        Guna2Button more;
        List<Housing> housings;
        List<Housing> SeachinHousing;
        FlowLayoutPanel layoutPanel;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddHouse));
        public frmRenting()
        {


            InitializeComponent();
            SeachinHousing = new List<Housing>();
            housing = new HousingManager();
            frmHome frmHome = new frmHome();
            housings = housing.GetAllHousing();
            ShowHousings(housings);
            // ShowLvHousing();
        }

        private void frmRenting_Load(object sender, EventArgs e)
        {
            //cbbLocation.SelectedIndex = 0;
           

        }

        private void layoutPanel_MouseUp(object sender, EventArgs e)
        {
            layoutPanel.BackColor = Color.LightSkyBlue;
        }
        private void ShowHousings(List<Housing> housings)
        {
            int n = 0;
            foreach (var house in housings)
            {
                string name = $"label{n++}";
                string nameButton = $"button{n++}";
                //option du panel conteneur
                var Picture = new PictureBox();
                layoutPanel = new FlowLayoutPanel();
                layoutPanel.BorderStyle = BorderStyle.FixedSingle;
                layoutPanel.Size = new Size(170, 320);
                layoutPanel.Cursor = Cursors.Hand;
                layoutPanel.MouseUp += new MouseEventHandler(layoutPanel_MouseUp);
                layoutPanel.BackColor = Color.White;

                panelcontein.Controls.Add(layoutPanel);
                Picture = new PictureBox();
                Picture.Name = "pic";
                Picture.Image = ((Image)(resources.GetObject("Picture.Image")));
                Picture.Size = new Size(100, 100);
                Picture.SizeMode = PictureBoxSizeMode.StretchImage;
                Picture.TabStop = false;
                Picture.ImageLocation = house.HousingPitctures[0].Title;
                Picture.BackColor = Color.Black;
                
                layoutPanel.Controls.Add(Picture);

                //affichage de la description

                NewLabel(house, name, house.Name);
                NewLabel(house, name, house.Location);
                NewLabel(house, name, "Room:     " + house.NumberRoom.ToString());
                NewLabel(house, name, "SHW:      " + house.NumberShower.ToString());
                NewLabel(house, name, "Price:  " + house.Price.ToString());
                NewLabel(house, name, "Use:     " + house.Used.ToString());


                //affichage de l'image d'icone de la maison dans 



                //afficher les étoiles de la maison
                star = new Guna2RatingStar();
                layoutPanel.Controls.Add(star);
                star.BorderColor = System.Drawing.SystemColors.MenuHighlight;
                star.Name = "starNotation";
                star.RatingColor = System.Drawing.Color.Gold;
                //star.Size = new System.Drawing.Size(124, 33);



                //affcihage du bouton plus d'information 

                more = new Guna2Button();
                layoutPanel.Controls.Add(more);
                more.Text = "More";
                more.Name = nameButton;
                more.Click += new System.EventHandler(more_Click);

                more.Tag = house;


            }
        }


        private void more_Click(object sender, EventArgs e)
        {
            Guna2Button more = (Guna2Button)sender;
            frmInfoHousing infoHousing = new frmInfoHousing();
            Program.InfoHouse = more.Tag as Housing;
            infoHousing.ShowDialog();
        }


        private static void ShowHousingInfo(Housing housing)
        {
            frmInfoHousing infoHousing = new frmInfoHousing();
            Program.InfoHouse = housing;
            infoHousing.ShowDialog();
        }

        //fonction qui ajoute un label dans le formulaire
        private void NewLabel(Housing house,string name,string text)
        {
            description = new Label();
            description.Text = text;
            description.ForeColor = Color.Black;
            description.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            description.ForeColor = System.Drawing.Color.Black;
            description.Name = name;
            description.Size = new System.Drawing.Size(400, 20);
            layoutPanel.Controls.Add(description);
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
            FindShow();
            //MessageBox.Show("loc:\n"+cbbLocation.SelectedItem.ToString() + "exib:\n"+nudExibition.Value.ToString() + "kit:\n" + (int)nudKitchens.Value+
            //    "rooms:\n" + (int)nudRooms.Value + "showers:\n" + (int)nudShowers.Value + "P:\n" + chbParking.Checked.ToString() + "T:\n" + chbTerasse.Checked + "Price:\n" + nudPrice.Value + "star:\n" + btnStars.Value);
        }

        private void FindShow()
        {
            SeachinHousing = housing.GetAllHousing();
            try
            {
                SeachinHousing = housing.Search(cbbLocation.SelectedItem.ToString(), (int)nudExibition.Value, (int)nudKitchens.Value,
                    (int)nudRooms.Value, (int)nudShowers.Value, chbParking.Checked, chbTerasse.Checked, nudPrice.Value, btnStars.Value);
                panelcontein.Controls.Clear();
                ShowHousings(SeachinHousing);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }

        }


        //private void ShowLvHousing()
        //{
        //    foreach (var house in housings)
        //    {
        //        var Lvi = new ListViewItem(new string[] { house.Location, house.Name, house.NumberOfLevel.ToString(),house.NumberShower.ToString(),
        //        house.NumberExibition.ToString(),house.NumberKitchen.ToString(),house.Parking.ToString(),house.NumberOfLevel.ToString(),house.Price.ToString(),house.Used.ToString()});
        //        Lvi.Tag = house;
        //        lvShowHousing.Items.Add(Lvi);
        //    }
        //}


        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            //housings = housing.SearchName(tbSearch.Text);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbSearch_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void cbbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindShow();
        }

        private void nudKitchens_ValueChanged(object sender, EventArgs e)
        {
            FindShow();
        }

        private void nudRooms_ValueChanged(object sender, EventArgs e)
        {
            FindShow();
        }

        private void nudShowers_ValueChanged(object sender, EventArgs e)
        {
            FindShow();
        }

        private void nudExibition_ValueChanged(object sender, EventArgs e)
        {
            FindShow();
        }

        private void btnStars_ValueChanged(object sender, EventArgs e)
        {
            FindShow();
        }

        private void nudPrice_ValueChanged(object sender, EventArgs e)
        {
            FindShow();
        }

        private void btnClose_Click_3(object sender, EventArgs e)
        {
            panelRight.Visible = false;
            btnSee.Visible = true;
            


        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            btnSee.Visible = false;
            panelRight.Visible = true;
            panelRight.Dock = DockStyle.Right;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panelRight.Visible = false;
            btnSee.Visible = true;
        }
        public static Housing hous;

        //private void lvShowHousing_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    frmInfoHousing infoHousing = new frmInfoHousing();
        //    Program.InfoHouse = lvShowHousing.SelectedItems[0].Tag as Housing;
        //    infoHousing.ShowDialog();
        //}
        //private void populate()
        //{
        //    lvShowHousing.View = View.Details;
        //    lvShowHousing.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        //    ImageList imageList = new ImageList();
        //    imageList.ImageSize = new Size(100,100);

        //    string[] paths = { };
        //    try
        //    {
        //        foreach(var path in housings)
        //        {
        //            imageList.Images.Add(Image.FromFile(@"C:\Users\PHARAON\Pictures\Capture.png"));
        //        }
        //    }
        //    catch(Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }
        //    lvShowHousing.SmallImageList = imageList;

        //}

    }
}
