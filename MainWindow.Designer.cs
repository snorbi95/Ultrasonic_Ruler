
namespace Ultrasonic_Ruler
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_single_image = new System.Windows.Forms.Button();
            this.btn_open_folder = new System.Windows.Forms.Button();
            this.tab_methods = new System.Windows.Forms.TabControl();
            this.tab_old_method = new System.Windows.Forms.TabPage();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_box_old_method = new System.Windows.Forms.PictureBox();
            this.tab_new_method = new System.Windows.Forms.TabPage();
            this.ctrl_line2_apply_btn = new System.Windows.Forms.Button();
            this.ctrl_line1_apply_btn = new System.Windows.Forms.Button();
            this.control_line2_textbox = new System.Windows.Forms.TextBox();
            this.control_line1_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.distance_label_new = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pic_box_new_method = new System.Windows.Forms.PictureBox();
            this.previous_image_btn = new System.Windows.Forms.Button();
            this.next_image_btn = new System.Windows.Forms.Button();
            this.image_count_label = new System.Windows.Forms.Label();
            this.image_name_label = new System.Windows.Forms.Label();
            this.save_measure_csv = new System.Windows.Forms.Button();
            this.oper_folder_btn = new System.Windows.Forms.Button();
            this.tab_methods.SuspendLayout();
            this.tab_old_method.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_old_method)).BeginInit();
            this.tab_new_method.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_new_method)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_single_image
            // 
            this.btn_single_image.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_single_image.Location = new System.Drawing.Point(21, 36);
            this.btn_single_image.Name = "btn_single_image";
            this.btn_single_image.Size = new System.Drawing.Size(99, 38);
            this.btn_single_image.TabIndex = 0;
            this.btn_single_image.Text = "Open single image";
            this.btn_single_image.UseVisualStyleBackColor = true;
            this.btn_single_image.Click += new System.EventHandler(this.btn_single_image_Click);
            // 
            // btn_open_folder
            // 
            this.btn_open_folder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_open_folder.Location = new System.Drawing.Point(140, 36);
            this.btn_open_folder.Name = "btn_open_folder";
            this.btn_open_folder.Size = new System.Drawing.Size(99, 38);
            this.btn_open_folder.TabIndex = 1;
            this.btn_open_folder.Text = "Open folder";
            this.btn_open_folder.UseVisualStyleBackColor = true;
            this.btn_open_folder.Click += new System.EventHandler(this.btn_open_folder_Click);
            // 
            // tab_methods
            // 
            this.tab_methods.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tab_methods.Controls.Add(this.tab_old_method);
            this.tab_methods.Controls.Add(this.tab_new_method);
            this.tab_methods.Location = new System.Drawing.Point(19, 80);
            this.tab_methods.Name = "tab_methods";
            this.tab_methods.SelectedIndex = 0;
            this.tab_methods.Size = new System.Drawing.Size(1300, 763);
            this.tab_methods.TabIndex = 2;
            this.tab_methods.SelectedIndexChanged += new System.EventHandler(this.tab_methods_SelectedIndexChanged);
            // 
            // tab_old_method
            // 
            this.tab_old_method.Controls.Add(this.distanceLabel);
            this.tab_old_method.Controls.Add(this.label1);
            this.tab_old_method.Controls.Add(this.pic_box_old_method);
            this.tab_old_method.Location = new System.Drawing.Point(4, 24);
            this.tab_old_method.Name = "tab_old_method";
            this.tab_old_method.Padding = new System.Windows.Forms.Padding(3);
            this.tab_old_method.Size = new System.Drawing.Size(1292, 735);
            this.tab_old_method.TabIndex = 0;
            this.tab_old_method.Text = "Old method";
            this.tab_old_method.UseVisualStyleBackColor = true;
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.distanceLabel.ForeColor = System.Drawing.Color.Red;
            this.distanceLabel.Location = new System.Drawing.Point(689, 9);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(51, 25);
            this.distanceLabel.TabIndex = 2;
            this.distanceLabel.Text = "0 px";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(500, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distance (pixels): ";
            // 
            // pic_box_old_method
            // 
            this.pic_box_old_method.Location = new System.Drawing.Point(28, 65);
            this.pic_box_old_method.Name = "pic_box_old_method";
            this.pic_box_old_method.Size = new System.Drawing.Size(1225, 613);
            this.pic_box_old_method.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_box_old_method.TabIndex = 0;
            this.pic_box_old_method.TabStop = false;
            this.pic_box_old_method.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_box_old_method_Paint);
            this.pic_box_old_method.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_box_old_method_MouseDown);
            this.pic_box_old_method.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_box_old_method_MouseMove);
            this.pic_box_old_method.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_box_old_method_MouseUp);
            // 
            // tab_new_method
            // 
            this.tab_new_method.Controls.Add(this.ctrl_line2_apply_btn);
            this.tab_new_method.Controls.Add(this.ctrl_line1_apply_btn);
            this.tab_new_method.Controls.Add(this.control_line2_textbox);
            this.tab_new_method.Controls.Add(this.control_line1_textbox);
            this.tab_new_method.Controls.Add(this.label4);
            this.tab_new_method.Controls.Add(this.label2);
            this.tab_new_method.Controls.Add(this.distance_label_new);
            this.tab_new_method.Controls.Add(this.label3);
            this.tab_new_method.Controls.Add(this.pic_box_new_method);
            this.tab_new_method.Location = new System.Drawing.Point(4, 24);
            this.tab_new_method.Name = "tab_new_method";
            this.tab_new_method.Padding = new System.Windows.Forms.Padding(3);
            this.tab_new_method.Size = new System.Drawing.Size(1292, 735);
            this.tab_new_method.TabIndex = 1;
            this.tab_new_method.Text = "New method";
            this.tab_new_method.UseVisualStyleBackColor = true;
            // 
            // ctrl_line2_apply_btn
            // 
            this.ctrl_line2_apply_btn.Location = new System.Drawing.Point(1132, 47);
            this.ctrl_line2_apply_btn.Name = "ctrl_line2_apply_btn";
            this.ctrl_line2_apply_btn.Size = new System.Drawing.Size(75, 23);
            this.ctrl_line2_apply_btn.TabIndex = 10;
            this.ctrl_line2_apply_btn.Text = "Apply";
            this.ctrl_line2_apply_btn.UseVisualStyleBackColor = true;
            this.ctrl_line2_apply_btn.Click += new System.EventHandler(this.ctrl_line2_apply_btn_Click);
            // 
            // ctrl_line1_apply_btn
            // 
            this.ctrl_line1_apply_btn.Location = new System.Drawing.Point(241, 47);
            this.ctrl_line1_apply_btn.Name = "ctrl_line1_apply_btn";
            this.ctrl_line1_apply_btn.Size = new System.Drawing.Size(75, 23);
            this.ctrl_line1_apply_btn.TabIndex = 9;
            this.ctrl_line1_apply_btn.Text = "Apply";
            this.ctrl_line1_apply_btn.UseVisualStyleBackColor = true;
            this.ctrl_line1_apply_btn.Click += new System.EventHandler(this.ctrl_line1_apply_btn_Click);
            // 
            // control_line2_textbox
            // 
            this.control_line2_textbox.Location = new System.Drawing.Point(1077, 47);
            this.control_line2_textbox.Name = "control_line2_textbox";
            this.control_line2_textbox.Size = new System.Drawing.Size(49, 23);
            this.control_line2_textbox.TabIndex = 8;
            this.control_line2_textbox.Text = "100";
            // 
            // control_line1_textbox
            // 
            this.control_line1_textbox.Location = new System.Drawing.Point(184, 47);
            this.control_line1_textbox.Name = "control_line1_textbox";
            this.control_line1_textbox.Size = new System.Drawing.Size(49, 23);
            this.control_line1_textbox.TabIndex = 7;
            this.control_line1_textbox.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(990, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Control Line 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Control Line 1:";
            // 
            // distance_label_new
            // 
            this.distance_label_new.AutoSize = true;
            this.distance_label_new.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.distance_label_new.ForeColor = System.Drawing.Color.Red;
            this.distance_label_new.Location = new System.Drawing.Point(689, 9);
            this.distance_label_new.Name = "distance_label_new";
            this.distance_label_new.Size = new System.Drawing.Size(51, 25);
            this.distance_label_new.TabIndex = 4;
            this.distance_label_new.Text = "0 px";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(500, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Distance (pixels): ";
            // 
            // pic_box_new_method
            // 
            this.pic_box_new_method.Location = new System.Drawing.Point(28, 73);
            this.pic_box_new_method.Name = "pic_box_new_method";
            this.pic_box_new_method.Size = new System.Drawing.Size(1225, 613);
            this.pic_box_new_method.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_box_new_method.TabIndex = 0;
            this.pic_box_new_method.TabStop = false;
            this.pic_box_new_method.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_box_new_method_Paint);
            this.pic_box_new_method.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_box_new_method_MouseDown);
            this.pic_box_new_method.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_box_new_method_MouseMove);
            this.pic_box_new_method.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_box_new_method_MouseUp);
            // 
            // previous_image_btn
            // 
            this.previous_image_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.previous_image_btn.Location = new System.Drawing.Point(351, 36);
            this.previous_image_btn.Name = "previous_image_btn";
            this.previous_image_btn.Size = new System.Drawing.Size(99, 38);
            this.previous_image_btn.TabIndex = 3;
            this.previous_image_btn.Text = "Previous image";
            this.previous_image_btn.UseVisualStyleBackColor = true;
            this.previous_image_btn.Click += new System.EventHandler(this.previous_image_btn_Click);
            // 
            // next_image_btn
            // 
            this.next_image_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.next_image_btn.Location = new System.Drawing.Point(795, 36);
            this.next_image_btn.Name = "next_image_btn";
            this.next_image_btn.Size = new System.Drawing.Size(99, 38);
            this.next_image_btn.TabIndex = 4;
            this.next_image_btn.Text = "Next image";
            this.next_image_btn.UseVisualStyleBackColor = true;
            this.next_image_btn.Click += new System.EventHandler(this.next_image_btn_Click);
            // 
            // image_count_label
            // 
            this.image_count_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.image_count_label.AutoSize = true;
            this.image_count_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.image_count_label.Location = new System.Drawing.Point(555, 57);
            this.image_count_label.Name = "image_count_label";
            this.image_count_label.Size = new System.Drawing.Size(144, 20);
            this.image_count_label.TabIndex = 3;
            this.image_count_label.Text = "Number of images:";
            // 
            // image_name_label
            // 
            this.image_name_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.image_name_label.AutoSize = true;
            this.image_name_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.image_name_label.Location = new System.Drawing.Point(458, 13);
            this.image_name_label.Name = "image_name_label";
            this.image_name_label.Size = new System.Drawing.Size(100, 20);
            this.image_name_label.TabIndex = 5;
            this.image_name_label.Text = "Image name:";
            // 
            // save_measure_csv
            // 
            this.save_measure_csv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.save_measure_csv.Location = new System.Drawing.Point(1219, 36);
            this.save_measure_csv.Name = "save_measure_csv";
            this.save_measure_csv.Size = new System.Drawing.Size(99, 38);
            this.save_measure_csv.TabIndex = 7;
            this.save_measure_csv.Text = "Export results (Image, CSV)";
            this.save_measure_csv.UseVisualStyleBackColor = true;
            this.save_measure_csv.Click += new System.EventHandler(this.save_measure_csv_Click);
            // 
            // oper_folder_btn
            // 
            this.oper_folder_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.oper_folder_btn.Location = new System.Drawing.Point(1114, 36);
            this.oper_folder_btn.Name = "oper_folder_btn";
            this.oper_folder_btn.Size = new System.Drawing.Size(99, 38);
            this.oper_folder_btn.TabIndex = 8;
            this.oper_folder_btn.Text = "Open results folder";
            this.oper_folder_btn.UseVisualStyleBackColor = true;
            this.oper_folder_btn.Click += new System.EventHandler(this.oper_folder_btn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1366, 768);
            this.ClientSize = new System.Drawing.Size(1367, 885);
            this.Controls.Add(this.oper_folder_btn);
            this.Controls.Add(this.save_measure_csv);
            this.Controls.Add(this.image_name_label);
            this.Controls.Add(this.image_count_label);
            this.Controls.Add(this.next_image_btn);
            this.Controls.Add(this.previous_image_btn);
            this.Controls.Add(this.tab_methods);
            this.Controls.Add(this.btn_open_folder);
            this.Controls.Add(this.btn_single_image);
            this.Name = "MainWindow";
            this.Text = "Ultrasonic Ruler";
            this.tab_methods.ResumeLayout(false);
            this.tab_old_method.ResumeLayout(false);
            this.tab_old_method.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_old_method)).EndInit();
            this.tab_new_method.ResumeLayout(false);
            this.tab_new_method.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_new_method)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_single_image;
        private System.Windows.Forms.Button btn_open_folder;
        private System.Windows.Forms.TabControl tab_methods;
        private System.Windows.Forms.TabPage tab_new_method;
        private System.Windows.Forms.TabPage tab_old_method;
        private System.Windows.Forms.PictureBox pic_box_old_method;
        private System.Windows.Forms.PictureBox pic_box_new_method;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label distance_label_new;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button previous_image_btn;
        private System.Windows.Forms.Button next_image_btn;
        private System.Windows.Forms.Label image_count_label;
        private System.Windows.Forms.Label image_name_label;
        private System.Windows.Forms.Button save_measure_csv;
        private System.Windows.Forms.Button ctrl_line2_apply_btn;
        private System.Windows.Forms.Button ctrl_line1_apply_btn;
        private System.Windows.Forms.TextBox control_line2_textbox;
        private System.Windows.Forms.TextBox control_line1_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button oper_folder_btn;
    }
}

