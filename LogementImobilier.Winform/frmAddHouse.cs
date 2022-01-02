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
using Microsoft.VisualBasic.FileIO;

namespace LogementImobilier.Winform
{
    public partial class frmAddHouse : Form
    {
        string Path;
        PictureBox box;
        frmMessageBox message;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddHouse));
        public List<HousingPicture> LiPicture;

        public frmAddHouse()
        {
            message = new frmMessageBox();
           
            LiPicture = new List<HousingPicture>();
            InitializeComponent();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(LiPicture.Count <=0 )
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
                                                false, client, chbTerasse.Checked, chbParking.Checked, (int)nudLevel.Value, LiPicture,new Saling());



                    housing.CreateHousing(house);

                    timer1.Enabled = true;
                    Program.messagebox = "Added Succesfully";
                    HistoryManager history = new HistoryManager();
                    history.AddHistory(new Historic(DateTime.Now, "Added", house));
                    message.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            message.Close();

        }

        //public int IndexOf(List<HousingPicture> pictures , HousingPicture phousing)
        //{
        //    int n = 0;
        //    for(int i=0; i<pictures.Count;  i++)
        //    {
        //        if (phousing)
        //        {

        //            n = i;
        //        }
        //    }
        //    return n;
        //}
        private void btnAddpicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if(openFile.ShowDialog() == DialogResult.OK)
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
                LiPicture.Add(picture);


            }
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }




        public static void CopyPicture(string sourcePath, string destinationPath)
        {
            sourcePath = @"C:\Users\PHARAON\Pictures\Capture.png";
            FileInfo fileInfo = new FileInfo(destinationPath);
            if (!fileInfo.Directory.Exists)
                fileInfo.Directory.Create();
            FileSystem.CopyDirectory(sourcePath, destinationPath,
                UIOption.AllDialogs);
        }



        // Simple synchronous file copy operations with no user interface.
        // To run this sample, first create the following directories and files:
        // C:\Users\Public\TestFolder
        // C:\Users\Public\TestFolder\test.txt
        // C:\Users\Public\TestFolder\SubDir\test.txt


    }
}
