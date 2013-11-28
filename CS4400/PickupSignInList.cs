using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CS4400
{
    public partial class PickupSignInList : Form
    {
        public PickupSignInList()
        {
            InitializeComponent();


            MySqlDataAdapter sda = new MySqlDataAdapter("select * from Bag", Program.connection);
            Program.OpenConnection();
            DataSet ds = new DataSet();
            Debug.Print("things are happening...");
            sda.Fill(ds);
            PickUpSignInListTable.DataSource = ds.Tables[0].DefaultView;
            Program.CloseConnection();
            //PickUpSignInListTable.DataBind();

               
        }
 
        private void ReturnHomeClicked(object sender, EventArgs e)
        {
            Program.PickupSignInList.Hide();
            Program.HomeForm.Show();
        }

        private void EnterDayClicked(object sender, EventArgs e)
        {

        }
    }
}
