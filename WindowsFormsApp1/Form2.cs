using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form2 : Form {

        private Dictionary<int, Color> listBoxColorMap = new Dictionary<int, Color>();
        private Rectangle exampleRect = new Rectangle(20, 5, 40, 40);
        public Boolean SubmitFlag { get; set; }
        public Annotation SubmitAnno { get; set; }
        public Form2() {
            InitializeComponent();
            listBoxColorMap.Add(0, Color.Red);//赤
            listBoxColorMap.Add(1, Color.Orange);//橙
            listBoxColorMap.Add(2, Color.Yellow);//黄
            listBoxColorMap.Add(3, Color.Green);//绿
            listBoxColorMap.Add(4, Color.Cyan);//青
            listBoxColorMap.Add(5, Color.Blue);//蓝
            listBoxColorMap.Add(6, Color.Purple);//紫
        }


        private void RectColorlistBox_SelectedIndexChanged(object sender, EventArgs e) {
            using (Graphics gra = Graphics.FromHwnd(ractListShowPanel.Handle)) {
                using (Pen pen = new Pen(listBoxColorMap[rectColorlistBox.SelectedIndex], 2)) {
                    gra.DrawRectangle(pen, exampleRect);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(categoryName.Text)) {
                categoryName.Focus();
                MessageBox.Show("标注类型名称不能为空!");
                return;
            }
            if (rectColorlistBox.SelectedIndex == -1) {
                rectColorlistBox.Focus();
                MessageBox.Show("请选择一个标注框的颜色!");
                return;
            }
            Annotation anno = new Annotation();
            //String hexColor = ColorTranslator.ToHtml();
            //Console.WriteLine("提交的颜色是:" + hexColor);
            anno.Color = listBoxColorMap[rectColorlistBox.SelectedIndex];
            anno.Name = categoryName.Text;
            anno.Desc = annoDescTxtBox.Text;
            this.SubmitAnno = anno;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
