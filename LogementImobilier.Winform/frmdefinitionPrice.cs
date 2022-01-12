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
    public partial class frmdefinitionPrice : Form
    {
        public string path = @"Data\config\conft_price.bb";
        public frmdefinitionPrice()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo fi = new FileInfo(path);
                if (!fi.Directory.Exists)
                    fi.Directory.Create();

                File.WriteAllText(path, nudExibition.Value.ToString() + "\n" + nudKitchen.Value.ToString() + "\n" + nudLevel.Value.ToString() + "\n" +
                    nudNotation.Value.ToString() + "\n" + nudParking.Value.ToString() + "\n" + nudRooms.Value.ToString() + "\n" + nudShowers.Value.ToString()+ "\n"+nudTerrasse.Value.ToString());
                Program.messagebox = "Insertion succesful ";
                frmMessageBox messageBox = new frmMessageBox();
                messageBox.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK);
            }
        }

        private void frmdefinitionPrice_Load(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(path);
            if (!fi.Directory.Exists)
            {
                fi.Directory.Create();
                File.WriteAllText(path, "5000\n5000\n5000\n5000\n5000\n5000\n5000\n5000\n");
            }
                
            var val = File.ReadAllLines(path);
            nudExibition.Value = decimal.Parse(val[0]);
            nudKitchen.Value = decimal.Parse(val[1]);
            nudLevel.Value = decimal.Parse(val[2]);
            nudNotation.Value = decimal.Parse(val[3]);
            nudParking.Value = decimal.Parse(val[4]);
            nudRooms.Value = decimal.Parse(val[5]);
            nudShowers.Value = decimal.Parse(val[6]);
            nudTerrasse.Value = decimal.Parse(val[7]);
        }
    }
}
