using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ultrasonic_Ruler
{
    public partial class MainWindow : Form
    {
        private void pic_box_old_method_MouseDown(object sender, MouseEventArgs e)
        {
            if (imageLoaded)
            {
                if (MyCircles.Count < 2)
                {
                    //g = Graphics.FromImage(pic_box_old_method.Image);

                    var cursorPosition = pic_box_old_method.PointToClient(Cursor.Position);
                    if (cursorPosition.X > 0 && cursorPosition.Y > 0)
                    {
                        cursorPosition.X = e.X;//(cursorPosition.X - pic_box_old_method.Location.X) - ((pic_box_old_method.Width - pic_box_old_method.Image.Width) / 2);
                        cursorPosition.Y = e.Y;//(cursorPosition.Y - pic_box_old_method.Location.Y) - ((pic_box_old_method.Height - pic_box_old_method.Image.Height) / 2);

                        MyCircles.Add(cursorPosition);
                        //g.DrawEllipse(p, cursorPosition.X - 2, cursorPosition.Y - 2, 5, 5);
                        pic_box_old_method.Refresh();
                        //this.Invalidate();
                    }
                }
                else
                {
                    for (int i = 0; i < MyCircles.Count; i++)
                    {
                        if (hitTest(MyCircles[i].X, MyCircles[i].Y, e.X, e.Y))
                        {
                            selectedIndex = i;
                            moving = true;
                            //this.Invalidate();
                        }
                    }
                }
            }
        }

        private bool hitTest(double x1, double y1, double x2, double y2)
        {
            if (Math.Abs(x1 - x2) < 5 && Math.Abs(y1 - y2) < 5)
                return true;
            return false;
        }

        private void pic_box_old_method_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                var cursorPosition = pic_box_old_method.PointToClient(Cursor.Position);
                if (cursorPosition.X > 0 && cursorPosition.Y > 0) {
                    var newPoint = new Point(e.X, e.Y);
                    MyCircles[selectedIndex] = newPoint;
                    pic_box_old_method.Refresh();
                }
            }
        }

        private void pic_box_old_method_MouseUp(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                selectedIndex = -1;
                moving = false;
            }
        }

        //new method picture box
        private void pic_box_new_method_MouseDown(object sender, MouseEventArgs e)
        {
            if (imageLoaded)
            {
                var cursorPosition = pic_box_new_method.PointToClient(Cursor.Position);
                if (cursorPosition.X > 10 && cursorPosition.Y > 10)
                {
                    if (!newMethodInitialized)
                    {
                        midPoint = new Point(e.X, e.Y);
                        newMethodInitialized = true;
                        pic_box_new_method.Refresh();
                    }
                    else
                    {
                        if(e.Button == MouseButtons.Left)
                        {
                            if (hitTest(midPoint.X, midPoint.Y, e.X, e.Y))
                            {
                                moving = true;
                                movingIndex = 1;
                            }
                            else if (hitTest(firstPoint.X, firstPoint.Y, e.X, e.Y))
                            {
                                moving = true;
                                movingIndex = 2;
                            }
                            else if (hitTest(secondPoint.X, secondPoint.Y, e.X, e.Y))
                            {
                                moving = true;
                                movingIndex = 3;
                            }
                        }
                        else if(e.Button == MouseButtons.Right)
                        {
                            if (hitTest(midPoint.X, midPoint.Y, e.X, e.Y))
                            {
                                rotating = true;
                                rotationPoint = midPoint;
                            }
                        }
                    }
                   
                }
            }

        }

        private void pic_box_new_method_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                var cursorPosition = pic_box_new_method.PointToClient(Cursor.Position);
                var newPoint = new Point(e.X, e.Y);
                switch (movingIndex)
                {
                    case 1:
                        if (cursorPosition.X > 0 && cursorPosition.Y > 0)
                            midPoint = newPoint;
                        break;
                    case 2:
                        var dis = firstPoint.X - e.X;
                        if (firstPoint.X > secondPoint.X)
                        {
                            dis = e.X - firstPoint.X;
                        }
                        lineDistanceToFirst += dis;
                        break;
                    case 3:
                        var dis2 = secondPoint.X - e.X;
                        if (secondPoint.X < firstPoint.X)
                        {
                            dis2 = e.X - secondPoint.X;
                        }
                        lineDistanceToSecond -= dis2;
                        break;
                }
                if (lineDistanceToFirst < 15)
                    lineDistanceToFirst = 15;
                if (lineDistanceToSecond < 15)
                    lineDistanceToSecond = 15;
                pic_box_new_method.Refresh();
            }
            else if (rotating)
            {
                var cursorPosition = pic_box_new_method.PointToClient(Cursor.Position);
                var newPoint = new Point(e.X, e.Y);
                var diff = (rotationPoint.X - e.X) / 2;
                lineDegree += diff;
                rotationPoint = e.Location;
                pic_box_new_method.Refresh();
            }
        }

        private void pic_box_new_method_MouseUp(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                moving = false;
                movingIndex = -1;
            }
            else if (rotating)
            {
                rotating = false;
            }
        }
    }
}
