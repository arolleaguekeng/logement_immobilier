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
    public partial class frmInfoUser : Form
    {
        public frmInfoUser()
        {
            InitializeComponent();
        }

        private void frmInfoUser_Load(object sender, EventArgs e)
        {
            try
            {
                lbUserId.Text = Program.curentUser.Id;
                lbUserName.Text = Program.curentUser.Name;
                // Assign an image to the button.
                userPicture.ImageLocation = $@"{Program.curentUser.Profile}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }
    }
}
