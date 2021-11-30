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
    public partial class frmEditHousing : Form
    {
        string Path;
        PictureBox box;
        frmMessageBox message;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddHouse));
        public List<HousingPicture> LiPicture;
        public frmEditHousing()
        {
            message = new frmMessageBox();
            LiPicture = new List<HousingPicture>();
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (LiPicture.Count <= 0)
                {
                    MessageBox.Show("Vous devez ajouter des images !");
                }
                else
                {
                    Client client = new Client();
                    frmIndex index = new frmIndex();
                    HousingManager housing = new HousingManager();



                    lbPrice.Text = housing.CalculPrice((int)nudRooms.Value, (int)nudKitchen.Value,
                                    (int)starNotation.Value, (int)nudExibition.Value, (int)nudShowers.Value,
                                    1, (int)nudLevel.Value).ToString();



                    var house = new Housing(tbId.Text, tbName.Text, decimal.Parse(lbPrice.Text), cbbLocation.Text, (int)nudRooms.Value,
                                            (int)nudKitchen.Value, (int)nudShowers.Value, (int)nudExibition.Value, starNotation.Value,
                                                false, client, chbTerasse.Checked, chbParking.Checked, (int)nudLevel.Value, LiPicture);



                    housing.EditHousing(Program.InfoHouse, house);

                    timer1.Enabled = true;
                    Program.messagebox = "Edited Succesfully";
                    HistoryManager history = new HistoryManager();
                    history.AddHistory(new Historic(DateTime.Now, "Edited", house));
                    message.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddpicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                PictureManager pictureManager = new PictureManager();
                int n = 0;
                Path = $"Data/Img/{openFile.SafeFileName}";
                var a = File.ReadAllBytes(openFile.FileName);
                HousingPicture picture = new HousingPicture();
                pictureManager.AddPicture(openFile.FileName, Path);
                box = new PictureBox();
                picture = new HousingPicture(File.ReadAllBytes(openFile.FileName), openFile.FileName);
                box.Image = ((Image)(resources.GetObject("box.Image")));
                box.Name = $"img{n++}";
                box.Size = new Size(100, 100);
                box.SizeMode = PictureBoxSizeMode.StretchImage;
                box.TabStop = false;
                box.ImageLocation = Path;
                box.Cursor = Cursors.Hand;
                this.box.Click += new System.EventHandler(this.box_Click);
                //box.BackColor = Color.Black;
                panelPicture.Controls.Add(box);
                LiPicture.Add(picture);
            }
        }

        private void box_Click(object sender, EventArgs e)
        {
            Program.picture = LiPicture;
            frmShowPicture showPicture = new frmShowPicture();
            showPicture.ShowDialog();

        }

        private void frmEditHousing_Load(object sender, EventArgs e)
        {
            var n = 0;
            var a = Program.picture;
            foreach(var pic in a)
            {
                box = new PictureBox();
                box.Image = ((Image)(resources.GetObject("box.Image")));
                box.Name = $"img{n++}";
                box.Size = new Size(100, 100);
                box.SizeMode = PictureBoxSizeMode.StretchImage;
                box.TabStop = false;
                box.ImageLocation = pic.Title;
                box.Cursor = Cursors.Hand;
                panelPicture.Controls.Add(box);
                LiPicture.Add(pic);
            }

            tbName.Text = Program.InfoHouse.Name;
            tbId.Text = Program.InfoHouse.Id;
            nudExibition.Value = Program.InfoHouse.NumberExibition;
            nudKitchen.Value = Program.InfoHouse.NumberKitchen;
            nudLevel.Value = Program.InfoHouse.NumberOfLevel;
            nudRooms.Value = Program.InfoHouse.NumberRoom;
            nudShowers.Value = Program.InfoHouse.NumberShower;
            starNotation.Value = Program.InfoHouse.NumberStart;
            cbbLocation.SelectedItem = Program.InfoHouse.Location;
            chbParking.Checked = Program.InfoHouse.Parking;
            chbTerasse.Checked = Program.InfoHouse.Terrasse;
        }
    }
}
