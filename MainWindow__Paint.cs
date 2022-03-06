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
        private void pic_box_old_method_Paint(object sender, PaintEventArgs e)
        {
            if (imageLoaded)
            {
                pic_box_old_method.Invalidate();
                //g = Graphics.FromImage(pic_box_old_method.Image);
                for (int i = 0; i < MyCircles.Count; i++)
                {
                    e.Graphics.DrawEllipse(p_yellow, MyCircles[i].X - 3, MyCircles[i].Y - 3, 7, 7);
                    //g_old_method.DrawEllipse(p, MyCircles[i].X - 2 - (int)((pic_box_old_method.Width - pic_box_old_method.Image.Width) /2), MyCircles[i].Y - (int)((pic_box_old_method.Height - pic_box_old_method.Image.Height) / 2), 5, 5);
                }
                if (MyCircles.Count == 2)
                {
                    e.Graphics.DrawLine(p, MyCircles[0], MyCircles[1]);
                    distanceOldMethod = Math.Round(calcDistance(MyCircles[0], MyCircles[1]),2);
                    updateDistanceLabels(distanceOldMethod, distanceNewMethod);
                    //distanceLabel.Text = distanceOldMethod.ToString() + " px";
                }
            }
        }

        //new method picture box
        private void pic_box_new_method_Paint(object sender, PaintEventArgs e)
        {
            var cursorPosition = pic_box_new_method.PointToClient(Cursor.Position);
            if(newMethodInitialized == true)
            {
                //if ((cursorPosition.X > 0 && cursorPosition.Y > 0) || (rotationValueChanged))
                //{
                    //firstPoint = new Point(midPoint.X - ((int)lineDistance / 2), midPoint.Y);
                    //secondPoint = new Point(midPoint.X + ((int)lineDistance / 2), firstPoint.Y);
                    firstPoint = new Point((int)(midPoint.X + Math.Cos(convertToRadians(lineDegree)) * (-lineDistanceToFirst)), (int)(midPoint.Y + Math.Sin(convertToRadians(lineDegree)) * (-lineDistanceToFirst)));
                    secondPoint = new Point((int)(midPoint.X + Math.Cos(convertToRadians(lineDegree)) * lineDistanceToSecond), (int)(midPoint.Y + Math.Sin(convertToRadians(lineDegree)) * lineDistanceToSecond));

                    controlPoint11 = new Point((int)(firstPoint.X + Math.Cos(convertToRadians(lineDegree + 90)) * (-controlLine1Distance)), (int)(firstPoint.Y + Math.Sin(convertToRadians(lineDegree + 90)) * (-controlLine1Distance)));
                    controlPoint12 = new Point((int)(firstPoint.X + Math.Cos(convertToRadians(lineDegree + 90)) * (controlLine1Distance)), (int)(firstPoint.Y + Math.Sin(convertToRadians(lineDegree + 90)) * (controlLine1Distance)));
                    controlPoint21 = new Point((int)(secondPoint.X + Math.Cos(convertToRadians(lineDegree + 90)) * (-controlLine2Distance)), (int)(secondPoint.Y + Math.Sin(convertToRadians(lineDegree + 90)) * (-controlLine2Distance)));
                    controlPoint22 = new Point((int)(secondPoint.X + Math.Cos(convertToRadians(lineDegree + 90)) * (controlLine2Distance)), (int)(secondPoint.Y + Math.Sin(convertToRadians(lineDegree + 90)) * (controlLine2Distance)));

                    //firstPoint = calcRotation(firstPoint, lineDegree);
                    //secondPoint = calcRotation(secondPoint, lineDegree);
                    e.Graphics.DrawLine(p, controlPoint11, controlPoint12);
                    e.Graphics.DrawLine(p, controlPoint21, controlPoint22);
                    e.Graphics.DrawLine(p, firstPoint, secondPoint);

                    e.Graphics.DrawEllipse(p2, firstPoint.X - 3, firstPoint.Y - 3, 7, 7);
                    e.Graphics.DrawEllipse(p3, secondPoint.X - 3, secondPoint.Y - 3, 7, 7);
                    e.Graphics.DrawEllipse(p_yellow, midPoint.X - 3, midPoint.Y - 3, 7, 7);

                    distanceNewMethod = Math.Round(calcDistance(firstPoint, secondPoint), 2);
                    updateDistanceLabels(distanceOldMethod, distanceNewMethod);
                    //distance_label_new.Text = distanceNewMethod.ToString() + " px";

                    //newMethodInitialized = true;

                    //if (rotationValueChanged)
                    //{
                    //    rotationValueChanged = false;
                    //}
                //}
            }
          
        }
    }
}
