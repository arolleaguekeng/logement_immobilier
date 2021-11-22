using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogementImobilier.Winform.Resources
{
    public partial class frmEditClient : Form
    {
        public frmEditClient()
        {
            InitializeComponent();
        }

        private void frmEditClient_Load(object sender, EventArgs e)
        {
            guna2TextBox3.Visible = false;
            guna2TextBox4.Visible = false;
            guna2TextBox1.Visible = false;

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            guna2TextBox3.Visible = true;

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            guna2TextBox4.Visible = true;

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
            guna2TextBox1.Visible = true;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show
                ("Modification effectuée");
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

            guna2TextBox4.Text = string.Empty;
            guna2TextBox3.Text = string.Empty;
            guna2TextBox1.Text = string.Empty;
        }
    }
}
