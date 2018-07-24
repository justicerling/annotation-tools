using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Layer : UserControl {
        public Layer() {
            InitializeComponent();

            using (Graphics gra = Graphics.FromHwnd(annoShowPanel.Handle)) {
                using (Pen pen = new Pen(Color.Red, 2)) {
                    Rectangle rectangle = new Rectangle(0, 0, 40, 33);
                    gra.DrawRectangle(pen, rectangle);
                }
            }
        }

        private bool showHiddenToggle = true;

        private void button3_Click(object sender, EventArgs e) {
            if (showHiddenToggle) {
                button3.BackgroundImage = Properties.Resources.hidden;
            } else {
                button3.BackgroundImage = Properties.Resources.show;
            }
            showHiddenToggle = !showHiddenToggle;
        }
    }
}
