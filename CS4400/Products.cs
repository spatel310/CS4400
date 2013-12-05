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

            allProducts();
        }

        private void ReturnHomeClicked(object sender, EventArgs e)
        {
            Program.Products.Hide();
            Program.HomeForm.Show();
        }



        public void allProducts()
        {
            string initialCmd = String.Format("SELECT ProductName, ThisMoQuantity, Cost FROM ProductQuantities NATURAL JOIN Product");
            MySqlDataAdapter sda = new MySqlDataAdapter(initialCmd, Program.connection);
            Program.OpenConnection();
            DataSet ds = new DataSet();
            sda.Fill(ds);
            ProductsTable.DataSource = ds.Tables[0].DefaultView;
            Program.CloseConnection();
        }

        private void ListAllProductsClicked(object sender, EventArgs e)
        {
            allProducts();
        }

        private void CreateProductClicked(object sender, EventArgs e)
        {
            Program.Products.Hide();
            NewProduct NewProduct = new NewProduct();
            NewProduct.MdiParent = Program.MainForm;
            NewProduct.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            NewProduct.Show();
        }

        private void SearchClicked(object sender, EventArgs e)
        {
            string initialCmd = String.Format("SELECT ProductName, ThisMoQuantity, Cost FROM ProductQuantities NATURAL JOIN Product WHERE ProductName = \"{0}\"", ProductSearch.Text);
            MySqlDataAdapter sda = new MySqlDataAdapter(initialCmd, Program.connection);
            Program.OpenConnection();
            DataSet ds = new DataSet();
            sda.Fill(ds);
            ProductsTable.DataSource = ds.Tables[0].DefaultView;
            Program.CloseConnection();
        }
    }
}
