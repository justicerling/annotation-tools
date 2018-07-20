using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    partial class Form1 {


        private int currentZoomRectIndex = 0;
        private Point preZoomPoint;

        private void Graph_Panel_Mouse_Down(object sender, MouseEventArgs e) {

            if (e.Button == MouseButtons.Left) {
                ///鼠标的当前位置
                foreach (int rectKey in rects.Keys) {
                    //贴近边线10px后才可以拖动
                    Rectangle DragRange = new Rectangle(rects[rectKey].X + 10, rects[rectKey].Y - 10, rects[rectKey].Width - 10, rects[rectKey].Height - 10);
                    if (DragRange.Contains(e.Location)) {
                        Cursor.Current = Cursors.SizeAll;
                        drawNewFlag = false;
                        dragPointPre = e.Location;
                        currentDragIndex = rectKey;
                        return;
                    }
                    Rectangle rect = rects[rectKey];
                    if (IsInZoomRange(rect, e.Location)) {
                        currentZoomRectIndex = rectKey;
                        preZoomPoint = e.Location;
                        return;
                    }
                }
                drawNewFlag = true;
                fPoint.X = e.X;
                fPoint.Y = e.Y;
                //画新矩形 当前下标+1
                currentIndex++;
                Rectangle rectangle = new Rectangle(fPoint.X, fPoint.Y, 0, 0);
                rects.Add(currentIndex, rectangle);
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
                Rectangle dragedRect = rects[currentDragIndex];
                dragedRect.X = dragedRect.X + (cPoint.X - dragPointPre.X);
                dragedRect.Y = dragedRect.Y + (cPoint.Y - dragPointPre.Y);
                dragPointPre = cPoint;
                rects[currentDragIndex] = dragedRect;
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
                Rectangle zoomRect = rects[currentZoomRectIndex];
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
                rects[currentZoomRectIndex] = zoomRect;
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
            Dictionary<int, Rectangle> temp = new Dictionary<int, Rectangle>();
            foreach (int rectKey in rects.Keys) {
                Rectangle rect = rects[rectKey];
                rect.X = (int)Math.Round(rects[rectKey].X * xZoom, 0);
                rect.Y = (int)Math.Round(rects[rectKey].Y * yZoom);
                rect.Width = (int)Math.Round(rects[rectKey].Width * xZoom);
                rect.Height = (int)Math.Round(rects[rectKey].Height * yZoom);
                temp.Add(rectKey, rect);
            }
            rects = temp;
            graphPanel.Invalidate(true);
            Console.WriteLine("当前共有矩形:" + rects.Count + "个");
        }

        private void Graph_Panel_Mouse_Move(object sender, MouseEventArgs e) {

            Point cPoint = e.Location;
            if (e.Button == MouseButtons.Left) {
                if (drawNewFlag) {
                    Console.WriteLine("MOVE-画新矩形:index=" + currentIndex);
                    //画新的矩形
                    ePoint = e.Location;
                    BeforeDrawRect();
                    graphPanel.Invalidate(true);
                    return;
                }
                if (currentDragIndex > 0) {
                    //矩形拖拽
                    Console.WriteLine("MOVE-拖拽矩形INDEX:" + currentDragIndex);
                    Rectangle dragedRect = rects[currentDragIndex];
                    dragedRect.X = dragedRect.X + (cPoint.X - dragPointPre.X);
                    dragedRect.Y = dragedRect.Y + (cPoint.Y - dragPointPre.Y);
                    dragPointPre = cPoint;
                    rects[currentDragIndex] = dragedRect;
                    graphPanel.Invalidate(true);
                    return;
                }
                if (currentZoomRectIndex > 0) {
                    Rectangle zoomRect = rects[currentZoomRectIndex];
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
                    rects[currentZoomRectIndex] = zoomRect;
                    graphPanel.Invalidate(true);
                }
            }


            if (currentZoomRectIndex == 0) {
                foreach (int rectKey in rects.Keys) {
                    Rectangle rectangle = rects[rectKey];
                    if (IsInZoomRange(rectangle, cPoint)) {
                        //currentZoomRectIndex = rectKey;
                    }
                }
            }

        }

        private void Graph_Panel_On_Paint(object sender, PaintEventArgs e) {

            gra = e.Graphics;
            //重绘背景
            //gra.FillRectangle(new SolidBrush(Color.LightGray), graphPanel.Location.X, graphPanel.Location.Y, graphPanel.Width, graphPanel.Height);
            Image image = Image.FromFile("D:\\Users\\tuqiangfan\\source\\repos\\NewRepo\\WindowsFormsApp1\\Resources\\PHO_20180514_08324500A.JPG");
            Rectangle imageRect = new Rectangle(graphPanel.Location.X, graphPanel.Location.Y, graphPanel.Width, graphPanel.Height);
            gra.DrawImage(image, imageRect);
            foreach (int rectKey in rects.Keys) {
                //Rectangle rect = rects[rectKey];
                gra.DrawRectangle(drawPen, rects[rectKey]);
            }
        }

        private void BeforeDrawRect() {
            Console.WriteLine("结束坐标：X=" + ePoint.X + ",Y=" + ePoint.Y);
            ///边界处理
            int X_R_Boundary = graphPanel.Location.X + graphPanel.Width;
            int X_L_Boundary = graphPanel.Location.X;
            int Y_T_Boundary = graphPanel.Location.Y;
            int Y_B_Boundary = graphPanel.Location.Y + graphPanel.Height;
            if (ePoint.X >= X_R_Boundary) {
                ePoint.X = X_R_Boundary - 3;
            }
            if (ePoint.X <= X_L_Boundary) {
                ePoint.X = X_L_Boundary;
            }
            if (ePoint.Y >= Y_B_Boundary) {
                ePoint.Y = Y_B_Boundary - 3;
            }
            if (ePoint.Y <= Y_T_Boundary) {
                ePoint.Y = Y_T_Boundary;
            }
            ///反向画图处理
            Rectangle rectangle = rects[currentIndex];
            if (ePoint.X < fPoint.X) {
                int tempX = fPoint.X;
                fPoint.X = ePoint.X;
                ePoint.X = tempX;
            }
            if (ePoint.Y < fPoint.Y) {
                int tempY = fPoint.Y;
                fPoint.Y = ePoint.Y;
                ePoint.Y = tempY;
            }
            rectangle.X = fPoint.X;
            rectangle.Y = fPoint.Y;
            rectangle.Width = ePoint.X - fPoint.X;
            rectangle.Height = ePoint.Y - fPoint.Y;
            if (rectangle.Width == 0 || rectangle.Height == 0) {
                return;
            }
            rects[currentIndex] = rectangle;
            Console.WriteLine("实际画图坐标：" + rectangle);
        }
        

        public Boolean IsInZoomRange(Rectangle rectangle, Point curent) {
            //下边垂直拖放
            Rectangle bottomZoomRange = new Rectangle(rectangle.X + 5, rectangle.Y + rectangle.Height - 5, rectangle.Width - 10, 10);
            if (bottomZoomRange.Contains(curent)) {
                Cursor.Current = Cursors.SizeNS;
                return true;
            }
            //右边水平拖放
            Rectangle leftZoomRange = new Rectangle(rectangle.X + rectangle.Width - 5, rectangle.Y + 5, 10, rectangle.Height - 10);
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
    }
}
