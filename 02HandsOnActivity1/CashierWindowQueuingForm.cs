using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _02HandsOnActivity1
{
    public partial class CashierWindowQueuingForm : Form
    {
        CustomerView customerView;

        public CashierWindowQueuingForm()
        {
            InitializeComponent();
            customerView = new CustomerView();
        }

 

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void CashierWindowQueuingForm_Load(object sender, EventArgs e)
        {
            customerView.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           
            string next = CashierClass.CashierQueue.Peek();
            customerView.lblQueue.Text = next;
            CashierClass.CashierQueue.Dequeue();
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void listCashierQueue_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }


        
    }
}
