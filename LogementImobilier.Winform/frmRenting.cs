using Guna.UI2.WinForms;
using LogementImobilier.BLL;
using LogementImobilier.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogementImobilier.Winform
{
    public partial class frmRenting : Form
    {
        HousingManager housing;
        List<Housing> housings;
        public frmRenting()
        {
            InitializeComponent();
            housing = new HousingManager();
            frmHome frmHome = new frmHome();
            housings = housing.GetAllHousing();
            ShowLvHousing();
            

        }

        private void frmRenting_Load(object sender, EventArgs e)
        {

        }
        private void btnSeach_Click(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FindShow();
            //MessageBox.Show("loc:\n"+cbbLocation.SelectedItem.ToString() + "exib:\n"+nudExibition.Value.ToString() + "kit:\n" + (int)nudKitchens.Value+
            //    "rooms:\n" + (int)nudRooms.Value + "showers:\n" + (int)nudShowers.Value + "P:\n" + chbParking.Checked.ToString() + "T:\n" + chbTerasse.Checked + "Price:\n" + nudPrice.Value + "star:\n" + btnStars.Value);
        }

        private void FindShow()
        {
            housings = housing.GetAllHousing();
            housings = housing.Search(cbbLocation.SelectedItem.ToString(), (int)nudExibition.Value, (int)nudKitchens.Value,
                (int)nudRooms.Value, (int)nudShowers.Value, chbParking.Checked, chbTerasse.Checked, nudPrice.Value, btnStars.Value);
            lvShowHousing.Items.Clear();
            ShowLvHousing();
        }

        private void ShowLvHousing()
        {
            foreach (var house in housings)
            {
                var Lvi = new ListViewItem(new string[] { house.Location, house.Name, house.NumberOfLevel.ToString(),house.NumberShower.ToString(),
                house.NumberExibition.ToString(),house.NumberKitchen.ToString(),house.Parking.ToString(),house.NumberOfLevel.ToString(),house.Price.ToString(),house.Used.ToString()});
                Lvi.Tag = house;
                lvShowHousing.Items.Add(Lvi);

            }
        }


        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            //housings = housing.SearchName(tbSearch.Text);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbSearch_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void cbbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindShow();
        }

        private void nudKitchens_ValueChanged(object sender, EventArgs e)
        {
            FindShow();
        }

        private void nudRooms_ValueChanged(object sender, EventArgs e)
        {
            FindShow();
        }

        private void nudShowers_ValueChanged(object sender, EventArgs e)
        {
            FindShow();
        }

        private void nudExibition_ValueChanged(object sender, EventArgs e)
        {
            FindShow();
        }

        private void btnStars_ValueChanged(object sender, EventArgs e)
        {
            FindShow();
        }

        private void nudPrice_ValueChanged(object sender, EventArgs e)
        {
            FindShow();
        }

        private void btnClose_Click_3(object sender, EventArgs e)
        {
            panelRight.Visible = false;
            btnSee.Visible = true;
            


        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            btnSee.Visible = false;
            panelRight.Visible = true;
            panelRight.Dock = DockStyle.Right;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panelRight.Visible = false;
            btnSee.Visible = true;
        }
        public static Housing hous;
        private void lvShowHousing_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmInfoHousing infoHousing = new frmInfoHousing();
            Program.InfoHouse = lvShowHousing.SelectedItems[0].Tag as Housing;
            infoHousing.ShowDialog();


        }

    }
}
