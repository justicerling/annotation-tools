﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        private Point fPoint;
        private Point prePosintion;
        private Point ePoint;
        private Graphics gra;
        private Dictionary<int, Annotation> rects;
        private Pen drawPen = new Pen(Color.Red, 3);
        private int currentIndex = 1;
        private int panelPreW;
        private int panelPreH;
        private Point dragPointPre;
        private int currentDragIndex;
        Boolean drawNewFlag = false;
        private int preDragTime = Environment.TickCount;
        private string imagesFoldPath;
        private string[] imagePaths;
        private int currentImageIdx = 0;
        private Dictionary<string, Annotation> annos = new Dictionary<string, Annotation>();
        private Annotation currentActivedAnno;
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            gra = Graphics.FromHwnd(graphPanel.Handle);
            panelPreW = graphPanel.Width;
            panelPreH = graphPanel.Height;
            fPoint = new Point(0, 0);
            ePoint = new Point(0, 0);
            rects = new Dictionary<int, Annotation>();
            Rectangle rectangle = new Rectangle(graphPanel.Location.X, graphPanel.Location.Y, graphPanel.Width, graphPanel.Height);
            if (imagePaths != null && imagePaths.Length > 0) {
                gra.DrawImage(Image.FromFile(imagePaths[currentImageIdx]), rectangle);
            }
        }



        public void Form2_Colse(object sender, FormClosedEventArgs e) {
            Form2 form2 = (Form2)sender;
            if (form2.SubmitAnno != null) {
                if (annos.ContainsKey(form2.SubmitAnno.Name)) {
                    MessageBox.Show("名称为:" + form2.SubmitAnno.Name + "的标注类型已存在!");
                    return;
                }
                Layer layer = new Layer();
                layer.Dock = DockStyle.Top;
                layer.AnnoName(form2.SubmitAnno.Name);
                annoListPanel.Controls.Add(layer);
                layer.AnnoColor(form2.SubmitAnno.Color);
                annos.Add(form2.SubmitAnno.Name, form2.SubmitAnno);
                layer.drawRectBtn.Click += DrawRectBtn_Click;
                layer.annoToggle.Click += AnnoToggle_Click;
            }
        }

        private void DrawRectBtn_Click(object sender, EventArgs e) {
            Button layerDrawRectBtn = (Button)sender;
            Layer layer = (Layer)layerDrawRectBtn.Parent;
            if (layer.DrawActived) {
                layer.BackColor = Color.FromName("Control");
                currentActivedAnno = null;
            } else {
                layer.BackColor = Color.FromName("ButtonShadow");
                currentActivedAnno = annos[layer.getAnnoName()];
            }
            layer.DrawActived = !layer.DrawActived;
            Panel annoListPanel = (Panel)layer.Parent;
            foreach (Control layer1 in annoListPanel.Controls) {
                if (!layer1.Equals(layer)) {
                    layer1.BackColor = Color.FromName("Control");
                }
            }
        }

        private void AnnoToggle_Click(object sender, EventArgs e) {
            Button annoToggle = (Button)sender;
            Layer layer = (Layer)annoToggle.Parent;
            if (layer.ShowHiddenToggle) {
                annoToggle.BackgroundImage = Properties.Resources.hidden;
            } else {
                annoToggle.BackgroundImage = Properties.Resources.show;
            }
            layer.ShowHiddenToggle = !layer.ShowHiddenToggle;
            int count = 0;
            foreach (Annotation anno in rects.Values) {
                if (anno.Name.Equals(layer.getAnnoName())) {
                    anno.Show = layer.ShowHiddenToggle;
                    count++;
                }
            }
            if (count > 0) {
                graphPanel.Invalidate(true);
            }
        }

        private void ImportImageFolder_Click(object sender, EventArgs e) {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK) {
                imagesFoldPath = dialog.SelectedPath;
                imagePaths = Directory.GetFiles(imagesFoldPath);
                using (gra = Graphics.FromHwnd(graphPanel.Handle)) {
                    panelPreW = graphPanel.Width;
                    panelPreH = graphPanel.Height;
                    fPoint = new Point(0, 0);
                    ePoint = new Point(0, 0);
                    rects = new Dictionary<int, Annotation>();
                    Rectangle rectangle = new Rectangle(graphPanel.Location.X, graphPanel.Location.Y, graphPanel.Width, graphPanel.Height);
                    if (imagePaths != null && imagePaths.Length > 0) {
                        updatePagesInfo();
                        currentImageIdx = 0;
                        gra.DrawImage(Image.FromFile(imagePaths[currentImageIdx]), rectangle);
                    }
                }
            }
        }

        private void updatePagesInfo() {
            if (imagePaths != null && imagePaths.Length > 0) {
                pagesInfoLab.Text = string.Format("第{0:G}/共{1:G}", currentImageIdx, imagePaths.Length);
            }
        }

        private void nextImageBtn_Click(object sender, EventArgs e) {
            if (imagePaths == null || currentImageIdx >= imagePaths.Length - 1) {
                return;
            }
            currentImageIdx++;
            updatePagesInfo();
            graphPanel.Invalidate(true);
        }

        private void preImage_Click(object sender, EventArgs e) {
            if (currentImageIdx == 0) {
                return;
            }
            currentImageIdx--;
            updatePagesInfo();
            graphPanel.Invalidate(true);
        }

        private void removeToolBar_Click(object sender, EventArgs e) {
            if (!rects[currentSelectedRectKey].Show) {
                MessageBox.Show("没有任何标注框被选中!");
                return;
            }
            rects.Remove(currentSelectedRectKey);
            currentSelectedRectKey = 0;
            graphPanel.Invalidate(true);
        }

        private void showHiddenToolBar_Click(object sender, EventArgs e) {
            if (currentSelectedRectKey <= 0) {
                return;
            }
            updateShowHiddenToolBar();
            rects[currentSelectedRectKey].Show = !rects[currentSelectedRectKey].Show;
            graphPanel.Invalidate(true);
        }
        private void updateShowHiddenToolBar() {
            if (rects[currentSelectedRectKey].Show) {
                showHiddenToolBar.BackgroundImage = Properties.Resources.hidden;
            } else {
                showHiddenToolBar.BackgroundImage = Properties.Resources.show;
            }
        }
    }
}
