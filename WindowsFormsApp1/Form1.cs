using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        private Point fPoint;
        private Point prePosintion;
        private Point ePoint;
        private Graphics gra;
        private Dictionary<int, Rectangle> rects;
        private Pen drawPen = new Pen(Color.Red, 3);
        private int currentIndex = 1;
        private int panelPreW;
        private int panelPreH;
        private Point dragPointPre;
        private int currentDragIndex;
        Boolean drawNewFlag = false;
        private int preDragTime = Environment.TickCount;
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //Panel graphPanel = (Panel)(this.Controls.Find("graphPanel", true)[0]);
            gra = Graphics.FromHwnd(graphPanel.Handle);
            panelPreW = graphPanel.Width;
            panelPreH = graphPanel.Height;
            fPoint = new Point(0, 0);
            ePoint = new Point(0, 0);
            rects = new Dictionary<int, Rectangle>();
            Rectangle rectangle = new Rectangle(graphPanel.Location.X, graphPanel.Location.Y, graphPanel.Width, graphPanel.Height);
            gra.DrawImage(Image.FromFile("D:\\Users\\tuqiangfan\\source\\repos\\NewRepo\\WindowsFormsApp1\\Resources\\PHO_20180514_08324500A.JPG"), rectangle);
        }

        private void button1_Click(object sender, EventArgs e) {

        }

        public void Form2_Colse(object sender, FormClosedEventArgs e) {
            Form2 form2 = (Form2)sender;
            if (form2.SubmitAnno != null) {
                Layer layer = new Layer();
                Console.WriteLine("选择的颜色是:" + form2.SubmitAnno.Color);
                layer.AnnoColor(ColorTranslator.FromHtml(form2.SubmitAnno.Color));
                layer.Dock = DockStyle.Top;
                layer.AnnoName(form2.SubmitAnno.Name);
                annoListPanel.Controls.Add(layer);
            }
        }

    }
}
