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
        private int id_user;
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
                Close();
        }

        private void buttonAddNote_Click(object sender, EventArgs e)
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
            List<string> nameCustomer = new List<string>();
            //int count = dataGridView1.RowCount;
            DateTime pickDate = dateTimePicker1.Value;

            try
            {
                if (role == "Менеджер по продажам")
                {
                    string[] temp = textBox3.Text.Split(new char[] { ' ' });
                    foreach (var item in temp)
                    {
                        nameCustomer.Add(item);
                    }
                }
                else if (role == "Заказчик")
                {

                    sql = $"SELECT last_name, first_name FROM users WHERE id={id_user}";
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    foreach (var item in reader)
                    {
                        nameCustomer.Add(item.ToString());
                    }

                }

                string numberOrder = "";

                if (сounterOrder < 10)
                {
                    numberOrder = pickDate.ToString("ddMMyyyy") + nameCustomer[0].First() + nameCustomer[1].First() + 0 + сounterOrder;
                }
                else
                {
                    numberOrder = pickDate.ToString("ddMMyyyy") + nameCustomer[0].First() + nameCustomer[1].First() + сounterOrder;
                }

                // TODO: Проверить заполение заказчика и сделать заполнение менеджера
                dataGridView1.Rows.Add(numberOrder, textBox2.Text.ToString(), nameCustomer[0] + " " + nameCustomer[1], "Василий", pickDate, textBox1.Text.ToString());

                MessageBox.Show(
                "Добавлено!",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

            }
            catch
            {
                MessageBox.Show(
                "Ошибка проверте правильность данных!",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            }


        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {

            // TODO: сделать отправку в базу данных с dataGridView

            /*try
            {
                sql = $"INSERT orders( customer_id, created_at, updated_at) VALUES ({id_user},'{now}','{now}'); ";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                id_order = cmd.LastInsertedId;
                int i = 0;

                while (i != count)
                {
                    sql = $"INSERT orders_has_products (orders_id, products_vendor_code, quantity) VALUES ({id_order}, {dataGridView1.Rows[i].Cells[4].Value}, {dataGridView1.Rows[i].Cells[2].Value}); ";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    i++;
                }

                conn.Close();

                MessageBox.Show(
                "Заказ произведен",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            }

            catch (Exception er)
            {
                MessageBox.Show(
                $"Не удалось передать заказ, повторите попытку (Ошибка {er})",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            }*/

           
        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            if (role == "Менеджер по продажам")
            {
                label3.Text = "Заказчик";
                comboBox1.Dispose();

            }else if(role == "Заказчик")
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

                String loginUser = textBox1.Text;
                String passUser = textBox2.Text;

                List<string> listManager = new List<string>();

                try
                {
                    // TODO: Написать запрос к базе на получение id_role
                    string sql = $"SELECT last_name, first_name FROM users WHERE role = 'Менеджер по продажам'";
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        listManager.Add(reader[0] + " " + reader[1]);
                    }

                    comboBox1.Items.AddRange(listManager.ToArray());
                }
                catch
                {
                    MessageBox.Show(
                    "Логин или пароль неправильны",
                    "Сообщение",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
