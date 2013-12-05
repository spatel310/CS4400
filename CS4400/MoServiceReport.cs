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
    public partial class MoServiceReport : Form
    {
        public MoServiceReport()
        {
            InitializeComponent();
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

        }

        private void LastMonth_Click(object sender, EventArgs e)
        {

        }
    }
}
