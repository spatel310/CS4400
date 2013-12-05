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
    public partial class ViewBag : Form
    {
        public ViewBag()
        {
            InitializeComponent();
            try
            {
                string bagcontentsquery = String.Format("SELECT ProductName, CurrentMonthQty FROM Holds WHERE BagName = \"{0}\"",BagList.currentBagName);
                MySqlDataAdapter sda = new MySqlDataAdapter(bagcontentsquery, Program.connection);


                Program.OpenConnection();
                DataSet ds = new DataSet();
                sda.Fill(ds);
                BagContentsTable.DataSource = ds.Tables[0].DefaultView;
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
            this.Close();
            Program.HomeForm.Show();
        }

        private void ReturnToBagListClicked(object sender, EventArgs e)
        {
            this.Close();
            Program.BagList.RefreshForm();
            Program.BagList.Show();
        }
    }
}
