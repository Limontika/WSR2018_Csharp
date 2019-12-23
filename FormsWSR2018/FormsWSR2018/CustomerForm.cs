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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите вернуться обратно на форму авторизации",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
                Close();
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            CreateOrder newForm = new CreateOrder();
            newForm.ShowDialog();
        }

        private void buttonOrdersList_Click(object sender, EventArgs e)
        {
            OrdersListForm newForm = new OrdersListForm();
            newForm.ShowDialog();
        }
    }
}
