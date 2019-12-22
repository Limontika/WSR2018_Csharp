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
    public partial class StoreKeeperForm : Form
    {
        public StoreKeeperForm()
        {
            InitializeComponent();
        }

        private void buttonAccountingIngredients_Click(object sender, EventArgs e)
        {
            ListsForm newForm = new ListsForm();
            newForm.ShowDialog();
        }

        private void buttonOrdersList_Click(object sender, EventArgs e)
        {
            OrdersListForm newForm = new OrdersListForm();
            newForm.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
