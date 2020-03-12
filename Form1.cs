using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            g = panelMain.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }
        private Graphics g, gimg;
        private BufferedGraphicsContext bgc = BufferedGraphicsManager.Current;
        private BufferedGraphics bg;

        private Image img=null;
        private Image img2 = null;

        private Pen pen1 = new Pen(Color.Black,3);
        private Brush brush1;
        private Point startPoint, endPoint;

        private int panelWidth { get; set; }
        private int panelHeight { get; set; }

        bool created = false, paint = false;

        private enum Figure { Line, Rectangle, Ellipse, Star, Arrow }
        private Figure pickedFigure;

        private enum Item { Pen,Eraser}
        private Item pickedItem;

        private void toolStripTextBoxSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.Filter = "Фаил картинки в формате JPG|*.jpg  |Фаил картинки в формате PNG|*.png";
            var res = saveFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                img.Save($"{saveFileDialog1.FileName}", ImageFormat.Jpeg);
            }
        }

        private void toolStripMenuItemOpen1_Click(object sender, EventArgs e)
        {
            var res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                img2 = new Bitmap(Image.FromFile(openFileDialog1.FileName));

                gimg = Graphics.FromImage(img2);
                g = panelMain.CreateGraphics();

                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                gimg.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                gimg.DrawImage(img2, 0, 0);
                g.DrawImage(img2, 0, 0);
                img = img2;
            }
        }
        private void toolStripMenuItemOpen2_Click(object sender, EventArgs e)//открываем по размеру картинки
        {
            var res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK) 
            { 

                img2 = new Bitmap(Image.FromFile(openFileDialog1.FileName));
                if(img2.Width >=panelMain.MinimumSize.Width && img2.Height >= panelMain.MinimumSize.Height && img2.Width <= 1455 && img2.Height <= 741)
                {
                    this.Width = img2.Width;
                    this.Height = img2.Height;

                    gimg = Graphics.FromImage(img2);
                    
                    g = panelMain.CreateGraphics();

                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    gimg.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    gimg.DrawImage(img2, 0, 0);
                    g.DrawImage(img2, 0, 0);
                    img = img2;
                }
                //устанавливаем порог сверху и снизу
                //изменяем размеры формы(панели) под размеры картинки и вставляем через вторую картинку
            }
        }
        private void toolStripComboBoxClear_Click(object sender, EventArgs e)
        {
            if (created)
            {
                panelMain.Refresh();
                gimg.Clear(Color.White);
                g.Clear(Color.White);
            }
        }
        private void toolStripTextBoxAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello,its my paint v2.0");
        }
        private void ChangeItem(object sender, EventArgs e)
        {
            switch (((PictureBox)sender).Name)
            {
                case "pictureBoxPen":
                    if (pen1.Color == Color.White)
                    {
                        if (panelCol1.BackColor == SystemColors.Control)
                        {
                            pen1.Color = Color.Black;
                            panelCol1.BackColor = Color.Black;
                        }
                        pen1.Color = panelCol1.BackColor;
                    }
                    pictureBoxEraser.BorderStyle = BorderStyle.None;
                    pictureBoxPen.BorderStyle = BorderStyle.Fixed3D;
                    pickedItem = Item.Pen;
                    break;
                case "pictureBoxEraser":
                    pen1.Color = Color.White;
                    pictureBoxEraser.BorderStyle = BorderStyle.Fixed3D;
                    pictureBoxPen.BorderStyle = BorderStyle.None;
                    pickedItem = Item.Eraser;
                    break;
                default:
                    break;
            }
        }
        private void ChangeFigure(object sender, EventArgs e)
        {
            switch (((PictureBox)sender).Name)
            {
                case "pictureBoxRectangle":
                    pickedFigure = Figure.Rectangle;
                    pictureBoxRectangle.BorderStyle = BorderStyle.Fixed3D;
                    pictureBoxLine.BorderStyle = BorderStyle.None;
                    pictureBoxEllipse.BorderStyle = BorderStyle.None;
                    pictureBoxArrow.BorderStyle = BorderStyle.None;
                    pictureBoxStar.BorderStyle = BorderStyle.None;
                    break;
                case "pictureBoxLine":
                    pickedFigure = Figure.Line;
                    pictureBoxRectangle.BorderStyle = BorderStyle.None;
                    pictureBoxLine.BorderStyle = BorderStyle.Fixed3D;
                    pictureBoxEllipse.BorderStyle = BorderStyle.None;
                    pictureBoxArrow.BorderStyle = BorderStyle.None;
                    pictureBoxStar.BorderStyle = BorderStyle.None;
                    break;
                case "pictureBoxEllipse":
                    pickedFigure = Figure.Ellipse;
                    pictureBoxRectangle.BorderStyle = BorderStyle.None;
                    pictureBoxLine.BorderStyle = BorderStyle.None;
                    pictureBoxEllipse.BorderStyle = BorderStyle.Fixed3D;
                    pictureBoxArrow.BorderStyle = BorderStyle.None;
                    pictureBoxStar.BorderStyle = BorderStyle.None;
                    break;
                case "pictureBoxStar":
                    pickedFigure = Figure.Star;
                    pictureBoxRectangle.BorderStyle = BorderStyle.None;
                    pictureBoxLine.BorderStyle = BorderStyle.None;
                    pictureBoxEllipse.BorderStyle = BorderStyle.None;
                    pictureBoxStar.BorderStyle = BorderStyle.Fixed3D;
                    pictureBoxArrow.BorderStyle = BorderStyle.None;
                    break;
                case "pictureBoxArrow":
                    pickedFigure = Figure.Arrow;
                    pictureBoxRectangle.BorderStyle = BorderStyle.None;
                    pictureBoxLine.BorderStyle = BorderStyle.None;
                    pictureBoxEllipse.BorderStyle = BorderStyle.None;
                    pictureBoxStar.BorderStyle = BorderStyle.None;
                    pictureBoxArrow.BorderStyle = BorderStyle.Fixed3D;
                    break;
                default:
                    break;
            }
        }

        private void ChangeColor(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (((Panel)sender).BackColor == SystemColors.Control)
                {
                    if (pickedItem == Item.Pen)
                    {
                        pickedItem = Item.Eraser;
                        pen1.Color = Color.White;
                        pictureBoxEraser.BorderStyle = BorderStyle.Fixed3D;
                        pictureBoxPen.BorderStyle = BorderStyle.None;
                    }
                }
                else
                {
                    pen1.Color = ((Panel)sender).BackColor;
                    panelCol1.BackColor = pen1.Color;
                    pictureBoxPen.BorderStyle = BorderStyle.Fixed3D;
                    pictureBoxEraser.BorderStyle = BorderStyle.None;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                brush1 = new SolidBrush(((Panel)sender).BackColor);
                panelCol2.BackColor = ((Panel)sender).BackColor;
            }
        }
        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            if(img==null)
            {
                img = new Bitmap(panelWidth, panelHeight, g);
                gimg = Graphics.FromImage(img);
                gimg.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                gimg.Clear(Color.White);
                bg = bgc.Allocate(g, new Rectangle(0, 0, panelWidth, panelHeight));
            }
            e.Graphics.DrawImage(img, new Rectangle(0, 0, panelWidth, panelHeight));
        }
        private void panelMain_Resize(object sender, EventArgs e)
        {
            panelWidth = panelMain.Width;
            panelHeight = panelMain.Height;
            if (img != null && this.WindowState != System.Windows.Forms.FormWindowState.Minimized)
            {
                img2 = new Bitmap(panelWidth, panelHeight, g);
                gimg = Graphics.FromImage(img2);
                gimg.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                gimg.Clear(Color.White);
                gimg.DrawImage(img, 0, 0);
                g = panelMain.CreateGraphics();
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                img = img2;
                bg = bgc.Allocate(g, new Rectangle(0, 0, panelWidth, panelHeight));
            }
        }
        private void panelMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (created)
            {
                paint = true;
                startPoint = new Point(e.X, e.Y);
            }
            else
            {
                paint = true;
                created = true;
                if (pickedFigure != Figure.Ellipse && pickedFigure != Figure.Rectangle && pickedFigure != Figure.Star && pickedFigure != Figure.Arrow)
                {
                    pickedFigure = Figure.Line;
                }
                startPoint = new Point(e.X, e.Y);
                pen1.EndCap = pen1.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            }
        }
        private void panelMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (img == null) return;
            endPoint = new Point(e.X, e.Y);
            //ниже потом убрать можно
            label1.Text = "X:" + endPoint.X;
            label2.Text = "Y:" + endPoint.Y;
            if (paint)
            {
                if(pickedFigure == Figure.Line)
                {
                    gimg.DrawLine(pen1, startPoint, endPoint);
                    g.DrawLine(pen1, startPoint, endPoint);
                    startPoint = endPoint;
                }
                else
                {
                    if(pen1.Color != Color.White || pickedItem != Item.Eraser)
                    {
                        var bgg = bg.Graphics;
                        bgg.DrawImage(img, 0, 0);
                        DrawOrFillFigure(pickedFigure, startPoint, endPoint, bgg, false);
                        bg.Render();
                    }
                    else
                    {
                        MessageBox.Show("Choose pen to draw a figure");
                        paint = false;
                    }
                }
            }
        }
        private void panelMain_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            DrawOrFillFigure(pickedFigure, startPoint, endPoint, gimg, !(panelCol2.BackColor == SystemColors.Control));
            g.DrawImage(img, 0, 0);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            pen1.Width = comboBox1.SelectedIndex;
        }

        private void DrawOrFillFigure(Figure figure,Point startPoint,Point currentPoint,Graphics grphc,bool fill)
        {
            if (pen1.Color != Color.White || pickedItem != Item.Eraser)
            {
                switch (figure)
                {
                    case (Figure.Line):
                        grphc.DrawLine(pen1, startPoint, endPoint);
                        break;
                    case (Figure.Rectangle):
                        if (startPoint.X > currentPoint.X && startPoint.Y > currentPoint.Y)
                        {
                            if (fill)
                            {
                                grphc.FillRectangle(brush1, new Rectangle(currentPoint, new Size(startPoint.X - currentPoint.X, startPoint.Y - currentPoint.Y)));
                            }
                            grphc.DrawRectangle(pen1, new Rectangle(currentPoint, new Size(startPoint.X - currentPoint.X, startPoint.Y - currentPoint.Y)));
                        }
                        else if (startPoint.X > currentPoint.X && startPoint.Y < currentPoint.Y)
                        {
                            if (fill)
                            {
                                grphc.FillRectangle(brush1, new Rectangle(currentPoint.X, startPoint.Y, startPoint.X - currentPoint.X, currentPoint.Y - startPoint.Y));
                            }
                            grphc.DrawRectangle(pen1, new Rectangle(currentPoint.X, startPoint.Y, startPoint.X - currentPoint.X, currentPoint.Y - startPoint.Y));
                        }
                        else if (startPoint.X < currentPoint.X && startPoint.Y < currentPoint.Y)
                        {
                            if (fill)
                            {
                                grphc.FillRectangle(brush1, new Rectangle(startPoint.X, startPoint.Y, currentPoint.X - startPoint.X, currentPoint.Y - startPoint.Y));
                            }
                            grphc.DrawRectangle(pen1, new Rectangle(startPoint.X, startPoint.Y, currentPoint.X - startPoint.X, currentPoint.Y - startPoint.Y));
                        }
                        else
                        {
                            if (fill)
                            {
                                grphc.FillRectangle(brush1, new Rectangle(startPoint.X, currentPoint.Y, currentPoint.X - startPoint.X, startPoint.Y - currentPoint.Y));
                            }
                            grphc.DrawRectangle(pen1, new Rectangle(startPoint.X, currentPoint.Y, currentPoint.X - startPoint.X, startPoint.Y - currentPoint.Y));
                        }
                        break;
                    case (Figure.Ellipse):
                        if (fill)
                        {
                            grphc.FillEllipse(brush1, new Rectangle(startPoint.X, startPoint.Y, currentPoint.X - startPoint.X, currentPoint.Y - startPoint.Y));
                        }
                        grphc.DrawEllipse(pen1, new Rectangle(startPoint.X, startPoint.Y, currentPoint.X - startPoint.X, currentPoint.Y - startPoint.Y));
                        break;
                    case (Figure.Star):
                        Rectangle area;
                        Point[] points;
                        if (startPoint.X > currentPoint.X && startPoint.Y > currentPoint.Y)
                        {
                            area = new Rectangle(currentPoint, new Size(startPoint.X - currentPoint.X, startPoint.Y - currentPoint.Y));
                        }
                        else if (startPoint.X > currentPoint.X && startPoint.Y < currentPoint.Y)
                        {
                            area = new Rectangle(currentPoint.X, startPoint.Y, startPoint.X - currentPoint.X, currentPoint.Y - startPoint.Y);
                        }
                        else if (startPoint.X < currentPoint.X && startPoint.Y < currentPoint.Y)
                        {
                            area = new Rectangle(startPoint.X, startPoint.Y, currentPoint.X - startPoint.X, currentPoint.Y - startPoint.Y);
                        }
                        else
                        {
                            area = new Rectangle(startPoint.X, currentPoint.Y, currentPoint.X - startPoint.X, startPoint.Y - currentPoint.Y);
                        }
                        points = CreatePolPoints(5, area);
                        if (fill)
                        {
                            grphc.FillPolygon(brush1, points);
                        }
                        grphc.DrawPolygon(pen1, points);
                        break;
                    case (Figure.Arrow):
                        Rectangle area1;
                        Point[] points1;
                        if (startPoint.X > currentPoint.X && startPoint.Y > currentPoint.Y)
                        {
                            area1 = new Rectangle(currentPoint, new Size(startPoint.X - currentPoint.X, startPoint.Y - currentPoint.Y));
                        }
                        else if (startPoint.X > currentPoint.X && startPoint.Y < currentPoint.Y)
                        {
                            area1 = new Rectangle(currentPoint.X, startPoint.Y, startPoint.X - currentPoint.X, currentPoint.Y - startPoint.Y);
                        }
                        else if (startPoint.X < currentPoint.X && startPoint.Y < currentPoint.Y)
                        {
                            area1 = new Rectangle(startPoint.X, startPoint.Y, currentPoint.X - startPoint.X, currentPoint.Y - startPoint.Y);
                        }
                        else
                        {
                            area1 = new Rectangle(startPoint.X, currentPoint.Y, currentPoint.X - startPoint.X, startPoint.Y - currentPoint.Y);
                        }

                        points1 = CreateArrPoints(area1);

                        if (fill)
                        {
                            grphc.FillPolygon(brush1, points1);
                        }
                        grphc.DrawPolygon(pen1, points1);
                        break;
                    default:
                        break;
                }
            }

        }
        private Point[] CreatePolPoints(int numb, Rectangle area)
        {
            Point[] pts = new Point[numb];
            int cX = area.Width / 2;
            int cY = area.Height / 2;

            int centerX = area.X + cX;
            int centerY = area.Y + cY;

            double theta = -Math.PI / 2;
            double dtheta = 4 * Math.PI / numb;//шаг в градусах между вершинами

            for (int i = 0; i < numb; i++)
            {
                pts[i] = new Point((int)(centerX + cX * Math.Cos(theta)), (int)(centerY + cY * Math.Sin(theta)));
                theta += dtheta;
            }
            return pts;

        }
        private Point[] CreateArrPoints(Rectangle area)
        {
            Point point1 = new Point(area.X, area.Y + area.Height / 2);
            Point point2 = new Point((int)(area.X + area.Width * 0.65), (int)(area.Y + area.Height * 0.35));
            Point point3 = new Point((int)(area.X + area.Width * 0.6), (int)(area.Y + area.Height * 0.15));
            Point point4 = new Point((int)(area.X + area.Width * 0.9), (int)(area.Y + area.Height * 0.5));
            Point point5 = new Point((int)(area.X + area.Width * 0.6), (int)(area.Y + area.Height * 0.85));
            Point point6 = new Point((int)(area.X + area.Width * 0.65), (int)(area.Y + area.Height * 0.65));
            Point[] pts = { point1, point2, point3, point4, point5, point6 };
            return pts;
        }
    }
}
