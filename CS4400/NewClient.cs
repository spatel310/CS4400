using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CS4400
{
    public partial class NewClient : Form
    {
        public static int clientCID = 0;
        public NewClient()
        {
            InitializeComponent();
        }

        private void ReturnHomeClicked(object sender, EventArgs e)
        {
            Program.NewClient.Hide();
            Program.HomeForm.Show();
        }

        private void CreateClientClicked(object sender, EventArgs e)
        {
            try
            {
                Program.OpenConnection();
                String dob = DOB.Value.ToString("yyyyMMdd");
                String start = Start.Value.ToString("yyyyMMdd");
                String insert = String.Format("INSERT INTO Client(Gender, DOB, Start, PDay, FirstName, LastName, Phone, Street, City, State, Zip, Apt, BagName) VALUES (\"{0}\", \"{1}\",\" {2}\",{3}, \"{4}\", \"{5}\",\"{6}\", \"{7}\", \"{8}\", \"{9}\", {10}, \"{11}\", \"{12}\")", Gender.Text, dob, start, PickUpDay.Text, FirstName.Text, LastName.Text, Telephone.Text, Street.Text, City.Text, State.Text, Zip.Text, AptNum.Text, BagName.SelectedItem.ToString());
                MySqlCommand cmd = new MySqlCommand(insert, Program.connection);
                cmd.ExecuteNonQuery();
                string grabCID = "SELECT MAX(CID) FROM Client";
                cmd = new MySqlCommand(grabCID, Program.connection);
                int CID = Convert.ToInt32(cmd.ExecuteScalar());
                if (CID != null & CID != 0)
                {
                    clientCID = CID;

                    String haveAid = String.Format("INSERT INTO HasAid(FinAidName, CID) VALUES (\"{0}\",{1})", FinAid.SelectedItem.ToString(), clientCID);
                    cmd = new MySqlCommand(haveAid, Program.connection);
                    cmd.ExecuteNonQuery();

                    Program.CloseConnection();

                    //show the family member form
                    FamilyMembers famForm = new FamilyMembers();
                    famForm.MdiParent = Program.MainForm;
                    famForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    Program.NewClient.Hide();
                    famForm.Show();
                }
                else
                {
                    Program.CloseConnection();
                }
            }
            catch
            {
                DialogResult error = MessageBox.Show("All fields must be filled!");
            }

        }
    }
}
