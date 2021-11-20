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
    public partial class frmAddClient : Form
    {
        ClientManager manager;
        public frmAddClient()
        {
            InitializeComponent();
            manager = new ClientManager();
            tbEmail.Text = "email@email.com";
            tbName.Text = "test";
            tbPhoneNumber.Text = "678976543";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var client = new Client(tbEmail.Text, tbName.Text, int.Parse(tbPhoneNumber.Text));
            manager.AddClient(client);
            tbName.Clear();
            tbEmail.Clear();
            tbPhoneNumber.Clear();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
