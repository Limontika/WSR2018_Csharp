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
using WindowsFormsApp1;

namespace FormsWSR2018
{
    public partial class Autorization : Form
    {
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
                //string sql = $"SELECT id, role_id FROM users WHERE login='{loginUser}' AND password='{passUser}'";
               /* MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();*/
                /*int.TryParse(reader[0].ToString(), out id_user);
                int.TryParse(reader[1].ToString(), out id_role);*/
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


            // TODO: Сделать переходы в такой констуркции, так же передавать id_user и id_role на формы которым это жизненно необходимо
            /*if (id_role == 1)
            {
                Form customer = new Заказчик(id_user, id_role);
                customer.ShowDialog();
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else if (id_role == 2)
            {
                Form storekeeper = new storekeeper();
                storekeeper.ShowDialog();
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else if (id_role == 3)
            {
                Form manager = new manager(id_user, id_role);
                manager.ShowDialog();
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else if (id_role == 4)
            {
                Form director = new director(id_user, id_role);
                director.ShowDialog();
                textBox1.Text = "";
                textBox2.Text = "";
            }*/
        }

        private void Autorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
