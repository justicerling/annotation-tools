using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        private Point fPoint;
        private Point ePoint;
        private Graphics gra;
        private Dictionary<int, Rectangle> rects;
        private Pen drawPen = new Pen(Color.Red, 3);
        private int currentIndex;
        private int panelPreW;
        private int panelPreH;
        private Point dragPointPre;
        Boolean flag = false;
        private int preDragTime = Environment.TickCount;
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //Panel panel3 = (Panel)(this.Controls.Find("panel3", true)[0]);
            gra = Graphics.FromHwnd(panel3.Handle);
            panelPreW = panel3.Width;
            panelPreH = panel3.Height;
            fPoint = new Point(0, 0);
            ePoint = new Point(0, 0);
            rects = new Dictionary<int, Rectangle>();
            Rectangle rectangle = new Rectangle(panel3.Location.X, panel3.Location.Y, panel3.Width, panel3.Height);
            gra.DrawImage(Image.FromFile("D:\\Users\\tuqiangfan\\source\\repos\\NewRepo\\WindowsFormsApp1\\Resources\\PHO_20180514_08324500A.JPG"), rectangle);
        }

        private void Mouse_Down(object sender, MouseEventArgs e) {
            Console.WriteLine("鼠标点击次数:" + e.Clicks);
            if (e.Button == MouseButtons.Left && Utils.Contains(new Rectangle(panel3.Location.X, panel3.Location.Y, panel3.Width, panel3.Height), new Point(e.X, e.Y))) {
                ///鼠标的当前位置
                Point cPoint = new Point(e.X, e.Y);
                foreach (Rectangle rect in rects.Values) {
                    if (rect.Contains(cPoint)) {
                        flag = false;
                        dragPointPre = cPoint;
                        return;
                    }
                }
                flag = true;
                if (flag) {
                    fPoint.X = e.X;
                    fPoint.Y = e.Y;
                    currentIndex++;
                    Rectangle rectangle = new Rectangle(fPoint.X, fPoint.Y, 5, 5);
                    rects.Add(currentIndex, rectangle);
                    Console.WriteLine("开始坐标：X=" + e.X + ",Y=" + e.Y);
                }
            }
            
        }

        private void Mouse_Up(object sender, MouseEventArgs e) {
            if (flag && Utils.Contains(new Rectangle(panel3.Location.X, panel3.Location.Y, panel3.Width, panel3.Height), new Point(e.X, e.Y))) {
                ePoint.X = e.X;
                ePoint.Y = e.Y;
                Console.WriteLine("结束坐标：X=" + e.X + ",Y=" + e.Y);
                ///不在已存在的矩形内画框
                foreach (Rectangle rect in rects.Values) {
                    if (rect.Contains(ePoint)) {
                        flag = false;
                        return;
                    }
                }
                ///边界处理
                Panel panel = (Panel)sender;
                int X_R_Boundary = panel.Location.X + panel.Width;
                int X_L_Boundary = panel.Location.X;
                int Y_T_Boundary = panel.Location.Y;
                int Y_B_Boundary = panel.Location.Y + panel.Height;
                if (ePoint.X >= X_R_Boundary) {
                    ePoint.X = X_R_Boundary - 3;
                }
                if (ePoint.X <= X_L_Boundary) {
                    ePoint.X = X_L_Boundary;
                }
                if (ePoint.Y >= Y_B_Boundary) {
                    ePoint.Y = Y_B_Boundary - 3;
                }
                if (ePoint.Y <= Y_T_Boundary) {
                    ePoint.Y = Y_T_Boundary;
                }
                ///反向画图处理
                Rectangle rectangle = rects[currentIndex];
                if (ePoint.X < fPoint.X) {
                    int tempX = fPoint.X;
                    fPoint.X = ePoint.X;
                    ePoint.X = tempX;
                }
                if (ePoint.Y < fPoint.Y) {
                    int tempY = fPoint.Y;
                    fPoint.Y = ePoint.Y;
                    ePoint.Y = tempY;
                }
                rectangle.X = fPoint.X;
                rectangle.Y = fPoint.Y;
                rectangle.Width = ePoint.X - fPoint.X;
                rectangle.Height = ePoint.Y - fPoint.Y;
                flag = false;
                if (rectangle.Width == 0 || rectangle.Height == 0) {
                    rects.Remove(currentIndex);
                    return;
                }
                rects.Remove(currentIndex);
                rects[currentIndex] = rectangle;
                Console.WriteLine("实际画图坐标：" + rectangle);
                gra.DrawRectangle(drawPen, rectangle);
            }
        }

        private void Panel3_Size_Changed_ReLoad_Gra(object sender, EventArgs e) {
            Panel panel3 = (Panel)sender;
            if (panelPreW == 0 || panelPreH == 0) {
                panelPreW = panel3.Width;
                panelPreH = panel3.Height;
                return;
            }
            double xZoom = ((double)panel3.Width) / ((double)panelPreW);
            double yZoom = ((double)panel3.Height) / ((double)panelPreH);
            panelPreW = panel3.Width;
            panelPreH = panel3.Height;
            gra = Graphics.FromHwnd(panel3.Handle);
            //重绘背景
            gra.FillRectangle(new SolidBrush(Color.LightGray), panel3.Location.X, panel3.Location.Y, panel3.Width, panel3.Height);
            Image image = Image.FromFile("D:\\Users\\tuqiangfan\\source\\repos\\NewRepo\\WindowsFormsApp1\\Resources\\PHO_20180514_08324500A.JPG");
            Rectangle imageRect = new Rectangle(panel3.Location.X, panel3.Location.Y, panel3.Width, panel3.Height);
            gra.DrawImage(image, imageRect);
            //重绘矩形
            //所有矩形需要重绘
            Dictionary<int, Rectangle> temp = new Dictionary<int, Rectangle>();
            foreach (int rectKey in rects.Keys) {
                Rectangle rect = rects[rectKey];
                rect.X = (int)Math.Round(rects[rectKey].X * xZoom, 0);
                rect.Y = (int)Math.Round(rects[rectKey].Y * yZoom);
                rect.Width = (int)Math.Round(rects[rectKey].Width * xZoom);
                rect.Height = (int)Math.Round(rects[rectKey].Height * yZoom);
                gra.DrawRectangle(drawPen, rect);
                temp.Add(rectKey, rect);
            }
            rects = temp;
            Console.WriteLine("当前共有矩形:" + rects.Count + "个");
        }

        private void Mouse_Move(object sender, MouseEventArgs e) {


            int cDragTime = Environment.TickCount;
            if (cDragTime - preDragTime < 200) {
                return;
            }
            preDragTime = cDragTime;
            if (e.Button == MouseButtons.Left) {
                Point cPoint = new Point(e.X, e.Y);
                foreach (Rectangle rect in rects.Values) {
                    if (rect.Contains(cPoint)) {
                        Rectangle rectangle = rect;
                        Cursor.Current = Cursors.SizeAll;
                        //gra = Graphics.FromHwnd(panel3.Handle);
                        //重绘背景
                        //gra.FillRectangle(new SolidBrush(Color.LightGray), panel3.Location.X, panel3.Location.Y, panel3.Width, panel3.Height);
                        //Image image = Image.FromFile("D:\\Users\\tuqiangfan\\source\\repos\\NewRepo\\WindowsFormsApp1\\Resources\\PHO_20180514_08324500A.JPG");
                        //Rectangle imageRect = new Rectangle(panel3.Location.X, panel3.Location.Y, panel3.Width, panel3.Height);
                        //gra.DrawImage(image, imageRect);
                        //重绘矩形
                        //所有矩形需要重绘

                        
                        rectangle.X = rectangle.X+(cPoint.X - dragPointPre.X);
                        rectangle.Y = rectangle.Y+(cPoint.Y - dragPointPre.Y);
                        gra.DrawRectangle(drawPen, rectangle);
                        return;
                    }
                }
            }
            
        }

        private void Panel3_Mouse_Hover(object sender, EventArgs e) {
            foreach (Rectangle rect in rects.Values) {
                if (rect.Contains(Cursor.Position)) {
                    Rectangle rectangle = rect;
                    Cursor.Current = Cursors.SizeAll;
                    return;
                }
            }
        }
    }
}
