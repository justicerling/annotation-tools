using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    partial class Form1 {


        private int currentZoomRectIndex = 0;
        private Point preZoomPoint;
        private int currentSelectedRectKey;

        private void Graph_Panel_Mouse_Down(object sender, MouseEventArgs e) {

            if (e.Button == MouseButtons.Left) {
                ///鼠标的当前位置
                foreach (int rectKey in rects.Keys) {
                    if (!rects[rectKey].Show) {
                        continue;
                    }
                    //贴近边线10px后才可以拖动
                    Rectangle drawedRectangle = rects[rectKey].DrawedRectangle;
                    //选中
                    if (drawedRectangle.Contains(e.Location)) {
                        if (currentSelectedRectKey == rectKey) {
                            currentSelectedRectKey = 0;
                        } else {
                            currentSelectedRectKey = rectKey;
                            if (rects[currentSelectedRectKey].Show) {
                                showHiddenToolBar.BackgroundImage = Properties.Resources.show;
                            } else {
                                showHiddenToolBar.BackgroundImage = Properties.Resources.hidden;
                            }
                            Console.WriteLine("选中矩形:" + rectKey);
                        }
                    }
                    Rectangle DragRange = new Rectangle(drawedRectangle.X + 10, drawedRectangle.Y - 10, drawedRectangle.Width - 10, drawedRectangle.Height - 10);
                    if (DragRange.Contains(e.Location)) {
                        Cursor.Current = Cursors.SizeAll;
                        drawNewFlag = false;
                        dragPointPre = e.Location;
                        currentDragIndex = rectKey;
                        return;
                    }
                    if (IsInZoomRange(drawedRectangle, e.Location)) {
                        currentZoomRectIndex = rectKey;
                        preZoomPoint = e.Location;
                        return;
                    }
                }
                if (currentActivedAnno == null || imagePaths == null || imagePaths.Length == 0) {
                    return;
                }
                drawNewFlag = true;
                drawPen.Color = currentActivedAnno.Color;
                fPoint.X = e.X;
                fPoint.Y = e.Y;
                //画新矩形 当前下标+1
                currentIndex++;
                Rectangle rectangle = new Rectangle(fPoint.X, fPoint.Y, 0, 0);
                Annotation newAnno = new Annotation();
                newAnno.DrawedRectangle = rectangle;
                newAnno.Color = currentActivedAnno.Color;
                newAnno.Name = currentActivedAnno.Name;
                newAnno.Desc = currentActivedAnno.Desc;
                newAnno.Show = true;
                rects.Add(currentIndex, newAnno);
                prePosintion = Cursor.Position;
                Console.WriteLine("开始坐标：X=" + e.X + ",Y=" + e.Y);
            }
        }

        private void Graph_Panel_Mouse_Up(object sender, MouseEventArgs e) {
            if (e.Button != MouseButtons.Left) return;
            Point cPoint = e.Location;
            if (currentDragIndex > 0) {
                //矩形拖拽
                Console.WriteLine("拖拽矩形INDEX:" + currentDragIndex);
                Annotation dragedAnno = rects[currentDragIndex];
                Rectangle dragedRect = dragedAnno.DrawedRectangle;
                dragedRect.X = dragedAnno.DrawedRectangle.X + (cPoint.X - dragPointPre.X);
                dragedRect.Y = dragedRect.Y + (cPoint.Y - dragPointPre.Y);
                dragPointPre = cPoint;
                dragedAnno.DrawedRectangle = dragedRect;
                rects[currentDragIndex] = dragedAnno;
                graphPanel.Invalidate(true);
                currentDragIndex = 0;//将当前拖拽的矩形下标置空
                return;
            }
            if (drawNewFlag) {
                Console.WriteLine("UP-画新矩形:index=" + currentIndex);
                //画新的矩形
                drawNewFlag = false;
                ePoint = e.Location;
                if ((Math.Abs(ePoint.X - fPoint.X) < 5) || Math.Abs(ePoint.Y - fPoint.Y) < 5) {
                    rects.Remove(currentIndex);
                    return;
                }
                BeforeDrawRect();
                graphPanel.Invalidate(true);
            }

            if (currentZoomRectIndex > 0) {
                Rectangle zoomRect = rects[currentZoomRectIndex].DrawedRectangle;
                if (Cursor.Current == Cursors.SizeNS) {
                    //垂直拖放
                    zoomRect.Height += cPoint.Y - preZoomPoint.Y;
                }
                if (Cursor.Current == Cursors.SizeWE) {
                    //水平拖放
                    zoomRect.Width += cPoint.X - preZoomPoint.X;
                }
                if (Cursor.Current == Cursors.SizeNWSE) {
                    //东南角拖放
                    zoomRect.Width += cPoint.X - preZoomPoint.X;
                    zoomRect.Height += cPoint.Y - preZoomPoint.Y;
                }
                preZoomPoint = cPoint;
                rects[currentZoomRectIndex].DrawedRectangle = zoomRect;
                graphPanel.Invalidate(true);
                currentZoomRectIndex = 0;
            }
        }

        private void Graph_Panel__Size_Changed_ReLoad_Gra(object sender, EventArgs e) {
            if (panelPreW == 0 || panelPreH == 0) {
                panelPreW = graphPanel.Width;
                panelPreH = graphPanel.Height;
                return;
            }
            double xZoom = ((double)graphPanel.Width) / ((double)panelPreW);
            double yZoom = ((double)graphPanel.Height) / ((double)panelPreH);
            panelPreW = graphPanel.Width;
            panelPreH = graphPanel.Height;
            //重绘矩形
            //所有矩形需要重绘
            Dictionary<int, Annotation> temp = new Dictionary<int, Annotation>();
            if (rects == null) {
                return;
            }
            foreach (int rectKey in rects.Keys) {
                Annotation temAnno = rects[rectKey];
                Rectangle rect = temAnno.DrawedRectangle;
                rect.X = (int)Math.Round(rect.X * xZoom, 0);
                rect.Y = (int)Math.Round(rect.Y * yZoom);
                rect.Width = (int)Math.Round(rect.Width * xZoom);
                rect.Height = (int)Math.Round(rect.Height * yZoom);
                temAnno.DrawedRectangle = rect;
                temp.Add(rectKey, temAnno);
            }
            rects = temp;
            graphPanel.Invalidate(true);
            Console.WriteLine("当前共有矩形:" + rects.Count + "个");
        }

        private void Graph_Panel_Mouse_Move(object sender, MouseEventArgs e) {

            Point cPoint = e.Location;
            if (e.Button == MouseButtons.Left) {
                if (drawNewFlag) {
                    //Console.WriteLine("MOVE-画新矩形:index=" + currentIndex);
                    //画新的矩形
                    ePoint = e.Location;
                    BeforeDrawRect();
                    graphPanel.Invalidate(true);
                    return;
                }
                if (currentDragIndex > 0) {
                    //矩形拖拽
                    Console.WriteLine("MOVE-拖拽矩形INDEX:" + currentDragIndex);
                    Rectangle dragedRect = rects[currentDragIndex].DrawedRectangle;
                    dragedRect.X = dragedRect.X + (cPoint.X - dragPointPre.X);
                    dragedRect.Y = dragedRect.Y + (cPoint.Y - dragPointPre.Y);
                    dragPointPre = cPoint;
                    rects[currentDragIndex].DrawedRectangle = dragedRect;
                    graphPanel.Invalidate(true);
                    return;
                }
                if (currentZoomRectIndex > 0) {
                    Rectangle zoomRect = rects[currentZoomRectIndex].DrawedRectangle;
                    if (Cursor.Current == Cursors.SizeNS) {
                        //垂直拖放
                        zoomRect.Height += cPoint.Y - preZoomPoint.Y;
                        if (zoomRect.Height < 0) {
                            zoomRect.Height = -zoomRect.Height;
                        }
                    }
                    if (Cursor.Current == Cursors.SizeWE) {
                        //水平拖放
                        zoomRect.Width += cPoint.X - preZoomPoint.X;
                        if (zoomRect.Width < 0) {
                            zoomRect.Width = -zoomRect.Width;
                        }
                    }
                    if (Cursor.Current == Cursors.SizeNWSE) {
                        //东南角拖放
                        zoomRect.Width += cPoint.X - preZoomPoint.X;
                        zoomRect.Height += cPoint.Y - preZoomPoint.Y;
                    }
                    BeforeDrawRect(preZoomPoint, cPoint);
                    preZoomPoint = cPoint;
                    rects[currentZoomRectIndex].DrawedRectangle = zoomRect;
                    graphPanel.Invalidate(true);
                }
            }


            if (currentZoomRectIndex == 0) {
                foreach (int rectKey in rects.Keys) {
                    Rectangle rectangle = rects[rectKey].DrawedRectangle;
                    if (IsInZoomRange(rectangle, cPoint)) {
                        //currentZoomRectIndex = rectKey;
                    }
                }
            }

        }

        private void Graph_Panel_On_Paint(object sender, PaintEventArgs e) {
            if (imagePaths != null && imagePaths.Length > 0 && currentImageIdx < imagePaths.Length) {
                gra = e.Graphics;
                //重绘背景
                //gra.FillRectangle(new SolidBrush(Color.LightGray), graphPanel.Location.X, graphPanel.Location.Y, graphPanel.Width, graphPanel.Height);
                Image image = Image.FromFile(imagePaths[currentImageIdx]);
                Rectangle imageRect = new Rectangle(graphPanel.Location.X, graphPanel.Location.Y, graphPanel.Width, graphPanel.Height);
                gra.DrawImage(image, imageRect);
                foreach (int rectKey in rects.Keys) {
                    if (rects[rectKey].Show) {
                        drawPen.Color = rects[rectKey].Color;
                        gra.DrawRectangle(drawPen, rects[rectKey].DrawedRectangle);
                        if (currentSelectedRectKey > 0 && currentSelectedRectKey == rectKey) {
                            gra.FillRectangle(new SolidBrush(Color.FromArgb(128, Color.Orange)), rects[rectKey].DrawedRectangle);
                        }
                    }
                }
            }
        }

        private void BeforeDrawRect() {
            BeforeDrawRect(fPoint, ePoint);
        }

        private void BeforeDrawRect(Point fPoint1, Point ePoint1) {
            Console.WriteLine("结束坐标：X=" + ePoint1.X + ",Y=" + ePoint1.Y);
            ///边界处理
            int X_R_Boundary = graphPanel.Location.X + graphPanel.Width;
            int X_L_Boundary = graphPanel.Location.X;
            int Y_T_Boundary = graphPanel.Location.Y;
            int Y_B_Boundary = graphPanel.Location.Y + graphPanel.Height;
            if (ePoint1.X >= X_R_Boundary) {
                ePoint1.X = X_R_Boundary - 3;
            }
            if (ePoint1.X <= X_L_Boundary) {
                ePoint1.X = X_L_Boundary;
            }
            if (ePoint1.Y >= Y_B_Boundary) {
                ePoint1.Y = Y_B_Boundary - 3;
            }
            if (ePoint1.Y <= Y_T_Boundary) {
                ePoint1.Y = Y_T_Boundary;
            }
            ///反向画图处理
            Rectangle rectangle = rects[currentIndex].DrawedRectangle;
            if (ePoint1.X < fPoint1.X) {
                rectangle.X = ePoint1.X;
                rectangle.Width = fPoint1.X - ePoint.X;
            } else {
                rectangle.X = fPoint1.X;
                rectangle.Width = ePoint1.X - fPoint1.X;
            }
            if (ePoint1.Y < fPoint1.Y) {
                rectangle.Y = ePoint1.Y;
                rectangle.Height = fPoint1.Y - ePoint1.Y;
            } else {
                rectangle.Y = fPoint1.Y;
                rectangle.Height = ePoint1.Y - fPoint1.Y;
            }
            if (rectangle.Width == 0 || rectangle.Height == 0) {
                return;
            }
            rects[currentIndex].DrawedRectangle = rectangle;
        }


        public Boolean IsInZoomRange(Rectangle rectangle, Point curent) {
            //下边垂直拖放
            Rectangle bottomZoomRange = new Rectangle(rectangle.X + 5, rectangle.Y + rectangle.Height - 5, rectangle.Width - 10, 10);
            if (bottomZoomRange.Contains(curent)) {
                Cursor.Current = Cursors.SizeNS;
                return true;
            }
            //上边垂直拖放
            Rectangle topZoomRange = new Rectangle(rectangle.X + 5, rectangle.Y - 5, rectangle.Width - 10, 10);
            if (topZoomRange.Contains(curent)) {
                Cursor.Current = Cursors.SizeNS;
                return true;
            }
            //右边水平拖放
            Rectangle rightZoomRange = new Rectangle(rectangle.X + rectangle.Width - 5, rectangle.Y + 5, 10, rectangle.Height - 10);
            if (rightZoomRange.Contains(curent)) {
                Cursor.Current = Cursors.SizeWE;
                return true;
            }
            ////左边水平拖放
            Rectangle leftZoomRange = new Rectangle(rectangle.X - 5, rectangle.Y + 5, 10, rectangle.Height - 10);
            if (leftZoomRange.Contains(curent)) {
                Cursor.Current = Cursors.SizeWE;
                return true;
            }
            //右下角拉伸
            Rectangle lowerRightZoomRange = new Rectangle(rectangle.X + rectangle.Width - 5, rectangle.Y + rectangle.Height - 5, 10, 10);
            if (lowerRightZoomRange.Contains(curent)) {
                Cursor.Current = Cursors.SizeNWSE;
                return true;
            }
            return false;
        }
        private void AnnoAddBtn_Click(object sender, EventArgs e) {
            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.CenterScreen;
            form2.Show();
            form2.FormClosed += new FormClosedEventHandler(this.Form2_Colse);
        }
    }
}
