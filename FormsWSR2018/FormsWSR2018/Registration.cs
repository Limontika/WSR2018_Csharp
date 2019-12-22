using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace FormsWSR2018
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0) button1.Enabled = false;
            else button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex def_passwd = new Regex(@"(?=.*[a-z])(?=.*[A-Z])[a-zA-Z]{5,20}");
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                if (textBox2.Text != textBox3.Text)
                {
                    MessageBox.Show(
                        "Пароли не совпадают",
                        "Сообщение",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                }
                else if (textBox2.Text.IndexOf(textBox1.Text) == -1 && def_passwd.IsMatch(textBox2.Text) && textBox2.Text == textBox3.Text)
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

                    try
                    {
                        // TODO: Втавить запрос к базе данных!

                        //string sql = $"INSERT users (login, password, role_id) VALUES ('{textBox1.Text}', '{textBox2.Text}', 1);";
                        /*MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();*/

                        MessageBox.Show(
                        $"Пользователь '{textBox1.Text}' был успешно добавлен",
                        "Сообщение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                    }
                    catch
                    {
                        MessageBox.Show(
                        "Неполучилось создать пользователя, обратитесь к системному админестратору",
                        "Сообщение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                    }

                }
                else
                {
                    MessageBox.Show(
                    "Неправильный логин или пароль",
                    "Сообщение",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show(
                  "Введите пароли ПОЖАЛУЙСТА!",
                  "Сообщение",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error,
                  MessageBoxDefaultButton.Button1);

            }
        }
    }
}
