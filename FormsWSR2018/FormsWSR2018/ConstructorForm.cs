using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsWSR2018
{
    public partial class ConstructorForm : Form
    {
        string path = "D:/myProject/WSR2018_Csharp/resources/Ресурсы - Сессия 2/Цеха/";
        public ConstructorForm()
        {
            InitializeComponent();
        }

        Control draggedPiece = null;
        bool resizing = false;
        private Point startDraggingPoint;
        private Size startSize;
        Rectangle rectProposedSize = Rectangle.Empty;

        int resizingMargin = 5;

        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (draggedPiece != null)
            {
                Point pt;
                if (draggedPiece == sender)
                    pt = new Point(e.X, e.Y);
                else
                    pt = draggedPiece.PointToClient((sender as Control).PointToScreen(new Point(e.X, e.Y)));

                draggedPiece.Left += pt.X - this.startDraggingPoint.X;
                draggedPiece.Top += pt.Y - this.startDraggingPoint.Y;
            }
        }
        private void mouseUp(object sender, MouseEventArgs e)
        {
            this.draggedPiece = null;
            this.startDraggingPoint = Point.Empty;
            this.Cursor = Cursors.Default;
        }
        private void mouseDown(object sender, MouseEventArgs e)
        {
            draggedPiece = sender as Control;
            this.Cursor = Cursors.SizeAll;
            this.startDraggingPoint = e.Location;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void ConstructorForm_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            string[] mass_cech = new string[5] { "Заготовительный цех", "Пекарный цех", "Упаковочный цех", "Цех монтажа тортов", "Цех оформления" };

            comboBox1.Items.AddRange(mass_cech);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Заготовительный цех":
                    if (Directory.EnumerateFiles(path + "Запланированные/", "Заготовительный цех.png", SearchOption.TopDirectoryOnly).ToString() == "Заготовительный цех.png")  
                    {
                        pictureBox1.Load(path + "Запланированные/Заготовительный цех.png");
                    }
                    else
                    {
                        pictureBox1.Load(path + "Заготовительный цех.png");
                    }
                    //pictureBox1.Load(path + "Заготовительный цех.png");
                    break;
                case "Пекарный цех":
                    pictureBox1.Load(path + "Пекарный цех.png");
                    break;
                case "Упаковочный цех":
                    pictureBox1.Load(path + "Упаковочный цех.png");
                    break;
                case "Цех монтажа тортов":
                    pictureBox1.Load(path + "Цех монтажа тортов.png");
                    break;
                case "Цех оформления":
                    pictureBox1.Load(path + "Цех оформления.png");
                    break;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Заготовительный цех":
                    pictureBox1.Load(path + "Заготовительный цех.png");
                    FileInfo fileInf = new FileInfo(path + "Запланированные/Заготовительный цех.png");
                    if (fileInf.Exists)
                    {
                        fileInf.Delete();
                    }
                    break;
                case "Пекарный цех":
                    pictureBox1.Load(path + "Пекарный цех.png");
                    fileInf = new FileInfo(path + "Запланированные/Пекарный цех.png");
                    if (fileInf.Exists)
                    {
                        fileInf.Delete();
                    }
                    break;
                case "Упаковочный цех":
                    pictureBox1.Load(path + "Упаковочный цех.png");
                    fileInf = new FileInfo(path + "Запланированные/Упаковочный цех.png");
                    if (fileInf.Exists)
                    {
                        fileInf.Delete();
                    }
                    break;
                case "Цех монтажа тортов":
                    pictureBox1.Load(path + "Цех монтажа тортов.png");
                    fileInf = new FileInfo(path + "Запланированные/Цех монтажа тортов.png");
                    if (fileInf.Exists)
                    {
                        fileInf.Delete();
                    }
                    break;
                case "Цех оформления":
                    pictureBox1.Load(path + "Цех оформления.png");
                    fileInf = new FileInfo(path + "Запланированные/Цех оформления.png");
                    if (fileInf.Exists)
                    {
                        fileInf.Delete();
                    }
                    break;
            }
        }

        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Заготовительный цех":
                    pictureBox1.Image.Save(path + "Запланированные/Заготовительный цех.png");
                    break;
                case "Пекарный цех":
                    pictureBox1.Image.Save(path + "Запланированные/Пекарный цех.png");
                    break;
                case "Упаковочный цех":
                    pictureBox1.Image.Save(path + "Запланированные/Упаковочный цех.png");
                    break;
                case "Цех монтажа тортов":
                    pictureBox1.Image.Save(path + "Запланированные/Цех монтажа тортов.png");
                    break;
                case "Цех оформления":
                    pictureBox1.Image.Save(path + "Запланированные/Цех оформления.png");
                    break;
            }
        }
    }
}
