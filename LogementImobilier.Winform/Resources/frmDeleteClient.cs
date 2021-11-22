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
    public partial class frmDeleteClient : Form
    {
        public frmDeleteClient()
        {
            InitializeComponent();
        }

        private void frmDeleteClient_Load(object sender, EventArgs e)
        {
            guna2TextBox1.Visible = false;
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            guna2TextBox1.Visible = true;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show
                ("Suppression effectuée");
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text =string.Empty;
            guna2TextBox3.Text = string.Empty;
            
        }
    }
}
