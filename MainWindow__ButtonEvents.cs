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
        private void btn_single_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImage = new OpenFileDialog
            {
                Title = "Select image...",
                DefaultExt = "jpg"
            };

            if (openImage.ShowDialog() == DialogResult.OK)
            {
                imagePaths = new string[] { openImage.FileName };
                updateImageCountLabel();
                loadImageToBitmap(openImage.FileName);
            }
        }

        private void btn_open_folder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    imagePaths = Directory.GetFiles(fbd.SelectedPath);

                    updateImageCountLabel();
                    loadImageToBitmap(imagePaths[imageIndex]);
                }
            }
        }

        private void next_image_btn_Click(object sender, EventArgs e)
        {
            if (imageIndex < imagePaths.Length - 1)
            {
                imageIndex++;
                updateImageCountLabel();
                loadImageToBitmap(imagePaths[imageIndex]);
                disposeMeasureObjects();
            }
        }

        private void previous_image_btn_Click(object sender, EventArgs e)
        {
            if (imageIndex > 0)
            {
                imageIndex--;
                updateImageCountLabel();
                loadImageToBitmap(imagePaths[imageIndex]);
                disposeMeasureObjects();
            }
        }

        private void ctrl_line1_apply_btn_Click(object sender, EventArgs e)
        {
            if (Double.Parse(control_line1_textbox.Text) > 500)
            {
                control_line1_textbox.Text = "500";
            }
            else if (Double.Parse(control_line1_textbox.Text) < 5)
            {
                control_line1_textbox.Text = "5";
            }
                controlLine1Distance = Double.Parse(control_line1_textbox.Text);
            pic_box_new_method.Refresh();
        }

        private void ctrl_line2_apply_btn_Click(object sender, EventArgs e)
        {
            if (Double.Parse(control_line2_textbox.Text) > 500)
            {
                control_line2_textbox.Text = "500";
            }
            else if (Double.Parse(control_line2_textbox.Text) < 5)
            {
                control_line2_textbox.Text = "5";
            }
            controlLine2Distance = Double.Parse(control_line2_textbox.Text);
            pic_box_new_method.Refresh();
        }

        private void oper_folder_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Directory.GetCurrentDirectory() + "\\Exported");
        }

        private void save_measure_csv_Click(object sender, EventArgs e)
        {
            var csv = new StringBuilder();

            currentDate = DateTime.Now.ToString();
            //currentDate = currentDate.Replace("/", "_");
            //currentDate = currentDate.Replace(".", "_");
            //currentDate = currentDate.Replace(":", "_");

            //string first = reader[0].ToString();
            //string second = image.ToString();
            var newLine = string.Format("{0};{1};{2};{3}{4}", currentDate, Path.GetFileName(imagePaths[imageIndex]), distanceOldMethod.ToString(), distanceNewMethod.ToString(), Environment.NewLine);
            csv.Append(newLine);

            string folderPath = Directory.GetCurrentDirectory() + "/Exported/Exported_Measurements.csv";
            File.AppendAllText(folderPath, csv.ToString());
            saveImages();
            //csv += 'Image name' + ',' + "Old method" + "New method";
            //if (!Directory.Exists(folderPath))
            //    Directory.CreateDirectory(folderPath);
            //File.WriteAllText(folderPath + "/Exported_Measurements.csv", csv, Encoding.UTF8);
            //System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + "/Exported");
        }

        private void saveImages()
        {
            if(distanceOldMethod > 0)
            {
                drawOnImageOldMethod();
                string folderPathImage = Directory.GetCurrentDirectory() + "\\Exported\\Old method";
                if (!Directory.Exists(folderPathImage))
                    Directory.CreateDirectory(folderPathImage);
                pic_box_old_method.Image.Save(folderPathImage + "\\" + Path.GetFileName(imagePaths[imageIndex]).Split('.')[0] + "_" + distanceOldMethod.ToString() + ".png", ImageFormat.Png);
                //MessageBox.Show("Save successful!");
            }


            if (distanceNewMethod > 0)
            {
                drawOnImageNewMethod();
                string folderPathImageNew = Directory.GetCurrentDirectory() + "\\Exported\\New method";
                if (!Directory.Exists(folderPathImageNew))
                    Directory.CreateDirectory(folderPathImageNew);
                pic_box_new_method.Image.Save(folderPathImageNew + "\\" + Path.GetFileName(imagePaths[imageIndex]).Split('.')[0] + "_" + distanceNewMethod.ToString() + ".png", ImageFormat.Png);
                //MessageBox.Show("Save successful!");
            }

        }

        private void loadImageToBitmap(String path)
        {
            inputImage = new Bitmap(path);
            inputImage2 = new Bitmap(path);
            pic_box_old_method.Image = inputImage;
            pic_box_new_method.Image = inputImage2;
            g_old_method = Graphics.FromImage(pic_box_old_method.Image);
            g_new_method = Graphics.FromImage(pic_box_new_method.Image);
            imageLoaded = true;
        }

        private void drawOnImageOldMethod()
        {
            Point p_tmp;
            g_old_method = Graphics.FromImage(pic_box_old_method.Image);
            for (int i = 0; i < MyCircles.Count; i++)
            {
                p_tmp = transformPointToImage(MyCircles[i]);
                g_old_method.DrawEllipse(p_yellow, p_tmp.X - 3, p_tmp.Y - 3, 7, 7);
            }
            g_old_method.DrawLine(p, transformPointToImage(MyCircles[0]), transformPointToImage(MyCircles[1]));
        }

        private void drawOnImageNewMethod()
        {
            Point p_tmp;
            g_new_method = Graphics.FromImage(pic_box_new_method.Image);

            g_new_method.DrawLine(p, transformPointToImage(controlPoint11),transformPointToImage(controlPoint12));
            g_new_method.DrawLine(p, transformPointToImage(controlPoint21), transformPointToImage(controlPoint22));
            g_new_method.DrawLine(p, transformPointToImage(firstPoint), transformPointToImage(secondPoint));

            p_tmp = transformPointToImage(firstPoint);
            g_new_method.DrawEllipse(p2, p_tmp.X - 3,  p_tmp.Y - 3, 7, 7);
            p_tmp = transformPointToImage(secondPoint);
            g_new_method.DrawEllipse(p3, p_tmp.X - 3, p_tmp.Y - 3, 7, 7);
            p_tmp = transformPointToImage(midPoint);
            g_new_method.DrawEllipse(p_yellow, p_tmp.X - 3, p_tmp.Y - 3, 7, 7);
        }
    }
}
