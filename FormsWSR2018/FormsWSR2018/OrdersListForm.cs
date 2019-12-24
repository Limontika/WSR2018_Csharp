using MySql.Data.MySqlClient;
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

        private string role = "Заказчик";
        private int id_user;

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

        private void OrdersListForm_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = DB.GetDBConnection();
            try
            {
                conn.Open();
            }
            catch
            {
                MessageBox.Show(
                "Проблемы с подключением к БД",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            }

            string sql = "";

            // TODO: Пройтись по id юзерам(т.е. проверить после передачи на форму будет ли работать данный код)

            try
            {
                if (role == "Заказчик")
                {
                    sql = $"SELECT id, created_at, title, state, cost, customer_id, updated_at, manager_id FROM orders WHERE customer_id= 8";
                }
                else if (role == "Менеджер по продажам")
                {
                    //this.button4.Hide();
                    sql = $"SELECT id, created_at, title, state, cost, customer_id, updated_at, manager_id FROM orders WHERE manager_id = {id_user} OR state='Новый'";
                }

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView2.Rows.Add($"№{reader[0]} dd:{reader[1]}", reader[2], reader[3], reader[4], reader[5], reader[6], reader[7]);
                }
                reader.Close();
                conn.Close();

            }

            catch (Exception er)
            {
                MessageBox.Show(
                $"Не удалось передать заказ, повторите попытку (Ошибка {er})",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            }
        }
    }
}
