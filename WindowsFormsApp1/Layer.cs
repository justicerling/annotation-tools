using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Layer : UserControl {
        public Layer() {
            InitializeComponent();
            this.Actived = false;
        }

        public bool ShowHiddenToggle { get; set; }
        public bool DrawActived { get; set; }
        public Boolean Actived { get; set; }

       
    }
}
