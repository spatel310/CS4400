using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS4400
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        

        public static LogInForm LogInForm;
        public static HomeForm HomeForm;
        public static MainForm MainForm;
        public static PickupSignInList PickupSignInList;
        public static BagList BagList;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LogInForm = new LogInForm();
            HomeForm = new HomeForm();
            MainForm = new MainForm();
            BagList = new BagList();
            PickupSignInList = new PickupSignInList();


            MainForm.IsMdiContainer = true;

            LogInForm.MdiParent = MainForm;
            HomeForm.MdiParent = MainForm;
            PickupSignInList.MdiParent = MainForm;
            BagList.MdiParent = MainForm;

            LogInForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            HomeForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            PickupSignInList.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            BagList.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            Application.Run(MainForm);
        }
    }
}
