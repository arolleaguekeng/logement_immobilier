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
    public partial class frmClientRending : Form
    {
        public frmClientRending()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void frmClientRending_Load(object sender, EventArgs e)
        {
            lbNowDate.Text = DateTime.Now.ToLongDateString();
        }
    }
}
