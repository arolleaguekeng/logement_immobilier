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
        public byte[] picture;


        public FrmUser()
        {
           
            InitializeComponent();
            manager = new UserManager();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var users = new User(tbId.Text, tbfullname.Text,tbpassword.Text,picture);
            manager.AddUser(users);
            MessageBox.Show("saved sucessfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lineId_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                PictureManager pictureManager = new PictureManager();
                int n = 0;
                var Path = openFile.FileName;
                pbUser.ImageLocation = Path;
                pbUser.Cursor = Cursors.Hand;
                picture = File.ReadAllBytes(openFile.FileName);


            }
        }
    }
}
