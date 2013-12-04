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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();

            try
            {
                string initialCmd = String.Format("SELECT ProductName, ThisMoQuantity, Cost FROM ProductQuantities NATURAL JOIN Product");
                MySqlDataAdapter sda = new MySqlDataAdapter(initialCmd, Program.connection);
                Program.OpenConnection();
                DataSet ds = new DataSet();
                sda.Fill(ds);
                ProductsTable.DataSource = ds.Tables[0].DefaultView;
                Program.CloseConnection();
            }
            catch
            {

            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
