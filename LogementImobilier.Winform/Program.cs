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
        public static List<HousingPicture> picture;
        public static Housing InfoHouse;
        public static string messagebox;
        internal static object user;

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
            frmIndex index = new frmIndex();
            index.Show();
            Application.Run();
        }
    }
}
