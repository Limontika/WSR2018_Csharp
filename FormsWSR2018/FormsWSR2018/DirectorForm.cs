using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

        private void buttonReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Данный функционал пока ограничен",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

            /*MySqlConnection conn = DB.GetDBConnection();
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
                DateTime now = DateTime.Now;
                string sql = $"SELECT vendor_code, composition, color, width, height FROM rolls";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                MySqlDataReader reader = cmd.ExecuteReader();
                var path = "D:/myProject/WS-use-C-/reports/";
                var write_path = $@"{path}{now.ToString("dd.MM.yyyy_hhmmss")}.csv";
                Console.WriteLine(write_path.ToString());
                string info = "Выгрузка остатков материалов от " + now;
                string title = "composition;color;width;height";
                using (StreamWriter sw = new StreamWriter(write_path, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(info + '\n');
                    sw.WriteLine(title + '\n');

                    while (reader.Read())
                    {
                        sw.WriteLine("\"" + reader[1] + "\";" + "\t" + "\"" + reader[2] + "\";" + "\t" + "\"" + reader[3] + ";" + "\t" + "\"" + reader[4] + ";");
                    }
                }

                reader.Close();
                conn.Close();

                DialogResult result = MessageBox.Show(
                "Отчет успешно создан, нажмите ОК чтобы посмотореть отчет или Cancle для продолжения работы",
                "Сообщение",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

                if (result == DialogResult.OK)
                {
                    Process.Start($"{write_path}");
                }

            }
            catch
            {
                MessageBox.Show(
                "Ошибка выгрузки отчета",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            }*/
        }
    }
}
