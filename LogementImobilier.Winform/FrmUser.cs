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
    public partial class FrmUser : Form
    {
        UserManager manager;
        List<User> users = new List<User>();
        string destinationPath;



        public FrmUser()
        {
           
            InitializeComponent();
            manager = new UserManager();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var users = new User(tbId.Text, tbfullname.Text,tbpassword.Text,destinationPath);
            manager.AddUser(users);
            MessageBox.Show("saved sucessfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lineId_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    PictureManager pictureManager = new PictureManager();
                    int n = 0;
                    var path = openFile.FileName;
                    string ext = Path.GetExtension(openFile.FileName);
                    destinationPath = "../../Resources/users/" + tbId.Text+".png";
                    pbUser.ImageLocation = path;
                    pbUser.Cursor = Cursors.Hand;
                    manager.CopyPicture(path, destinationPath);
                }
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show("veuillez remplire dabor les champs !");
            }

        }
    }
}
