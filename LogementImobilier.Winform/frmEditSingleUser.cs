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
    public partial class frmEditSingleUser : Form
    {
        UserManager manager;
        string destinationPath;
        public frmEditSingleUser()
        {
            manager = new UserManager();
            InitializeComponent();
        }

        private void frmEditSingleUser_Load(object sender, EventArgs e)
        {
            tbEmail.Text = Program.curentUser.Id;
            tbName.Text = Program.curentUser.Name;
            tbPaword.Text = Program.curentUser.Password;
            pbProfile.ImageLocation = Program.curentUser.Profile;
            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    var path = openFile.FileName;
                    string ext = Path.GetExtension(openFile.FileName);
                    destinationPath = "../../Resources/users/" + tbEmail.Text + ".png";
                    pbProfile.ImageLocation = path;
                    pbProfile.Cursor = Cursors.Hand;
                    manager.CopyPicture(path, destinationPath);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(tbPaword.Text != tbConfirmPassword.Text)
            {
                MessageBox.Show("please enter identic password");
            }
            else
            {
                
                try
                {
                    User newUser = new User(tbEmail.Text, tbName.Text, tbPaword.Text, destinationPath);
                    manager.EditUser(Program.curentUser, newUser);
                    Program.curentUser = newUser;
                    MessageBox.Show("           Edit succes          ");
                    this.Parent.Refresh();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }
    }
}
