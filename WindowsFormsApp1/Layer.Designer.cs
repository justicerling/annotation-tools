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
            this.annoToggle = new System.Windows.Forms.Button();
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
            // annoToggle
            // 
            this.annoToggle.AutoSize = true;
            this.annoToggle.BackColor = System.Drawing.Color.Transparent;
            this.annoToggle.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.show;
            this.annoToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.annoToggle.Dock = System.Windows.Forms.DockStyle.Right;
            this.annoToggle.FlatAppearance.BorderSize = 0;
            this.annoToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.annoToggle.Location = new System.Drawing.Point(259, 0);
            this.annoToggle.Name = "annoToggle";
            this.annoToggle.Size = new System.Drawing.Size(40, 35);
            this.annoToggle.TabIndex = 4;
            this.annoToggle.UseVisualStyleBackColor = false;
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
            this.Controls.Add(this.annoToggle);
            this.Name = "Layer";
            this.Size = new System.Drawing.Size(299, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button drawRectBtn;
        public System.Windows.Forms.Button annoToggle;
        private Rectangle rectangle = new Rectangle(0, 0, 10, 33);
        private MyPanel annoShowPanel;
    }
}
