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
    public partial class frmEditclient : Form
    {
        public frmEditclient()
        {
            InitializeComponent();
            guna2TextBox2.Visible = false;
            guna2TextBox3.Visible = false;
            fullname.Visible = false;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            guna2TextBox2.Visible = true;
        }

        private void textbox1_name_TextChanged(object sender, EventArgs e)
        {
            fullname.Visible = true;

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            guna2TextBox3.Visible = true;
        }
        

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
