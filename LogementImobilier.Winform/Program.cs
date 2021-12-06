using LogementImobilier.BO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
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
        public static User curentUser;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InfoHouse = new Housing();
            curentUser = new User();
            InfoHouse.Name = "fdfdfdf";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("fr");
            //Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("fr");
            frmLogin index = new frmLogin();
            index.Show();
            Application.Run();
        }
    }
}
