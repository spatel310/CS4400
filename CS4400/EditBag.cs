using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace CS4400
{
    public partial class EditBag : Form
    {
        public EditBag()
        {
            InitializeComponent();
            try
            {
                string bagcontentsquery = String.Format("SELECT ProductName, CurrentMonthQty FROM Holds WHERE BagName = \"{0}\"", BagList.currentBagName);
                MySqlDataAdapter sda = new MySqlDataAdapter(bagcontentsquery, Program.connection);


                Program.OpenConnection();
                DataSet ds = new DataSet();
                sda.Fill(ds);
                EditBagTable.DataSource = ds.Tables[0].DefaultView;
                Program.CloseConnection();

                EditBagTable.Columns[0].ReadOnly = true;
                EditBagTable.Columns[1].ReadOnly = false;
                //PickUpSignInListTable.DataBind();

                Program.OpenConnection();
                string getProds = "SELECT ProductName FROM Product";
                MySqlCommand myCommand = new MySqlCommand(getProds, Program.connection);
                MySqlDataReader myReader;
                myReader = myCommand.ExecuteReader();
                try
                {
                    while (myReader.Read())
                    {
                        Debug.Print(myReader.GetString(0));
                        newProduct1.Items.Add(myReader.GetString(0));
                        newProduct2.Items.Add(myReader.GetString(0));
                        newProduct3.Items.Add(myReader.GetString(0));
                    }
                }
                finally
                {
                    myReader.Close();
                    Program.CloseConnection();
                }
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

        private void ReturnToBagListClicked(object sender, EventArgs e)
        {
            this.Close();
            Program.BagList.RefreshForm();
            Program.BagList.Show();
        }

        private void UpateBagClicked(object sender, EventArgs e)
        {
            if(DateTime.Today.Day != DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month))
            {
                MessageBox.Show("Sorry! You can't edit a bag unless it's the last day of the month!");
                   
            }
            try
            {
                string product = "";
                string quantity = "";
                string updateProduct = "";
                MySqlCommand cmd;
                Program.OpenConnection();
                for (int rows = 0; rows < EditBagTable.Rows.Count - 1; rows++)
                {
                    product = EditBagTable.Rows[rows].Cells[0].Value.ToString();
                    quantity = EditBagTable.Rows[rows].Cells[1].Value.ToString();

                    updateProduct = String.Format("UPDATE Holds SET CurrentMonthQty={0} WHERE ProductName = \"{1}\" AND BagName = \"{2}\"", quantity, product, BagList.currentBagName);

                    //create DropOffTransaction on today's date
                    
                    cmd = new MySqlCommand(updateProduct, Program.connection);
                    cmd.ExecuteNonQuery();

                }

                if (newProduct1.SelectedIndex > -1)
                {
                    String addProd = string.Format("INSERT INTO Holds VALUES(\"{0}\",\"{1}\",{2},{3})", BagList.currentBagName, newProduct1.SelectedItem.ToString(), newProd1Quant.Text, 0);
                    Debug.Print(addProd);
                    cmd = new MySqlCommand(addProd, Program.connection);
                    cmd.ExecuteNonQuery();
                } 
                if (newProduct2.SelectedIndex > -1)
                {
                    String addProd = string.Format("INSERT INTO Holds VALUES(\"{0}\",\"{1}\",{2},{3})", BagList.currentBagName, newProduct2.SelectedItem.ToString(), newProd2Quant.Text, 0);
                    cmd = new MySqlCommand(addProd, Program.connection);
                    cmd.ExecuteNonQuery();
                } 
                if (newProduct3.SelectedIndex > -1)
                {
                    String addProd = string.Format("INSERT INTO Holds VALUES(\"{0}\",\"{1}\",{2},{3})", BagList.currentBagName, newProduct3.SelectedItem.ToString(), newProd3Quant.Text, 0);
                    cmd = new MySqlCommand(addProd, Program.connection);
                    cmd.ExecuteNonQuery();
                }
                Program.CloseConnection();
                Result.Text = "Bag Update Successful!";
            }
            catch
            {
                Result.Text = "Bag Update failed!";
            }
        }
    }
}
