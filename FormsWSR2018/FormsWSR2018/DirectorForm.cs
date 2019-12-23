﻿using System;
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
    public partial class DirectorForm : Form
    {
        public DirectorForm()
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

        private void buttonAccountingTools_Click(object sender, EventArgs e)
        {
            ToolsForm newForm = new ToolsForm();
            newForm.ShowDialog();
        }

        private void buttonAccountingIngredients_Click(object sender, EventArgs e)
        {
            ListsForm newForm = new ListsForm();
            newForm.ShowDialog();
        }

        private void buttonPlansShopFloor_Click(object sender, EventArgs e)
        {
            ConstructorForm newForm = new ConstructorForm();
            newForm.ShowDialog();
        }

        private void buttonOrdersList_Click(object sender, EventArgs e)
        {
            OrdersListForm newForm = new OrdersListForm();
            newForm.ShowDialog();
        }
    }
}
