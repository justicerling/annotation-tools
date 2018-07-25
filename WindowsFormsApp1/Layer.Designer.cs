using System.Drawing;

namespace WindowsFormsApp1 {
    partial class Layer {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public void AnnoName(string name) {
            this.label1.Text = name;
        }

        public string getAnnoName() {
            return this.label1.Text;
        }

        public void AnnoColor(Color color) {
            
            using(Graphics gra = Graphics.FromHwnd(this.annoShowPanel.Handle)) {
                using(Brush brush = new SolidBrush(color)) {
                    gra.FillRectangle(brush, rectangle);
                }
            }
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.drawRectBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.annoShowPanel = new WindowsFormsApp1.MyPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 11, 5, 5);
            this.label1.Size = new System.Drawing.Size(51, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "{name}";
            // 
            // drawRectBtn
            // 
            this.drawRectBtn.AutoSize = true;
            this.drawRectBtn.BackColor = System.Drawing.Color.Transparent;
            this.drawRectBtn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pen;
            this.drawRectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.drawRectBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.drawRectBtn.FlatAppearance.BorderSize = 0;
            this.drawRectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drawRectBtn.Location = new System.Drawing.Point(219, 0);
            this.drawRectBtn.Name = "drawRectBtn";
            this.drawRectBtn.Size = new System.Drawing.Size(40, 35);
            this.drawRectBtn.TabIndex = 3;
            this.drawRectBtn.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.show;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(259, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 35);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // annoShowPanel
            // 
            this.annoShowPanel.BackColor = System.Drawing.Color.Transparent;
            this.annoShowPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.annoShowPanel.Location = new System.Drawing.Point(179, 0);
            this.annoShowPanel.Name = "annoShowPanel";
            this.annoShowPanel.Size = new System.Drawing.Size(40, 35);
            this.annoShowPanel.TabIndex = 0;
            // 
            // Layer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.annoShowPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawRectBtn);
            this.Controls.Add(this.button3);
            this.Name = "Layer";
            this.Size = new System.Drawing.Size(299, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button drawRectBtn;
        private System.Windows.Forms.Button button3;
        private Rectangle rectangle = new Rectangle(0, 0, 10, 33);
        private MyPanel annoShowPanel;
    }
}
