using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS4400
{

    /// <summary>
    /// Weoajf;woiejaw;eiba'iwoe;flajhwefn;[a;owiej;aweoritTYLERWASHERE
    /// </summary>
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x00A5) //WM_NCRBUTTONUP
            {
                //eatup
            }
            else if (m.Msg == 0x0084)//WM_NCHITTEST
            {
                //eatup
            }
            else
            {
                base.WndProc(ref m);
            }
        }
        private void OnForm_Load(object sender, EventArgs e)
        {
            this.MainMenuStrip = new MenuStrip();
        }

        private void PickupsClicked(object sender, EventArgs e)
        {
            Program.HomeForm.Hide();
            Program.PickupSignInList.Show();
        }

        private void BagsClicked(object sender, EventArgs e)
        {
            Program.HomeForm.Hide();
            Program.BagList.Show();
        }

        private void DropoffsClicked(object sender, EventArgs e)
        {
            Program.HomeForm.Hide();
            Program.BagDropoff.Show();
        }

        private void ClientsClicked(object sender, EventArgs e)
        {
            Program.HomeForm.Hide();
            Program.SearchClientList.Show();
        }

        private void ServiceReportClicked(object sender, EventArgs e)
        {
            Program.HomeForm.Hide();
            Program.MonthlyServiceReport.Show();
        }

        private void ProductsClicked(object sender, EventArgs e)
        {
            Program.HomeForm.Hide();
            Program.Products.Show();
        }

        private void LogoutClicked(object sender, EventArgs e)
        {
            Program.HomeForm.Hide();
            Program.LogInForm.Show();
        }

        private void NewClientClicked(object sender, EventArgs e)
        {
            Program.HomeForm.Hide();
            Program.NewClient.Show();
        }
    }
}
