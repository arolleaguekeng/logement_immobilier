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
    public partial class frmDeleteClient : Form
    {
        public frmDeleteClient()
        {
            InitializeComponent();
            numéro.Visible = false;
        }

       

        private void numéro_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void Text_box_name_TextChanged(object sender, EventArgs e)
        {
            numéro.Visible = true; 
        }
    }
}
