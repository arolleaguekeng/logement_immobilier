using LogementImobilier.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogementImobilier.Winform
{
    static class Program
    {
        public static Housing InfoHouse;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InfoHouse = new Housing();
            InfoHouse.Name = "fdfdfdf";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin index = new frmLogin();
            index.Show();
            Application.Run();
        }
    }
}
