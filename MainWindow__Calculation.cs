using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ultrasonic_Ruler
{
    public partial class MainWindow : Form
    {
        public double distanceOldMethod;
        public double distanceNewMethod;
        private double calcDistance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        private double convertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }

        private Point transformPointToImage(Point p)
        {
            return new Point(p.X - 2 - (int)((pic_box_old_method.Width - pic_box_old_method.Image.Width) / 2), p.Y - (int)((pic_box_old_method.Height - pic_box_old_method.Image.Height) / 2));
        }
    }
}
