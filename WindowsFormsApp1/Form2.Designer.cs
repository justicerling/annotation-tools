namespace WindowsFormsApp1 {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.newROIPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.rectColorlistBox = new System.Windows.Forms.ListBox();
            this.ractListShowPanel = new WindowsFormsApp1.MyPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.annoDescTxtBox = new System.Windows.Forms.TextBox();
            this.newROIPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // newROIPanel
            // 
            this.newROIPanel.ColumnCount = 2;
            this.newROIPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.newROIPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.newROIPanel.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.newROIPanel.Controls.Add(this.button1, 0, 2);
            this.newROIPanel.Controls.Add(this.button2, 1, 2);
            this.newROIPanel.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.newROIPanel.Controls.Add(this.flowLayoutPanel3, 0, 1);
            this.newROIPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newROIPanel.Location = new System.Drawing.Point(0, 0);
            this.newROIPanel.Name = "newROIPanel";
            this.newROIPanel.Padding = new System.Windows.Forms.Padding(30, 30, 30, 0);
            this.newROIPanel.RowCount = 3;
            this.newROIPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.57426F));
            this.newROIPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.42574F));
            this.newROIPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.newROIPanel.Size = new System.Drawing.Size(548, 282);
            this.newROIPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.categoryName);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(33, 33);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(238, 80);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "标注类型名称:";
            // 
            // categoryName
            // 
            this.categoryName.Dock = System.Windows.Forms.DockStyle.Right;
            this.categoryName.Location = new System.Drawing.Point(5, 27);
            this.categoryName.Margin = new System.Windows.Forms.Padding(5);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(231, 21);
            this.categoryName.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(196, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(277, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.rectColorlistBox);
            this.flowLayoutPanel2.Controls.Add(this.ractListShowPanel);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(277, 33);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(238, 80);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "边框颜色:";
            // 
            // rectColorlistBox
            // 
            this.rectColorlistBox.FormattingEnabled = true;
            this.rectColorlistBox.ItemHeight = 12;
            this.rectColorlistBox.Items.AddRange(new object[] {
            "红色",
            "橙色",
            "黄色",
            "绿色",
            "青色",
            "蓝色",
            "紫色"});
            this.rectColorlistBox.Location = new System.Drawing.Point(5, 27);
            this.rectColorlistBox.Margin = new System.Windows.Forms.Padding(5);
            this.rectColorlistBox.Name = "rectColorlistBox";
            this.rectColorlistBox.Size = new System.Drawing.Size(120, 40);
            this.rectColorlistBox.TabIndex = 2;
            this.rectColorlistBox.SelectedIndexChanged += new System.EventHandler(this.RectColorlistBox_SelectedIndexChanged);
            // 
            // ractListShowPanel
            // 
            this.ractListShowPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ractListShowPanel.BackColor = System.Drawing.Color.White;
            this.ractListShowPanel.Location = new System.Drawing.Point(133, 20);
            this.ractListShowPanel.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.ractListShowPanel.Name = "ractListShowPanel";
            this.ractListShowPanel.Size = new System.Drawing.Size(80, 50);
            this.ractListShowPanel.TabIndex = 3;
            // 
            // flowLayoutPanel3
            // 
            this.newROIPanel.SetColumnSpan(this.flowLayoutPanel3, 2);
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.annoDescTxtBox);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(33, 119);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(482, 110);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "标注类型描述:";
            // 
            // annoDescTxtBox
            // 
            this.annoDescTxtBox.Location = new System.Drawing.Point(3, 25);
            this.annoDescTxtBox.Multiline = true;
            this.annoDescTxtBox.Name = "annoDescTxtBox";
            this.annoDescTxtBox.Size = new System.Drawing.Size(479, 76);
            this.annoDescTxtBox.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 282);
            this.Controls.Add(this.newROIPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "自定义标注类型";
            this.newROIPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel newROIPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox categoryName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox annoDescTxtBox;
        private System.Windows.Forms.ListBox rectColorlistBox;
        private MyPanel ractListShowPanel;
    }
}