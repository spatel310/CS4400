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
    public partial class GroceryList : Form
    {
        public GroceryList()
        {
            InitializeComponent();

            viewGroceries();


        }

        public void viewGroceries()
        {
            string initialCmd = String.Format("SELECT ProductName, ThisMoQuantity, LastMoQuantity FROM ProductQuantities NATURAL JOIN ProductQuantitiesLastMo");
            MySqlDataAdapter sda = new MySqlDataAdapter(initialCmd, Program.connection);
            Program.OpenConnection();
            DataSet ds = new DataSet();
            sda.Fill(ds);
            GroceryTable.DataSource = ds.Tables[0].DefaultView;
            Program.CloseConnection();
        }

        private void ReturnHome_Click(object sender, EventArgs e)
        {
            Program.GroceryList.Hide();
            Program.HomeForm.Show();
        }
    }
}
