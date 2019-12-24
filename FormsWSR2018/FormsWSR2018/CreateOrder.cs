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
    public partial class CreateOrder : Form
    {

        private string role = "Менеджер по продажам";
        private int id_user_this = 1;
        private int id_user = 1;
        private int сounterOrder;

        public CreateOrder()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите вернуться обратно?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
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
            string last_name = "";
            string first_name = "";
            List<string> nameCustomer = new List<string>();

            DateTime pickDate = dateTimePicker1.Value;

            try
            {
                if (role == "Менеджер по продажам")
                {
                    id_user_this = int.Parse(comboBox1.SelectedIndex.ToString())+1;
                    sql = $"SELECT last_name, first_name FROM users WHERE id={id_user_this}";
                }
                else if (role == "Заказчик")
                {
                    sql = $"SELECT last_name, first_name FROM users WHERE id={id_user}";
                }

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    last_name = reader[0].ToString();
                    first_name = reader[1].ToString();
                }

                reader.Close();

                nameCustomer.Add(last_name);
                nameCustomer.Add(first_name);

                string numberOrder = "";

                if (сounterOrder < 10)
                {
                    numberOrder = pickDate.ToString("ddMMyyyy") + nameCustomer[0].First() + nameCustomer[1].First() + 0 + сounterOrder;
                }
                else
                {
                    numberOrder = pickDate.ToString("ddMMyyyy") + nameCustomer[0].First() + nameCustomer[1].First() + сounterOrder;
                }

                Console.WriteLine();

                int cost = 1000;
                string text = "";

                if (role == "Менеджер по продажам")
                {
                    id_user_this = int.Parse(comboBox1.SelectedIndex.ToString()) + 1;
                    sql = $"INSERT orders( description, created_at, updated_at, title, cost, customer_id, manager_id, state) VALUES ('{textBox1.Text.ToString()}','{pickDate}','{pickDate.AddDays(14)}', '{textBox2.Text.ToString()}', '{cost.ToString()}', {id_user_this}, {id_user}, 'Составление спецификации')";
                    cost += 100;
                    text = $"Заказ оформлен и поставленн статус 'Составление спецификации'. Номер заказа: {numberOrder}";
                }
                else if (role == "Заказчик")
                {
                    id_user_this = int.Parse(comboBox1.SelectedIndex.ToString()) + 1;
                    sql = $"INSERT orders( description, created_at, updated_at, title, cost, customer_id, manager_id, state) VALUES ('{textBox1.Text.ToString()}','{pickDate}','{pickDate.AddDays(14)}', '{textBox2.Text.ToString()}', '{cost.ToString()}', {id_user}, {id_user_this}, 'Новый')";
                    cost += 100;
                    text = $"Заказ отправлен на проверку. Номер заказа: {numberOrder}";
                }

                cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show(
                text,
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

            }
            catch(Exception er)
            {
                MessageBox.Show(
                $"Ошибка {er}",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            }

        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            string sql = "";
            List<string> listUser = new List<string>();

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

            if (role == "Менеджер по продажам")
            {
                label3.Text = "Заказчик";
                sql = $"SELECT last_name, first_name FROM users WHERE role = 'Заказчик'";
            }
            else if (role == "Заказчик")
            {

                sql = $"SELECT last_name, first_name FROM users WHERE role = 'Менеджер по продажам'";

            }

            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listUser.Add(reader[0] + " " + reader[1]);
                }

                comboBox1.Items.AddRange(listUser.ToArray());

            }
            catch(Exception er)
            {
               MessageBox.Show(
               $"Ошибка {er}",
               "Сообщение",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error,
               MessageBoxDefaultButton.Button1);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form createCustomer = new Registration();
            createCustomer.ShowDialog();
        }
    }
}
