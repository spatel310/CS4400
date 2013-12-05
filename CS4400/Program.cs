using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace CS4400
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        
        ///DB STUFF
        public static MySqlConnection connection;
        public static string server = "academic-mysql.cc.gatech.edu";
        public static string database = "cs4400_Group_18";
        public static string uid = "cs4400_Group_18";
        private static string password = "46mFV3YJ";
        public static string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        public static bool isOpen = false;

        
        ///Program stuff
        public static LogInForm LogInForm;
        public static HomeForm HomeForm;
        public static MainForm MainForm;
        public static PickupSignInList PickupSignInList;
        public static BagList BagList;
        public static BagDropoff BagDropoff;
        public static SearchClientList SearchClientList;
        public static NewClient NewClient;
        public static Products Products;
        public static MoServiceReport MoServiceReport;
       


        [STAThread]
        static void Main()
        {


            //db stuff


            connection = new MySqlConnection(connectionString);
          //  OpenConnection();
           // List<string> holder = Select();
            //CloseConnection();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LogInForm = new LogInForm();
            HomeForm = new HomeForm();
            MainForm = new MainForm();
            BagList = new BagList();
            BagDropoff = new BagDropoff();
            PickupSignInList = new PickupSignInList();
            SearchClientList = new SearchClientList();
            NewClient = new NewClient();
            Products = new Products();
            MoServiceReport = new MoServiceReport();


            MainForm.IsMdiContainer = true;

            LogInForm.MdiParent = MainForm;
            HomeForm.MdiParent = MainForm;
            PickupSignInList.MdiParent = MainForm;
            BagList.MdiParent = MainForm;
            BagDropoff.MdiParent = MainForm;
            SearchClientList.MdiParent = MainForm;
            NewClient.MdiParent = MainForm;
            Products.MdiParent = MainForm;
            MoServiceReport.MdiParent = MainForm;

            LogInForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            HomeForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            PickupSignInList.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            BagList.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            BagDropoff.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            SearchClientList.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            NewClient.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Products.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MoServiceReport.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;


            Application.Run(MainForm);
        }
        //open connection to database
        public static bool OpenConnection()
        {
            try
            {
                connection.Open();
                Debug.WriteLine("this worked");
                isOpen = true;
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        public static bool CloseConnection()
        {
            try
            {
                connection.Close();
                isOpen = false;
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static List<string> Select()
        {

            string query = "SELECT * FROM Bag";

            //Create a list to store the result
            List<string> list = new List<string>();

            //Open connection
            if (isOpen == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                int i = 0;
                while (dataReader.Read())
                {
                    list.Add(dataReader["Name"] + "");
                    Debug.Print(list.ElementAt(i));
                    i++;
                }

                //close Data Reader
                dataReader.Close();


                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
    }
}
