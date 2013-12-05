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
    public partial class GroceryList : Form
    {
        public GroceryList()
        {
            InitializeComponent();
        }

        private void ReturnHome_Click(object sender, EventArgs e)
        {
            Program.GroceryList.Hide();
            Program.HomeForm.Show();
        }
    }
}
