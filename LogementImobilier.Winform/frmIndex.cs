using Guna.UI2.WinForms;
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
    public partial class frmIndex : Form
    {
        private Guna2Button currentbutton;
        private Form activeform;
        public System.Drawing.Image Image { get; set; }
        public frmIndex()
        {
            InitializeComponent();
            frmHome home = new frmHome();
            home.MdiParent = this;
            home.Dock = DockStyle.Fill;
            home.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuAddHousing_Click(object sender, EventArgs e)
        {
            OpenAddHouse();
        }

        public  void OpenAddHouse()
        {
            frmAddHouse addHouse = new frmAddHouse();
            addHouse.ShowDialog();
        }

        private void btnAddHouse_Click(object sender, EventArgs e)
        {
            frmAddHouse addHouse = new frmAddHouse();
            OpenChildform(addHouse, sender);
        }

        private void btn_StarRenting_Click(object sender, EventArgs e)
        {

        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentbutton != (Guna2Button)btnSender)
                {
                    DisableButton();
                    currentbutton = (Guna2Button)btnSender;
                    currentbutton.ForeColor = Color.DodgerBlue;
                }
            }
        }

        private void DisableButton()
        {

            foreach (Control Previewsbtn in panelmenu.Controls)
            {
                if (Previewsbtn.GetType() == typeof(Guna2Button))
                {
                    Previewsbtn.ForeColor = Color.Black;

                }

            }
        }

        private void OpenChildform(Form Childform, object btnSender)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            ActivateButton(btnSender);
            activeform = Childform;
            Childform.TopLevel = false;
            Childform.FormBorderStyle = FormBorderStyle.None;
            Childform.Dock = DockStyle.Fill;
            this.panel_Childform.Controls.Add(Childform);
            this.panel_Childform.Tag = Childform;
            Childform.BringToFront();
            Childform.Show();

        }

        private void btnStartRenting_Click(object sender, EventArgs e)
        {
            frmRenting renting = new frmRenting();
            OpenChildform(renting, sender);
        }

        private void btnStartRenting_Click_1(object sender, EventArgs e)
        {
            frmRenting renting = new frmRenting();
            OpenChildform(renting, sender);
        }


        private void SetMyButtonProperties()
        {

        }

        private void frmIndex_Load(object sender, EventArgs e)
        {
            try
            {
                // Assign an image to the button.
                userPicture.Image = Image.FromFile($@"{Program.curentUser.Profile}");
                userPicture.ImageSize = new Size(new Point(49, 45));
                lbCurentUser.Text = Program.curentUser.Id;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,ex.Source);
            }
        }
        
        private void btn_Home_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAddHouse_Click_1(object sender, EventArgs e)
        {
            frmAddHouse addHouse = new frmAddHouse();
            OpenChildform(addHouse, sender);
        }

        private void btnClosePanel_Click(object sender, EventArgs e)
        {
        }

        private void frmIndex_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnNext.Visible = false;
            btnPreview.Visible = true;
            panelmenu.Size = new Size(212,618);     
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            panelmenu.Size = new Size(68, 618);
            btnPreview.Visible = false;
            btnNext.Visible = true;
        }

        private void btnHistoric_Click(object sender, EventArgs e)
        {
            frmHistory history = new frmHistory();
            OpenChildform(history, sender);
        }

        private void defineDefaulPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDefPrice_Click(object sender, EventArgs e)
        {
            frmdefinitionPrice defauldPrice = new frmdefinitionPrice();
            OpenChildform(defauldPrice, sender);
        }

        private void btnChangeLanguage_Click(object sender, EventArgs e)
        {
            frmLanguageChange languageChange = new frmLanguageChange();
            OpenChildform(languageChange, sender);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FrmUser user = new FrmUser();
            OpenChildform(user, sender);
        }

        private void btnShowEditUser_Click(object sender, EventArgs e)
        {
            FrmModify user = new FrmModify();
            OpenChildform(user, sender);
        }



        private void userPicture_Click_1(object sender, EventArgs e)
        {
            frmInfoUser infoUser = new frmInfoUser();
            OpenChildform(infoUser, sender);
        }

        private void userPicture_Click(object sender, EventArgs e)
        {
            frmInfoUser infoUser = new frmInfoUser();
            OpenChildform(infoUser, sender);
        }
    }
}
