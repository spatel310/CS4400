using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CS4400
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInClicked(object sender, EventArgs e)
        {
            //grabs the username and password from the text boxes
            string username = Username.Text;
            string password = Password.Text;

            //open connection, create a command, execute it to produce a "simple"output, close connection
            Program.OpenConnection();
            String query = String.Format("SELECT COUNT(*) FROM Users WHERE Username = \"{0}\" AND Password = \"{1}\"", username, password);
            MySqlCommand getcommand = new MySqlCommand(query, Program.connection);
            int there = Convert.ToInt16(getcommand.ExecuteScalar());
            Program.CloseConnection();
                
            //if there is 1 user with that username & password, enter the program
            if (there == 1)
            {
                Program.LogInForm.Hide();
                Program.HomeForm.Show();
            }
        }

    }
}
