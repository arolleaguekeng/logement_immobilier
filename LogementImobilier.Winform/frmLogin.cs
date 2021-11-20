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
    public partial class frmLogin : Form
    {

        public static User user = null;
        bool isLogin = true;
        UserManager manager = new UserManager();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            panelEmail.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            panelEmail.Visible = false;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            panelEmail.Visible = true;
            user = manager.LoginUser(tbEmail.Text, tbPassword.Text);
            if (user != null)
            {
                MessageBox.Show($"Welcome {user.Name}", "Welcome message", MessageBoxButtons.OK);
                var mainfrm = new frmHome();
                mainfrm.Show();
                if (!isLogin)
                    Application.Exit();
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show($"Email or password is invalid!", "Caution", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
