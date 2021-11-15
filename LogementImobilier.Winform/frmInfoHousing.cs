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
    public partial class frmInfoHousing : Form
    {
        public frmInfoHousing()
        {
            InitializeComponent();
        }

        private void frmInfoHousing_Load(object sender, EventArgs e)
        {
            lbHouseName.Text = Program.InfoHouse.Name;
            lbPrice.Text = Program.InfoHouse.Price.ToString() ;
            lbLocation.Text = Program.InfoHouse.Location.ToString();
            lbExibition.Text= Program.InfoHouse.NumberExibition.ToString();
            lbKitchen.Text = Program.InfoHouse.NumberKitchen.ToString();
            lbLevel.Text = Program.InfoHouse.NumberOfLevel.ToString();
            lbRoom.Text = Program.InfoHouse.NumberRoom.ToString();
            lbShower.Text = Program.InfoHouse.NumberShower.ToString();
            lbStar.Text = Program.InfoHouse.NumberStart.ToString();
            lbParking.Text = Program.InfoHouse.Parking.ToString();
            lbTerrasse.Text = Program.InfoHouse.Terrasse.ToString();
            lbUsed.Text = Program.InfoHouse.Used.ToString();
        }

        private void btnCose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
