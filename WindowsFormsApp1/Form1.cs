using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Point fPoint;
        private Point ePoint;
        private Graphics gra;
        private List<Rectangle> rectangles;
        private Dictionary<int, Rectangle> rects;
        private Pen drawPen = new Pen(Color.Red, 3);
        private int currentIndex;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gra = Graphics.FromHwnd(this.Controls.Find("panel3", true)[0].Handle);
            fPoint = new Point(0, 0);
            ePoint = new Point(0, 0);
            rectangles = new List<Rectangle>();
            rects = new Dictionary<int, Rectangle>();
        }

        private void Mouse_Down(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                return;
            }
            Boolean flag = false;
            foreach (Rectangle rect in rects.Values)
            {
                if (rect.Contains(e.X, e.Y))
                {
                    flag = true;
                }
            }

            if (!flag)
            {
                fPoint.X = e.X;
                fPoint.Y = e.Y;
                currentIndex++;
                Rectangle rectangle = new Rectangle(fPoint.X, fPoint.Y, 5, 5);
                rects.Add(currentIndex, rectangle);
                Console.WriteLine("开始坐标：X=" + e.X + ",Y=" + e.Y);
            }
        }

        private void Mouse_Up(object sender, MouseEventArgs e)
        {
            ePoint.X = e.X;
            ePoint.Y = e.Y;
            Console.WriteLine("结束坐标：X=" + e.X + ",Y=" + e.Y);
            Rectangle rectangle = rects[currentIndex];
            rectangle.Width = ePoint.X - fPoint.X;
            rectangle.Height = ePoint.Y - fPoint.Y;
            gra.DrawRectangle(drawPen, rectangle);
        }
    }
}
