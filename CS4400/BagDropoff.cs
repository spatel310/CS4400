using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CS4400
{
    public partial class BagDropoff : Form
    {

        public BagDropoff()
        {
            InitializeComponent();
        }
        
        private void ReturnHomeClicked(object sender, EventArgs e)
        {
            DropOffGrid.Rows.Clear();
            Program.BagDropoff.Hide();

            Program.HomeForm.Show();

        }

        private void CompleteDroppoffClicked(object sender, EventArgs e)
        {
            try
            {
                string product = "";
                string source = "";
                string quantity = "";
                string insert = "";
                string insertDate = "INSERT INTO DropOffTransaction(Date) VALUES (current_date)";
                string grabDropoffID = "SELECT MAX(DID) FROM DropOffTransaction";
                int DID = 0;
                MySqlCommand cmd;
                for (int rows = 0; rows < DropOffGrid.Rows.Count - 1; rows++)
                {
                    product = DropOffGrid.Rows[rows].Cells[0].Value.ToString();
                    source = DropOffGrid.Rows[rows].Cells[1].Value.ToString();
                    quantity = DropOffGrid.Rows[rows].Cells[2].Value.ToString();

                    //create DropOffTransaction on today's date
                    Program.OpenConnection();
                    cmd = new MySqlCommand(insertDate, Program.connection);
                    cmd.ExecuteNonQuery();

                    //grab the DID of the new DropOffTransaction on today's date
                    cmd = new MySqlCommand(grabDropoffID, Program.connection);
                    DID = Convert.ToInt32(cmd.ExecuteScalar());

                   
                    //as long as the DID is found, create the DropOff entry with product/source/qty information
                    if (DID != null)
                    {
                        insert = String.Format("INSERT INTO DropOff(DID, ProductName, Quantity, SourceName) VALUES({0}, \"{1}\", {2},\"{3}\")", DID, product, quantity, source);
                        cmd = new MySqlCommand(insert, Program.connection);
                        cmd.ExecuteNonQuery();
                    }

                    Program.CloseConnection();
                }
                Result.Text = "Drop off successful!";
            }
            catch
            {
                Result.Text = "Drop off failed!";
            }
        }
    }
}

