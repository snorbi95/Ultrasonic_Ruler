﻿using System;
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

        private void tab_methods_SelectedIndexChanged(object sender, EventArgs e)
        {
            pic_box_new_method.Refresh();
            pic_box_old_method.Refresh();
        }

    }
}
