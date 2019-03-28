using Pedalon.UI.Models;
using Pedalon.UI.Views;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedalon.UI
{
    static class Program
    {
        public static User User;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // Create a new object, representing the German culture.  
                CultureInfo culture = CultureInfo.CreateSpecificCulture("tr");

                // The following line provides localization for the application's user interface.  
                Thread.CurrentThread.CurrentUICulture = culture;

                // The following line provides localization for data formats.  
                Thread.CurrentThread.CurrentCulture = culture;


                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("tr-TR");

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                DevExpress.Skins.SkinManager.EnableFormSkins();

                DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular);
                CheckFiles();

                //LoginForm login = new LoginForm();
                if (DateTime.Now.Ticks < 636899328000000000)
                {
                    MessageBox.Show("Bu demo sürümün geçerlilik tarihi 4 Nisan 2019 tarihine kadardır.", "Bilgilendirme");
                    Application.Run(new MainForm());
                }
                else
                {
                    MessageBox.Show("Programın demo süresi dolmuştur.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private static void CheckFiles()
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.Directory_DB))
            {
                Properties.Settings.Default.Directory_DB = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Pedalon\\DB\\";
                Properties.Settings.Default.Directory_Reports = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Pedalon\\Reports\\";
                Properties.Settings.Default.Save();
            }
            string[] Dirs = new string[]
            {
                Properties.Settings.Default.Directory_DB,
                Properties.Settings.Default.Directory_Reports
            };
            foreach (string dir in Dirs)
            {
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
            }
            string[] Files = new string[]
            {
                Dirs[0] + "\\Acts.json",
                Dirs[0] + "\\Bikes.json",
                Dirs[0] + "\\Donations.json",
                Dirs[0] + "\\Fees.json",
                Dirs[0] + "\\Members.json",
                Dirs[0] + "\\Places.json",
                Dirs[0] + "\\Spendings.json",
                Dirs[0] + "\\Todos.json",
                Dirs[0] + "\\Users.json",
            };
            foreach (string fname in Files)
            {
                if (!File.Exists(fname))
                {
                    File.Create(fname).Close();
                    File.WriteAllText(fname, "[]");
                }
            }

        }
    }
}
