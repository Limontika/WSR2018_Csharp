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
    public partial class Autorization : Form
    {

        private int id_user;
        private string role;
        private int counter;

        public Autorization()
        {
            InitializeComponent();
        }

        private void Autorization_Load(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0) button1.Enabled = false;
            else button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
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

            try
            {
                // TODO: Написать запрос к базе на получение id_role
                string sql = $"SELECT id, role FROM users WHERE login='{loginUser}' AND password='{passUser}'";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int.TryParse(reader[0].ToString(), out id_user);
                role = reader[1].ToString();
            }
            catch
            {
                counter += 1;
                
                MessageBox.Show(
                 "Логин или пароль неправильны",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            }

            if (counter == 3)
            {
                this.Enabled = false;
                System.Threading.Thread.Sleep(5000);
                this.Enabled = true;
            }


            // TODO: Сделать переходы в такой констуркции, так же передавать id_user и id_role на формы которым это жизненно необходимо
            if (role == "Заказчик")
            {
                /*Form customer = new Заказчик(id_user, role);
                customer.ShowDialog();*/
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else if (role == "Мастер")
            {
               /* Form storekeeper = new storekeeper();
                storekeeper.ShowDialog();*/
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else if (role == "Менеджер по закупкам")
            {
                /*Form manager = new manager(id_user, role);
                manager.ShowDialog();*/
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else if (role == "Менеджер по продажам")
            {
                /*Form director = new director(id_user, role);
                director.ShowDialog();*/
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else if (role == "Директор")
            {
                /*Form director = new director(id_user, role);
                director.ShowDialog();*/
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void Autorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
