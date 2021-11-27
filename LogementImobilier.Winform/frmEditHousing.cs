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
        PictureBox boxSingle;
        List<HousingPicture> images;
        frmMessageBox message;
        string Path;
        PictureBox box;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddHouse));
        public List<HousingPicture> LiPicture;
        public HistoryManager history;
        public frmEditHousing()
        {
            history = new HistoryManager();
            message = new frmMessageBox();
            LiPicture = new List<HousingPicture>();
            images = new List<HousingPicture>();
            InitializeComponent();
        }


        private void box_Click(object sender, EventArgs e)
        {

            //for(int i= 0 ; i<LiPicture.Count; i++ ) 
            //{
            //    int n = 0;
            //    Program.picture = LiPicture;
            //    if (box.ImageLocation == LiPicture[i].Title)
            //    {
            //        Program.PictureIndex = i;
            //        frmShowPicture showPicture = new frmShowPicture();
            //        showPicture.ShowDialog();

            //    }
            //    else
            //    {
            //        n++;
            //    }
            //}
            Program.picture = LiPicture;
            //Program.PictureIndex =  IndexOf(LiPicture,new HousingPicture(box.Name, File.ReadAllBytes(box.ImageLocation),box.ImageLocation));
            frmShowPicture showPicture = new frmShowPicture();
            showPicture.ShowDialog();

        }

        private void frmEditHousing_Load(object sender, EventArgs e)
        {
            tbId.Text = Program.InfoHouse.Id;
            tbName.Text = Program.InfoHouse.Name;
            cbbLocation.SelectedText = Program.InfoHouse.Location;
            nudExibition.Value = Program.InfoHouse.NumberExibition;
            nudKitchen.Value = Program.InfoHouse.NumberKitchen;
            nudLevel.Value = Program.InfoHouse.NumberOfLevel;
            nudRooms.Value = Program.InfoHouse.NumberRoom;
            nudShowers.Value = Program.InfoHouse.NumberShower;
            starNotation.Value = Program.InfoHouse.NumberStart;
            chbTerasse.Checked = Program.InfoHouse.Terrasse;
            chbParking.Checked = Program.InfoHouse.Parking;
            var pictures = Program.InfoHouse.HousingPitctures.ToArray();
            foreach (var pic in pictures)
            {
                images.Add(pic);
                int n = 0;
                boxSingle = new PictureBox();
                boxSingle.Image = ((Image)(resources.GetObject("boxSingle.Image")));
                boxSingle.Name = $"img{n++}";
                boxSingle.Size = new Size(100, 100);
                boxSingle.SizeMode = PictureBoxSizeMode.StretchImage;
                boxSingle.TabStop = false;
                boxSingle.ImageLocation = pic.Title;
                boxSingle.Cursor = Cursors.Hand;
                panelPicture.Controls.Add(boxSingle);

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

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client();
                frmIndex index = new frmIndex();
                HousingManager housing = new HousingManager();



                lbPrice.Text = housing.CalculPrice((int)nudRooms.Value, (int)nudKitchen.Value,
                                (int)starNotation.Value, (int)nudExibition.Value, (int)nudShowers.Value,
                                1, (int)nudLevel.Value).ToString();


                var newHousing = new Housing(tbId.Text, tbName.Text, decimal.Parse(lbPrice.Text), cbbLocation.Text, (int)nudRooms.Value,
                                        (int)nudKitchen.Value, (int)nudShowers.Value, (int)nudExibition.Value, starNotation.Value,
                                            false, client, chbTerasse.Checked, chbParking.Checked, (int)nudLevel.Value, Program.picture);
                housing.EditHousing(Program.InfoHouse, newHousing);

                timer1.Enabled = true;
               Program.messagebox = "Added Succesfully";
                history.AddHistory(new Historic(DateTime.Now, "Edited", newHousing));
                message.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,ex.Source,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnAddpicture_Click_1(object sender, EventArgs e)
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
                lbItems.Text = LiPicture.Count().ToString();
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
                Program.picture.Add(picture);
                

            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            message.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
