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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddHouse));
        public List<HousingPicture> LiPicture;

        public frmAddHouse()
        {
           
            LiPicture = new List<HousingPicture>();
            InitializeComponent();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client();
                frmIndex index = new frmIndex();
                HousingManager housing = new HousingManager();



                lbPrice.Text =   housing.CalculPrice((int)nudRooms.Value, (int)nudKitchen.Value,
                                (int)starNotation.Value, (int)nudExibition.Value, (int)nudShowers.Value,
                                1,(int )nudLevel.Value).ToString();

                        
                housing.CreateHousing(new Housing(tbId.Text, tbName.Text, decimal.Parse(lbPrice.Text), cbbLocation.Text, (int)nudRooms.Value,
                                        (int)nudKitchen.Value, (int)nudShowers.Value, (int)nudExibition.Value, starNotation.Value,
                                            false, client, chbTerasse.Checked, chbParking.Checked,(int) nudLevel.Value, LiPicture));

                timer1.Enabled = true;
                panelMessage.Visible = true;
                lbMessages.Text = "Added Succesfully";
            }
            catch (Exception)
            {
                throw new Exception("Faild to Add");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelMessage.Visible = false;
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
                int n = 0;
                Path = $"Data/Img/{openFile.SafeFileName}";
                var a = File.ReadAllBytes(openFile.FileName);
                HousingPicture picture = new HousingPicture();
                CopyPicture(openFile.FileName, Path);
                MessageBox.Show(openFile.SafeFileName);
                lbItems.Text = LiPicture.Count().ToString();
                box = new PictureBox();
                picture = new HousingPicture(File.ReadAllBytes(openFile.FileName), openFile.FileName);
                box.Image = ((Image)(resources.GetObject("box.Image")));
                box.Name = $"img{n++}";
                box.Size = new Size(100, 100);
                box.SizeMode = PictureBoxSizeMode.StretchImage;
                box.TabStop = false;
                box.ImageLocation = Path;

                this.box.DoubleClick += new System.EventHandler(this.box_DoubleClick);
                //box.BackColor = Color.Black;
                panelPicture.Controls.Add(box);
                LiPicture.Add(picture);
            }
        }
        
        private void box_DoubleClick(object sender, EventArgs e)
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

        //    static void CopyPicture(string sourcePath, string destinationPath)
        //{
        //        sourcePath = @"C:\Users\PHARAON\Pictures\Capture.png";
        //    FileInfo fileInfo = new FileInfo(destinationPath);
        //    if (!fileInfo.Directory.Exists)
        //        fileInfo.Directory.Create();
        //    FileSystem.CopyDirectory(sourcePath, destinationPath,
        //        UIOption.AllDialogs);
        //}



        // Simple synchronous file copy operations with no user interface.
        // To run this sample, first create the following directories and files:
        // C:\Users\Public\TestFolder
        // C:\Users\Public\TestFolder\test.txt
        // C:\Users\Public\TestFolder\SubDir\test.txt
        static void CopyPicture(string fileName, string targetPath)
        {

            // Use Path class to manipulate file and directory paths.
            // To copy a file to another location and
            // overwrite the destination file if it already exists.
           
            FileInfo fileInfo = new FileInfo(targetPath);
            if (!fileInfo.Directory.Exists)
                fileInfo.Directory.Create();
            System.IO.File.Copy(fileName, targetPath, true);


        }

    }
}
