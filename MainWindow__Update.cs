using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ultrasonic_Ruler
{
    public partial class MainWindow : Form
    {
        private void updateImageCountLabel()
        {
            image_count_label.Text = "Number of images: " + (imageIndex + 1) + "/" + (imagePaths.Length);
            updateImageNameLabel();
        }

        private void updateImageNameLabel()
        {
            image_name_label.Text = "Image name: " + Path.GetFileName(imagePaths[imageIndex]);
        }

        private void updateDistanceLabels(double d1, double d2)
        {
            distanceLabel.Text = d1.ToString() + " px";
            distance_label_new.Text = d2.ToString() + " px";
        }
    }
}
