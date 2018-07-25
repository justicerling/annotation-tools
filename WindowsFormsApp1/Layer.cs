using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Layer : UserControl {
        public Layer() {
            InitializeComponent();
            this.Actived = false;
        }

        private bool showHiddenToggle = true;
        public bool DrawActived { get; set; }
        public Boolean Actived { get; set; }

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
