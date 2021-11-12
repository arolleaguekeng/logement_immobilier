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
        Label labelMsg;
        public frmAddHouse()
        {
            InitializeComponent();
            labelMsg = new Label();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client();
                frmIndex index = new frmIndex();
                HousingManager housing = new HousingManager();



                lbPrice.Text = housing.CalculPrice((int)nudRooms.Value, (int)nudKitchen.Value,
                    (int)starNotation.Value, (int)nudExibition.Value, (int)nudShowers.Value,
                    1,(int )nudLevel.Value).ToString();
                housing.CreateHousing(new Housing(tbId.Text, tbName.Text, decimal.Parse(lbPrice.Text), cbbLocation.Text, (int)nudRooms.Value,
                    (int)nudKitchen.Value, (int)nudShowers.Value, (int)nudExibition.Value, starNotation.Value,
                    false, client, chbTerasse.Checked, chbParking.Checked,(int) nudLevel.Value));

                //MessageBox.Show("Added Sucsesfuly");
                index.panelMessage.Controls.Add(labelMsg);
                index.panelMessage.Visible = true;
                labelMsg.Text = "Added Sucsesfuly";
                labelMsg.Dock = DockStyle.Right;
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
