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
using System.Diagnostics;

namespace CS4400
{
    //this is the bag list
    public partial class BagList : Form
    {
        public static string currentBagName = "";
        public BagList()
        {
            InitializeComponent();

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT b.BagName, NumItems, IFNULL(NumClientsBag,0) AS NumClientsBag, IFNULL(CostOfBag,0.00) AS CostOfBag FROM BagStats b LEFT JOIN ClientsPerBag c ON b.BagName = c.BagName", Program.connection);
                Program.OpenConnection();
                DataSet ds = new DataSet();
                sda.Fill(ds);
                BagListTable.DataSource = ds.Tables[0].DefaultView;
                Program.CloseConnection();
                //PickUpSignInListTable.DataBind();

            }
            catch (DataException e)
            {
                Debug.Print(e.Message);
            }
        }

        private void ReturnHomeClicked(object sender, EventArgs e)
        {
            Program.BagList.Hide();
            Program.HomeForm.Show();
        }

        private void BagSelected(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            Debug.Print(Convert.ToString(BagListTable.Rows[row].Cells.Count));
            currentBagName = Convert.ToString(BagListTable.Rows[row].Cells[0].Value);

            
        }

        private void ViewBagClicked(object sender, EventArgs e)
        {
            Program.BagList.Hide();

            ViewBag viewbag = new ViewBag();
            viewbag.MdiParent = Program.MainForm;
            viewbag.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            viewbag.Show();
        }
        public void RefreshForm()
        {
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT b.BagName, NumItems, IFNULL(NumClientsBag,0) AS NumClientsBag, IFNULL(CostOfBag,0.00) AS CostOfBag FROM BagStats b LEFT JOIN ClientsPerBag c ON b.BagName = c.BagName", Program.connection);


                Program.OpenConnection();
                DataSet ds = new DataSet();
                sda.Fill(ds);
                BagListTable.DataSource = ds.Tables[0].DefaultView;
                Program.CloseConnection();
                //PickUpSignInListTable.DataBind();

            }
            catch (DataException e)
            {
                Debug.Print(e.Message);
            }
        }

        private void EditBagClicked(object sender, EventArgs e)
        {
            Program.BagList.Hide();

            EditBag editbag = new EditBag() ;
            editbag.MdiParent = Program.MainForm;
            editbag.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            editbag.Show();
        }
    }
}
