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
        private void disposeMeasureObjects()
        {
            selectedIndex = -1;
            moving = false;
            movingIndex = -1;
            MyCircles = new List<Point>();
            midPoint = new Point();
            newMethodInitialized = false;
            rotationValueChanged = false;
            distanceNewMethod = 0;
            distanceOldMethod = 0;
            updateDistanceLabels(0, 0);
        }
    }
}
