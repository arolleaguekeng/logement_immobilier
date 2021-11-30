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
    public partial class FrmUser : Form
    {
        UserManager manager;
        List<User> users = new List<User>();


        public FrmUser()
        {
            InitializeComponent();
            manager = new UserManager();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var users = new User(tbId.Text, tbfullname.Text,tbpassword.Text);
            manager.AddUser(users);
            MessageBox.Show("saved sucessfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lineId_Click(object sender, EventArgs e)
        {

        }
    }
}
