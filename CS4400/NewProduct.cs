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
    public partial class NewProduct : Form
    {
        public NewProduct()
        {
            InitializeComponent();
        }

        private void SaveProductClicked(object sender, EventArgs e)
        {

            if (NameTB.Text != "" && SourceTB.Text != "" && CostPerUnitTB.Text != "")
            {
                if (Convert.ToDecimal(CostPerUnitTB.Text) >= 0)
                {
                    Program.OpenConnection();
                    String insertCmd = String.Format("INSERT INTO Product VALUES(\"{0}\",{1},\"{2}\")", NameTB.Text, CostPerUnitTB.Text, SourceTB.Text);
                    MySqlCommand cmd = new MySqlCommand(insertCmd, Program.connection);
                    cmd.ExecuteNonQuery();
                    Program.CloseConnection();

                    this.Close();
                    Program.HomeForm.Show();
                }
                else
                {
                    DialogResult pickup = MessageBox.Show("Cost must be non-negative!");
                }
            }
            else
            {
                DialogResult pickup = MessageBox.Show("All fields must be filled!");
            }
        }

        private void ReturnToProductsClicked(object sender, EventArgs e)
        {
            this.Close();
            Program.Products.Show();
        }

        private void ReturnHomeClicked(object sender, EventArgs e)
        {
            this.Close();
            Program.HomeForm.Show();
        }

    }
}
