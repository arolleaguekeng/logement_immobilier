using LogementImobilier.BLL;
using LogementImobilier.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogementImobilier.Winform
{
    public partial class frmLogin : Form
    {
        public static User user = null;
        bool isLogin = true;
        List<User> users;
        UserManager manager;
        Language[] languages;
        public string path = @"Data\User.json";
        public frmLogin()
        {
            FileInfo fi = new FileInfo(path);
            if (!fi.Directory.Exists)
            {
                fi.Directory.Create();
                File.WriteAllText(path, "");
            }
            manager = new UserManager();
            manager.GetAllUsers();
            if (File.ReadAllText(path).ToString() == "")
            {
                UserManager user = new UserManager();
                user.AddUser(new User("admin@admin.email", "admin", "admin", "../../Resources/users/admin.png"));
                MessageBox.Show("une erreure c'est produite veuillez redemarer l'application");
                this.Close();
            }

            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            tbEmail.Text = "admin@admin.email";
            tbPassword.Text = "admin";
           languages = new Language[]
           {
                new Language {Code = "en", Name = "English"},
                new Language {Code = "fr", Name = "Français"}
           };
            combLanguage.DataSource = languages;
            combLanguage.DisplayMember = "Name";
            combLanguage.ValueMember = "Code";
            combLanguage.SelectedIndex = -1;

            var defaultLanguage = Properties.Settings.Default.langue;
            if (!string.IsNullOrEmpty(defaultLanguage))
            {
                combLanguage.SelectedValue = defaultLanguage;

            }
            panelEmail.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            panelEmail.Visible = false;
            panelPassword.Visible = true;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            manager.GetAllUsers();
            user = manager.LoginUser(tbEmail.Text, tbPassword.Text);
            if (user != null)
            {
                MessageBox.Show($"Welcome {user.Name}", "Welcome message", MessageBoxButtons.OK);
                Program.curentUser = user;
                
                var mainfrm = new frmIndex();
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
            frmIndex index = new frmIndex();
            this.Close();
            index.Show();
           
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void bnt_back_Click(object sender, EventArgs e)
        {
            panelEmail.Visible = true;
            panelPassword.Visible = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (combLanguage.SelectedIndex < 0 )
            {
                MessageBox.Show("Chosse a language !");
                return;
            }

            Properties.Settings.Default.langue = combLanguage.SelectedValue.ToString();
            Properties.Settings.Default.Save();
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(Properties.Settings.Default.langue);
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(Properties.Settings.Default.langue);

            panelLangguage.Visible = false;
            guna2ShadowPanel1.Visible = true;
        }
    }
}
