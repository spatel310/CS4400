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
    public partial class SearchClientList : Form
    {
        public SearchClientList()
        {
            InitializeComponent();

            Program.OpenConnection();
            String AllClientsCmd = String.Format("SELECT * FROM Client");
            MySqlDataAdapter sda = new MySqlDataAdapter(AllClientsCmd, Program.connection);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            ClientList.DataSource = ds.Tables[0].DefaultView;
            Program.CloseConnection();
        }

        private void ReturnHomeClicked(object sender, EventArgs e)
        {
            Program.SearchClientList.Hide();
            Program.HomeForm.Show();
        }

        private void SearchLastNameClicked(object sender, EventArgs e)
        {
            Program.OpenConnection();
            String AllClientsCmd = String.Format("SELECT * FROM Client WHERE LastName = \"{0}\"", LastNameTB.Text);
            MySqlDataAdapter sda = new MySqlDataAdapter(AllClientsCmd, Program.connection);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            ClientList.DataSource = ds.Tables[0].DefaultView;
            Program.CloseConnection();
        }

        private void SearchTelephoneClicked(object sender, EventArgs e)
        {
            Program.OpenConnection();
            String AllClientsCmd = String.Format("SELECT * FROM Client WHERE Phone = \"{0}\"", TelephoneTB.Text);
            MySqlDataAdapter sda = new MySqlDataAdapter(AllClientsCmd, Program.connection);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            ClientList.DataSource = ds.Tables[0].DefaultView;
            Program.CloseConnection();
        }
    }
}
