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
                DateLabel.Text = DateTime.Now.ToShortDateString();
                Debug.Print("I'm worried things aren't working... " + PickupSignInList.CurrentClient);

                //bag contents table
                string cmd = String.Format("SELECT ProductName, CurrentMonthQty FROM Holds NATURAL JOIN Client WHERE CID = {0}", PickupSignInList.CurrentClient);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd, Program.connection);

                //client name label
                string cmd1 = String.Format("SELECT FirstName, LastName FROM Client WHERE CID = {0}", PickupSignInList.CurrentClient);
                MySqlDataAdapter sda1 = new MySqlDataAdapter(cmd1, Program.connection);

                Program.OpenConnection();
                //populate bag contents table
                DataSet ds = new DataSet();
                sda.Fill(ds);
                BagContents.DataSource = ds.Tables[0].DefaultView;
                //display client name
                DataSet ds1 = new DataSet();
                sda1.Fill(ds1);
                NameLabel.Text = ds1.Tables[0].Rows[0][0].ToString() + " " + ds1.Tables[0].Rows[0][1].ToString();
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
            //check to see if client is picking up on correct day
            string cidCmd = String.Format("SELECT PDay FROM Client WHERE CID = {0}", PickupSignInList.CurrentClient);
            Program.OpenConnection();
            MySqlCommand getcommand = new MySqlCommand(cidCmd, Program.connection);
            int day = Convert.ToInt16(getcommand.ExecuteScalar());

            //check to see if the client already picked up a bag today
            string checkCmd = String.Format("SELECT CID, PDate FROM PickUp x NATURAL JOIN PickUpTransaction y WHERE x.PID = y.PID AND x.CID = {0} AND y.PDate = CurDate()", PickupSignInList.CurrentClient);
            MySqlCommand check2Pickups = new MySqlCommand(checkCmd, Program.connection);


            //checks to see if the date is correct and if the client hasnt picked up their bag already
            if (day != DateTime.Today.Day)
            {
                DialogResult cancel = MessageBox.Show("Are you sure you want to Pickup your bag on the wrong day?");
            }
            else if (check2Pickups.ExecuteScalar() != null)
            {
                DialogResult cancel = MessageBox.Show("Client already picked up a bag today!");
            }
            else
            {
                try
                {
                    //insert into pickuptransaction
                    string insertIntoPickUpTransaction = "INSERT INTO PickUpTransaction VALUES(DEFAULT, CURDATE())";
                    MySqlCommand insertIntoPUT = new MySqlCommand(insertIntoPickUpTransaction, Program.connection);
                    insertIntoPUT.ExecuteNonQuery();

                    //get maxPID
                    string maxPIDCmd = String.Format("SELECT MAX(PID) FROM PickUpTransaction");
                    MySqlCommand getMaxPID = new MySqlCommand(maxPIDCmd, Program.connection);
                    int maxPID = Convert.ToInt16(getMaxPID.ExecuteScalar());

                    //get BagName
                    string BagNameCmd = String.Format("SELECT BagName FROM Client WHERE CID = {0}", PickupSignInList.CurrentClient);
                    MySqlCommand getBagName = new MySqlCommand(BagNameCmd, Program.connection);
                    string bagName = (string)getBagName.ExecuteScalar();

                    //insert into pickup
                    Debug.Print("things are happening...");
                    string pickUpTransactionCmd = String.Format("INSERT INTO PickUp VALUES({0},{1},\"{2}\")", PickupSignInList.CurrentClient, maxPID, bagName);
                    MySqlCommand insertIntoPU = new MySqlCommand(pickUpTransactionCmd, Program.connection);
                    insertIntoPU.ExecuteNonQuery();

                    DialogResult pickup = MessageBox.Show("Pickup Successful!");
                }
                catch
                {
                    DialogResult pickup = MessageBox.Show("pickup unsuccessful!");
                }

            }
            Program.CloseConnection();
            this.Close();
            Program.PickupSignInList.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
