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
            lbMessages.Text = "Sart a Renting operation";
            frmRenting renting = new frmRenting();
            OpenChildform(renting, sender);
        }

        private void frmIndex_Load(object sender, EventArgs e)
        {

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnAddHouse_Click_1(object sender, EventArgs e)
        {
            frmAddHouse addHouse = new frmAddHouse();
            OpenChildform(addHouse, sender);
        }
    }
}
