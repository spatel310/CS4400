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
    public partial class PickupSignInList : Form
    {
        public static int CurrentClient = 0;
        public PickupSignInList()
        {
            InitializeComponent();
            //MySqlDataAdapter sda = new MySqlDataAdapter("SELECT LastName, FirstName, FamilyMemberTotal, CONCAT( Street, \", \" , City, \", \" , State, \" \", Zip, \" \",  Apt) AS Address, Phone, Pday AS PickUpDay FROM Client NATURAL JOIN FamilyCountComplete  WHERE Pday = Day(current_date)", Program.connection);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT LastName, FirstName, FamilyMemberTotal, CONCAT(Street,\", \", City) AS Address, State, Zip, Apt, Phone, Pday AS PickUpDay FROM Client NATURAL JOIN FamilyCountComplete  WHERE Pday = Day(current_date)", Program.connection);


                Program.OpenConnection();
                DataSet ds = new DataSet();
                Debug.Print("things are happening...");
                sda.Fill(ds);
                PickUpSignInListTable.DataSource = ds.Tables[0].DefaultView;
                Program.CloseConnection();
                //PickUpSignInListTable.DataBind();

                int today = DateTime.Today.Day;
                DayNumber.Text = " " + today;
            }
            catch (DataException e)
            {
                Debug.Print(e.Message);
            }
        }
 
        private void ReturnHomeClicked(object sender, EventArgs e)
        {
            Program.PickupSignInList.Hide();
            Program.HomeForm.Show();
        }

        private void EnterDayClicked(object sender, EventArgs e)
        {
            int date = Convert.ToInt32(DayNumber.Text);
            string cmd = String.Format("SELECT LastName, FirstName, FamilyMemberTotal, CONCAT(Street,\", \", City) AS Address, State, Zip, Apt, Phone, Pday AS PickUpDay FROM Client NATURAL JOIN FamilyCountComplete  WHERE Pday = {0}", date);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd , Program.connection);
            Program.OpenConnection();
            DataSet ds = new DataSet();
            Debug.Print("things are happening...");
            sda.Fill(ds);
            PickUpSignInListTable.DataSource = ds.Tables[0].DefaultView;
            Program.CloseConnection();
        }

        private void Select(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            Debug.Print(Convert.ToString(PickUpSignInListTable.Rows[row].Cells.Count));
            string cidCmd = String.Format("SELECT CID FROM Client WHERE LastName = \"{0}\" AND FirstName = \"{1}\" AND Phone = \"{2}\"", PickUpSignInListTable.Rows[row].Cells[0].Value, PickUpSignInListTable.Rows[row].Cells[1].Value, PickUpSignInListTable.Rows[row].Cells[7].Value);
            Program.OpenConnection();
            MySqlCommand getcommand = new MySqlCommand(cidCmd, Program.connection);
            CurrentClient = Convert.ToInt16(getcommand.ExecuteScalar());
            Debug.Print("This should assign a value here " + CurrentClient);
            Program.CloseConnection();

            Program.PickupSignInList.Hide();

            PickupConfirmation pickupConfirmation = new PickupConfirmation();
            pickupConfirmation.MdiParent = Program.MainForm;
            pickupConfirmation.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pickupConfirmation.Show();
        }

    }
}
