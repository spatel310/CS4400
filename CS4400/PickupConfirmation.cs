using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace CS4400
{
    public partial class PickupConfirmation : Form
    {
        public PickupConfirmation()
        {
            InitializeComponent();

            try
            {
                Debug.Print("I'm worried things aren't working... " + PickupSignInList.CurrentClient);
                string cmd = String.Format("SELECT ProductName, CurrentMonthQty FROM Holds NATURAL JOIN Client WHERE CID = {0}", PickupSignInList.CurrentClient);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd, Program.connection);
                Program.OpenConnection();
                DataSet ds = new DataSet();
                sda.Fill(ds);
                BagContents.DataSource = ds.Tables[0].DefaultView;
                Program.CloseConnection();

            }
            catch (DataException e)
            {
                Debug.Print(e.Message);
            }
        }

        private void ReturnHomeClicked(object sender, EventArgs e)
        {
            this.Close();
            Program.HomeForm.Show();
        }

        private void ReturnToSignInListClicked(object sender, EventArgs e)
        {
            this.Close();
            Program.PickupSignInList.Show();
        }

        private void CompletePickupClicked(object sender, EventArgs e)
        {
            string cidCmd = String.Format("SELECT PDay FROM Client WHERE CID = {0}", PickupSignInList.CurrentClient);
            Program.OpenConnection();
            MySqlCommand getcommand = new MySqlCommand(cidCmd, Program.connection);
            int day = Convert.ToInt16(getcommand.ExecuteScalar());

            if (day != DateTime.Today.Day)
            {
                DialogResult cancel = MessageBox.Show("Sorry! You can only pickup on the day you are registered to pickup!");
                return;
            }
            else
            {

            }


            Program.CloseConnection();
        }
    }
}
