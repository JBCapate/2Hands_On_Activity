using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02HandsOnActivity1
{
    public partial class CustomerView : Form
    {
        CashierClass cashier;
        public CustomerView()
        {
            InitializeComponent();
            cashier = new CashierClass();
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            CashierClass.CashierQueue.Contains(CashierClass.getNumberInQueue);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblQueue_Click(object sender, EventArgs e)
        {

        }
    }
}
