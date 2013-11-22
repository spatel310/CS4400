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
    public partial class SearchClientList : Form
    {
        public SearchClientList()
        {
            InitializeComponent();
        }

        private void ReturnHomeClicked(object sender, EventArgs e)
        {
            Program.SearchClientList.Hide();
            Program.HomeForm.Show();
        }
    }
}
