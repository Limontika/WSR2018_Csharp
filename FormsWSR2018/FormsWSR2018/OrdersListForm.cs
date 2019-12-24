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
    public partial class OrdersListForm : Form
    {
        public OrdersListForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите вернуться обратно?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
                Close();
        }

        private void buttonChangeStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Статус изменён",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form createOrder = new CreateOrder();
            createOrder.ShowDialog();
        }
    }
}
