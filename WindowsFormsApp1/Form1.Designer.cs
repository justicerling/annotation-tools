namespace WindowsFormsApp1 {
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importImageFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showHiddenToolBar = new System.Windows.Forms.Button();
            this.removeToolBar = new System.Windows.Forms.Button();
            this.selectAnnoRect = new System.Windows.Forms.Button();
            this.saveWorkBtn = new System.Windows.Forms.Button();
            this.folderOpenBtn = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.annoListParentPanel = new System.Windows.Forms.Panel();
            this.annoListPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AnnoAddBtn = new System.Windows.Forms.Button();
            this.graphPanel = new WindowsFormsApp1.MyPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.preImage = new System.Windows.Forms.Button();
            this.nextImageBtn = new System.Windows.Forms.Button();
            this.pagesInfoLab = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.annoListParentPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1264, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importImageFolder,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // importImageFolder
            // 
            this.importImageFolder.Name = "importImageFolder";
            this.importImageFolder.Size = new System.Drawing.Size(136, 22);
            this.importImageFolder.Text = "导入文件夹";
            this.importImageFolder.Click += new System.EventHandler(this.ImportImageFolder_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 704);
            this.splitContainer1.SplitterDistance = 605;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1264, 605);
            this.splitContainer2.SplitterDistance = 49;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.showHiddenToolBar);
            this.panel1.Controls.Add(this.removeToolBar);
            this.panel1.Controls.Add(this.selectAnnoRect);
            this.panel1.Controls.Add(this.saveWorkBtn);
            this.panel1.Controls.Add(this.folderOpenBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 49);
            this.panel1.TabIndex = 0;
            // 
            // showHiddenToolBar
            // 
            this.showHiddenToolBar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.show;
            this.showHiddenToolBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showHiddenToolBar.FlatAppearance.BorderSize = 0;
            this.showHiddenToolBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showHiddenToolBar.Location = new System.Drawing.Point(211, 8);
            this.showHiddenToolBar.Name = "showHiddenToolBar";
            this.showHiddenToolBar.Size = new System.Drawing.Size(40, 28);
            this.showHiddenToolBar.TabIndex = 4;
            this.showHiddenToolBar.UseVisualStyleBackColor = true;
            this.showHiddenToolBar.Click += new System.EventHandler(this.showHiddenToolBar_Click);
            // 
            // removeToolBar
            // 
            this.removeToolBar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.minus;
            this.removeToolBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeToolBar.FlatAppearance.BorderSize = 0;
            this.removeToolBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeToolBar.Location = new System.Drawing.Point(153, 8);
            this.removeToolBar.Name = "removeToolBar";
            this.removeToolBar.Size = new System.Drawing.Size(40, 28);
            this.removeToolBar.TabIndex = 3;
            this.removeToolBar.UseVisualStyleBackColor = true;
            this.removeToolBar.Click += new System.EventHandler(this.removeToolBar_Click);
            // 
            // selectAnnoRect
            // 
            this.selectAnnoRect.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.hand;
            this.selectAnnoRect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.selectAnnoRect.FlatAppearance.BorderSize = 0;
            this.selectAnnoRect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectAnnoRect.Location = new System.Drawing.Point(98, 7);
            this.selectAnnoRect.Name = "selectAnnoRect";
            this.selectAnnoRect.Size = new System.Drawing.Size(40, 28);
            this.selectAnnoRect.TabIndex = 2;
            this.selectAnnoRect.UseVisualStyleBackColor = true;
            // 
            // saveWorkBtn
            // 
            this.saveWorkBtn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.save;
            this.saveWorkBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveWorkBtn.FlatAppearance.BorderSize = 0;
            this.saveWorkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveWorkBtn.Location = new System.Drawing.Point(49, 7);
            this.saveWorkBtn.Name = "saveWorkBtn";
            this.saveWorkBtn.Size = new System.Drawing.Size(40, 28);
            this.saveWorkBtn.TabIndex = 1;
            this.saveWorkBtn.UseVisualStyleBackColor = true;
            // 
            // folderOpenBtn
            // 
            this.folderOpenBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("folderOpenBtn.BackgroundImage")));
            this.folderOpenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.folderOpenBtn.FlatAppearance.BorderSize = 0;
            this.folderOpenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.folderOpenBtn.Location = new System.Drawing.Point(3, 8);
            this.folderOpenBtn.Name = "folderOpenBtn";
            this.folderOpenBtn.Size = new System.Drawing.Size(40, 28);
            this.folderOpenBtn.TabIndex = 0;
            this.folderOpenBtn.UseVisualStyleBackColor = true;
            this.folderOpenBtn.Click += new System.EventHandler(this.ImportImageFolder_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.annoListParentPanel);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.graphPanel);
            this.splitContainer3.Size = new System.Drawing.Size(1264, 553);
            this.splitContainer3.SplitterDistance = 239;
            this.splitContainer3.SplitterWidth = 3;
            this.splitContainer3.TabIndex = 0;
            // 
            // annoListParentPanel
            // 
            this.annoListParentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.annoListParentPanel.Controls.Add(this.annoListPanel);
            this.annoListParentPanel.Controls.Add(this.panel2);
            this.annoListParentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.annoListParentPanel.Location = new System.Drawing.Point(0, 0);
            this.annoListParentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.annoListParentPanel.Name = "annoListParentPanel";
            this.annoListParentPanel.Size = new System.Drawing.Size(239, 553);
            this.annoListParentPanel.TabIndex = 0;
            // 
            // annoListPanel
            // 
            this.annoListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.annoListPanel.Location = new System.Drawing.Point(0, 26);
            this.annoListPanel.Name = "annoListPanel";
            this.annoListPanel.Size = new System.Drawing.Size(237, 525);
            this.annoListPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.AnnoAddBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 26);
            this.panel2.TabIndex = 0;
            // 
            // AnnoAddBtn
            // 
            this.AnnoAddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AnnoAddBtn.BackgroundImage")));
            this.AnnoAddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AnnoAddBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnnoAddBtn.FlatAppearance.BorderSize = 0;
            this.AnnoAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnnoAddBtn.Location = new System.Drawing.Point(0, 0);
            this.AnnoAddBtn.Name = "AnnoAddBtn";
            this.AnnoAddBtn.Size = new System.Drawing.Size(235, 24);
            this.AnnoAddBtn.TabIndex = 0;
            this.AnnoAddBtn.UseVisualStyleBackColor = true;
            this.AnnoAddBtn.Click += new System.EventHandler(this.AnnoAddBtn_Click);
            // 
            // graphPanel
            // 
            this.graphPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphPanel.Location = new System.Drawing.Point(0, 0);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(1022, 553);
            this.graphPanel.TabIndex = 0;
            this.graphPanel.SizeChanged += new System.EventHandler(this.Graph_Panel__Size_Changed_ReLoad_Gra);
            this.graphPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Graph_Panel_On_Paint);
            this.graphPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Graph_Panel_Mouse_Down);
            this.graphPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Graph_Panel_Mouse_Move);
            this.graphPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Graph_Panel_Mouse_Up);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1264, 96);
            this.panel4.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.10807F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.89193F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel1.Controls.Add(this.preImage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nextImageBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pagesInfoLab, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1262, 94);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // preImage
            // 
            this.preImage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.preImage.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.left;
            this.preImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.preImage.FlatAppearance.BorderSize = 0;
            this.preImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.preImage.Location = new System.Drawing.Point(636, 35);
            this.preImage.Name = "preImage";
            this.preImage.Size = new System.Drawing.Size(55, 23);
            this.preImage.TabIndex = 0;
            this.preImage.UseVisualStyleBackColor = true;
            this.preImage.Click += new System.EventHandler(this.preImage_Click);
            // 
            // nextImageBtn
            // 
            this.nextImageBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nextImageBtn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.right;
            this.nextImageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextImageBtn.FlatAppearance.BorderSize = 0;
            this.nextImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextImageBtn.Location = new System.Drawing.Point(697, 35);
            this.nextImageBtn.Name = "nextImageBtn";
            this.nextImageBtn.Size = new System.Drawing.Size(50, 23);
            this.nextImageBtn.TabIndex = 1;
            this.nextImageBtn.UseVisualStyleBackColor = true;
            this.nextImageBtn.Click += new System.EventHandler(this.nextImageBtn_Click);
            // 
            // pagesInfoLab
            // 
            this.pagesInfoLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pagesInfoLab.AutoSize = true;
            this.pagesInfoLab.Location = new System.Drawing.Point(1236, 77);
            this.pagesInfoLab.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.pagesInfoLab.Name = "pagesInfoLab";
            this.pagesInfoLab.Size = new System.Drawing.Size(23, 12);
            this.pagesInfoLab.TabIndex = 2;
            this.pagesInfoLab.Text = "-\\-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "标注工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.annoListParentPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel annoListParentPanel;
        private System.Windows.Forms.Panel panel4;
        private MyPanel graphPanel;
        private System.Windows.Forms.Button AnnoAddBtn;
        private System.Windows.Forms.Panel annoListPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem importImageFolder;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button preImage;
        private System.Windows.Forms.Button nextImageBtn;
        private System.Windows.Forms.Label pagesInfoLab;
        private System.Windows.Forms.Button folderOpenBtn;
        private System.Windows.Forms.Button saveWorkBtn;
        private System.Windows.Forms.Button selectAnnoRect;
        private System.Windows.Forms.Button showHiddenToolBar;
        private System.Windows.Forms.Button removeToolBar;
    }
}

