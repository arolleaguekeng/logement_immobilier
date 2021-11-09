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
    public partial class frmAddHouse : Form
    {
        public frmAddHouse()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client();
                HousingManager housing = new HousingManager();
                lbPrice.Text = housing.CalculPrice((int)nudRooms.Value, (int)nudKitchen.Value,
                    (int)starNotation.Value, (int)nudExibition.Value, (int)nudShowers.Value,
                    1).ToString();
                nudPrice.Value = decimal.Parse(lbPrice.Text);

                housing.CreateHousing(new Housing(tbId.Text, tbName.Text, nudPrice.Value, cbbLocation.Text, (int)nudRooms.Value,
                    (int)nudKitchen.Value, (int)nudShowers.Value, (int)nudExibition.Value, starNotation.Value,
                    false, client, chbTerasse.Checked, chbParking.Checked));

                MessageBox.Show("Added Sucsesfuly");
            }
            catch (Exception)
            {
                throw new Exception("Faild to Add");

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
