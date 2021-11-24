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
        HistoryManager manager;
        List<Historic> housings;
        public frmHistory()
        {
            manager = new HistoryManager();
            housings = new List<Historic>();
            InitializeComponent();
            housings  = manager.ShowHistory();

           
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            ShowLvHousing(lvShow);
            ShowLvHousing(lvShow2);
        }
        private void ShowLvHousing(ListView lv)
        {
            housings = manager.ShowHistory();
            foreach (var house in housings)
            {
                var Lvi = new ListViewItem(new string[] {house.DateTime.ToString(),house.HousingHis.Location,house.Operation});
                Lvi.Tag = house;
                lv.Items.Add(Lvi);
            }
        }
    }
}
