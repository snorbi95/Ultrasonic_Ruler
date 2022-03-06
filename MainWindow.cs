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
        public Bitmap inputImage, inputImage2;
        public int imageIndex = 0;
        public string[] imagePaths;
        List<Point> MyCircles = new List<Point>();
        Point firstPoint, secondPoint, midPoint, rotationPoint;
        Point controlPoint11, controlPoint12, controlPoint21, controlPoint22;


        public int selectedIndex;
        public bool moving = false;
        public bool rotating = false;
        public int movingIndex = -1;
        public bool newMethodInitialized = false;
        public bool oldMethodInitialized = false;
        public bool imageLoaded = false;

        public double lineDistanceToFirst = 50;
        public double lineDistanceToSecond = 50;
        public double controlLine1Distance = 100;
        public double controlLine2Distance = 100;

        public string csv = string.Empty;
        public string currentDate = string.Empty;

        Graphics g_old_method, g_new_method;
        Pen p, p2, p3, p_yellow;

        public MainWindow()
        {
            InitializeComponent();
            p = new Pen(Color.FromArgb(23, 255, 0), 3);
            p_yellow = new Pen(Color.Yellow, 3);
            p2 = new Pen(Color.FromArgb(255, 0, 0), 3);
            p3 = new Pen(Color.FromArgb(0, 0, 255), 3);
        }
    }
}
