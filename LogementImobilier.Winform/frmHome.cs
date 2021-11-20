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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }


        private void btnAddHouse_Click(object sender, EventArgs e)
        {
            frmAddHouse addHouse = new frmAddHouse();
            addHouse.ShowDialog();
        }

        private void btn_StarRenting_Click(object sender, EventArgs e)
        {
            frmRenting renting = new frmRenting();
            renting.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
