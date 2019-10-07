using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace QL_DatTiecNhaHang
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //SkinManager.EnableFormSkins();
            //UserLookAndFeel.Default.SetSkinStyle("DevExpress Light Style");
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //LoginForm loginForm = new LoginForm();
            //loginForm.ShowDialog();
            //if (loginForm.Status == 1)
            //{
            //    Application.Run(new MainForm());
            //}








            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            Application.Run(new MainForm());
        }
    }
}