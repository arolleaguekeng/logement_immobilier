using LogementImobilier.BLL;
using LogementImobilier.BO;
using Microsoft.Reporting.WinForms;
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
    public partial class frmFacture : Form
    {
        public List<Housing> housings;
        public List<Client> clients;
        public frmFacture()
        {
            housings = new List<Housing>();
            clients = new List<Client>();
            InitializeComponent();
        }

        private void frmFacture_Load(object sender, EventArgs e)
        {
            HousingManager manager = new HousingManager();
            housings.Add(Program.InfoHouse);
            this.reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DataSetHousing", housings)
                );
            //this.reportViewer1.LocalReport.DataSources.Add(
            //    new ReportDataSource("DataSetClient", clients)
            //    );
            this.reportViewer1.LocalReport.ReportPath = "RpFacture.rdlc";
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
            this.reportViewer1.RefreshReport();
        }

        private void frmFacture_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
