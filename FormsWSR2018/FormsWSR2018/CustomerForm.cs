using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsWSR2018
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void buttonOrdersList_Click(object sender, EventArgs e)
        {
            OrdersListForm newForm = new OrdersListForm();
            newForm.ShowDialog();
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            CreateOrder newForm = new CreateOrder();
            newForm.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();   
        }
    }
}
