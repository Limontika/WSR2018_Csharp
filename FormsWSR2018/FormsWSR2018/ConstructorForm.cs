using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsWSR2018
{
    public partial class ConstructorForm : Form
    {
        string path = "D:/myProject/WSR2018_Csharp/resources/Ресурсы - Сессия 2/Цеха/";
        string path_img = "D:/myProject/WSR2018_Csharp/resources/Ресурсы - Сессия 2/Значки/";

        List<PictureBox> pictureBox = new List<PictureBox>();

        public ConstructorForm()
        {
            InitializeComponent();
            AutoScroll = true;
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
                    //Console.WriteLine(Directory.EnumerateFiles(path + "Запланированные/", "Заготовительный цех.png", SearchOption.TopDirectoryOnly).Count());
                    if (Directory.EnumerateFiles(path + "Запланированные/", "Заготовительный цех.png", SearchOption.TopDirectoryOnly).Count() == 1)  
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
                    if (Directory.EnumerateFiles(path + "Запланированные/", "Пекарный цех.png", SearchOption.TopDirectoryOnly).Count() == 1)
                    {
                        pictureBox1.Load(path + "Запланированные/Пекарный цех.png");
                    }
                    else
                    {
                        pictureBox1.Load(path + "Пекарный цех.png");
                    }
                    break;
                case "Упаковочный цех":
                    if (Directory.EnumerateFiles(path + "Запланированные/", "Упаковочный цех.png", SearchOption.TopDirectoryOnly).Count() == 1)
                    {
                        pictureBox1.Load(path + "Запланированные/Упаковочный цех.png");
                    }
                    else
                    {
                        pictureBox1.Load(path + "Упаковочный цех.png");
                    }
                    break;
                case "Цех монтажа тортов":
                    if (Directory.EnumerateFiles(path + "Запланированные/", "Цех монтажа тортов.png", SearchOption.TopDirectoryOnly).Count() == 1)
                    {
                        pictureBox1.Load(path + "Запланированные/Цех монтажа тортов.png");
                    }
                    else
                    {
                        pictureBox1.Load(path + "Цех монтажа тортов.png");
                    }
                    break;
                case "Цех оформления":
                    if (Directory.EnumerateFiles(path + "Запланированные/", "Цех оформления.png", SearchOption.TopDirectoryOnly).Count() == 1)
                    {
                        pictureBox1.Load(path + "Запланированные/Цех оформления.png");
                    }
                    else
                    {
                        pictureBox1.Load(path + "Цех оформления.png");
                    }
                    break;
            }
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

            foreach (var item in pictureBox)
            {
                item.SendToBack();
            }

            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
            pictureBox1.Size = bmp.Size;
            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            pictureBox1.Image = bmp;

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
            foreach (var item in pictureBox)
            {
                item.Dispose();
            }
        }

        private void mouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine((sender as PictureBox).Name);

            var pb = new PictureBox();

            switch ((sender as PictureBox).Name.ToString())
            {
                case "pictureBox2":
                    pb.Location = new Point(100, 28);
                    pb.Size = new Size(74, 56);

                    pb.Image = Image.FromFile(path_img + "Equipment.png");
                    break;
                case "pictureBox3":
                    pb.Location = new Point(100, 113);
                    pb.Size = new Size(86, 35);

                    pb.Image = Image.FromFile(path_img + "Exit.jpg");
                    break;
                case "pictureBox4":
                    pb.Location = new Point(100, 184);
                    pb.Size = new Size(51, 63);

                    pb.Image = Image.FromFile(path_img + "FireExtinguisher.png");
                    break;
                case "pictureBox5":
                    pb.Location = new Point(100, 276);
                    pb.Size = new Size(53, 56);

                    pb.Image = Image.FromFile(path_img + "FirstAid.png");
                    break;
            }
            
            pb.SizeMode = PictureBoxSizeMode.StretchImage;

            pb.MouseDown += new MouseEventHandler(mouseDown);
            pb.MouseUp += new MouseEventHandler(mouseUp);
            pb.MouseMove += new MouseEventHandler(mouseMove);

            panel1.Controls.Add(pb);
            pb.BringToFront();
            pictureBox.Add(pb);
        }
    }
}
