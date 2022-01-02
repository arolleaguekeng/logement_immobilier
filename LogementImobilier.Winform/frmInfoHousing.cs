using LogementImobilier.BLL;
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
    public partial class frmInfoHousing : Form
    {
        PictureBox boxSingle;
        DateTime endDate;
        HousingManager manager;
        List<HousingPicture> images;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddHouse));
        public frmInfoHousing()
        {
            endDate = new DateTime();
            manager = new HousingManager();
            images = new List<HousingPicture>();
            InitializeComponent();
        }

        private void frmInfoHousing_Load(object sender, EventArgs e)
        {
            //afficher la date actuelle
            dtStartDate.Value = DateTime.Now;
            //remplissage des informations sur la maison
            lbHouseName.Text = Program.InfoHouse.Name;
            lbPrice.Text = Program.InfoHouse.Price.ToString() ;
            lbLocation.Text = Program.InfoHouse.Location.ToString();
            lbExibition.Text= Program.InfoHouse.NumberExibition.ToString();
            lbKitchen.Text = Program.InfoHouse.NumberKitchen.ToString();
            lbLevel.Text = Program.InfoHouse.NumberOfLevel.ToString();
            lbRoom.Text = Program.InfoHouse.NumberRoom.ToString();
            lbShower.Text = Program.InfoHouse.NumberShower.ToString();
            lbStar.Text = Program.InfoHouse.NumberStart.ToString();
            lbParking.Text = Program.InfoHouse.Parking.ToString();
            lbTerrasse.Text = Program.InfoHouse.Terrasse.ToString();
            lbUsed.Text = Program.InfoHouse.Used.ToString();

            // recuperation et affichage des images dans le panel
            var pictures = Program.InfoHouse.HousingPitctures.ToArray();
            foreach(var pic in pictures)
            {
                images.Add(pic);
                int n = 0;
                boxSingle = new PictureBox();
                boxSingle.Image = ((Image)(resources.GetObject("boxSingle.Image")));
                boxSingle.Name = $"img{n++}";
                boxSingle.Size = new Size(400, 250);
                boxSingle.SizeMode = PictureBoxSizeMode.StretchImage;
                boxSingle.TabStop = false;
                boxSingle.ImageLocation = pic.Title;
                boxSingle.Cursor = Cursors.Hand;
                panelRight.Controls.Add(boxSingle);

                this.boxSingle.Click += new System.EventHandler(this.boxSingle_Click);
                //box.BackColor = Color.Black;
                
            }
            Program.picture = images;
        }
        private void boxSingle_Click(object sender, EventArgs e)
        {
            frmShowPicture showPicture = new frmShowPicture();
            showPicture.Show();
        }
            private void btnCose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSale_Click_1(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client(tbClientEmail.Text, tbClientName.Text,int.Parse(tbClientPhoneNumber.Text));
                var houseSale =Program.InfoHouse;
                Saling saling = new Saling(dtStartDate.Value, dtEndDate.Value);
                manager.SaleHousing(Program.InfoHouse, houseSale, client, saling);
                frmFacture facture = new frmFacture();
                facture.Show();
                MessageBox.Show("Sale succes !");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditHousing editHousing = new frmEditHousing();
            editHousing.Show();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            var houseSale = Program.InfoHouse;
            manager.LeaveHousing(Program.InfoHouse, houseSale, client);
        }
    }
}
