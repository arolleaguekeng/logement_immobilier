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
    public partial class frmHistory : Form
    {
        HousingManager manager;
        List<Housing> housings;
        public frmHistory()
        {
            manager = new HousingManager();
            housings = new List<Housing>();
            InitializeComponent();
            housings  = manager.GetAllHousing();

           
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            foreach (var house in housings)
            {
                housingBindingSource.Add(house);
            }
        }
    }
}
