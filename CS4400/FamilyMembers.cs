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

namespace CS4400
{
    public partial class FamilyMembers : Form
    {
        public FamilyMembers()
        {
            InitializeComponent();
        }

        private void ReturnHomeClicked(object sender, EventArgs e)
        {
            this.Hide();
            Program.HomeForm.Show();
        }

        private void AddMembersClicked(object sender, EventArgs e)
        {
            try
            {
                string fname = "";
                string lname = "";
                string gender = "";
                string dob = "";
                string insert = "";
               
                MySqlCommand cmd;
                Program.OpenConnection();
                for (int rows = 0; rows < DropOffGrid.Rows.Count - 1; rows++)
                {
                    fname = DropOffGrid.Rows[rows].Cells[0].Value.ToString();
                    lname = DropOffGrid.Rows[rows].Cells[1].Value.ToString();
                    gender = DropOffGrid.Rows[rows].Cells[2].Value.ToString();
                    dob = DropOffGrid.Rows[rows].Cells[5].Value.ToString() + DropOffGrid.Rows[rows].Cells[4].Value.ToString() + DropOffGrid.Rows[rows].Cells[3].Value.ToString();

                    if(NewClient.clientCID != null && NewClient.clientCID != 0)
                    {
                        insert = String.Format("INSERT INTO FamilyMember (CID, FirstName, LastName, DOB, Gender) VALUES({0}, \"{1}\", \"{2}\",\"{3}\", \"{4}\")", NewClient.clientCID, fname, lname, dob, gender);
                        cmd = new MySqlCommand(insert, Program.connection);
                        cmd.ExecuteNonQuery();
                    }

                   
                } 
                Program.CloseConnection();
                Result.Text = "Family Members Added Successfully!";
            }
            catch
            {
                Result.Text = "Family Members Not Added!";
            }
        }
    }
}
