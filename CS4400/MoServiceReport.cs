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
    public partial class MoServiceReport : Form
    {
        public MoServiceReport()
        {
            InitializeComponent();

            RefreshMonthlyServiceReportTable();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReturnHome_Click(object sender, EventArgs e)
        {
            Program.MoServiceReport.Hide();
            Program.HomeForm.Show();
        }

        private void Active_Click(object sender, EventArgs e)
        {
            RefreshMonthlyServiceReportTable();
        }

        private void LastMonth_Click(object sender, EventArgs e)
        {
            string initialCmd = String.Format("SELECT * FROM BeautifulServiceTableLastMo");
            MySqlDataAdapter sda = new MySqlDataAdapter(initialCmd, Program.connection);
            Program.OpenConnection();
            DataSet ds = new DataSet();
            sda.Fill(ds);
            ServiceReport.DataSource = ds.Tables[0].DefaultView;
            Program.CloseConnection();
        }

        public void RefreshMonthlyServiceReportTable()
        {
            string initialCmd = String.Format("SELECT * FROM BeautifulServiceTable");
            MySqlDataAdapter sda = new MySqlDataAdapter(initialCmd, Program.connection);
            Program.OpenConnection();
            DataSet ds = new DataSet();
            sda.Fill(ds);
            ServiceReport.DataSource = ds.Tables[0].DefaultView;
            Program.CloseConnection();
        }
    }
}
