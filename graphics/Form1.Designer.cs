namespace graphics
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.elipse = new System.Windows.Forms.RadioButton();
            this.Circle = new System.Windows.Forms.RadioButton();
            this.Bresenham = new System.Windows.Forms.RadioButton();
            this.DDA = new System.Windows.Forms.RadioButton();
            this.R2Box = new System.Windows.Forms.TextBox();
            this.R1Box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.y2Box = new System.Windows.Forms.TextBox();
            this.y1Box = new System.Windows.Forms.TextBox();
            this.x2Box = new System.Windows.Forms.TextBox();
            this.x1Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.scale_y = new System.Windows.Forms.TextBox();
            this.scale_x = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.angle = new System.Windows.Forms.TextBox();
            this.textBox_Bersinham_trans_y = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Bersinham_trans_x = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Clipping = new System.Windows.Forms.RadioButton();
            this.ScalBox = new System.Windows.Forms.RadioButton();
            this.RotaBox = new System.Windows.Forms.RadioButton();
            this.TransBox = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.elipse);
            this.groupBox1.Controls.Add(this.Circle);
            this.groupBox1.Controls.Add(this.Bresenham);
            this.groupBox1.Controls.Add(this.DDA);
            this.groupBox1.Controls.Add(this.R2Box);
            this.groupBox1.Controls.Add(this.R1Box);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.y2Box);
            this.groupBox1.Controls.Add(this.y1Box);
            this.groupBox1.Controls.Add(this.x2Box);
            this.groupBox1.Controls.Add(this.x1Box);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(437, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // elipse
            // 
            this.elipse.AutoSize = true;
            this.elipse.Location = new System.Drawing.Point(380, 24);
            this.elipse.Name = "elipse";
            this.elipse.Size = new System.Drawing.Size(61, 21);
            this.elipse.TabIndex = 16;
            this.elipse.TabStop = true;
            this.elipse.Text = "elipse";
            this.elipse.UseVisualStyleBackColor = true;
            this.elipse.CheckedChanged += new System.EventHandler(this.elipse_CheckedChanged);
            // 
            // Circle
            // 
            this.Circle.AutoSize = true;
            this.Circle.Location = new System.Drawing.Point(281, 24);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(61, 21);
            this.Circle.TabIndex = 15;
            this.Circle.TabStop = true;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.CheckedChanged += new System.EventHandler(this.Circle_CheckedChanged);
            // 
            // Bresenham
            // 
            this.Bresenham.AutoSize = true;
            this.Bresenham.Location = new System.Drawing.Point(163, 24);
            this.Bresenham.Name = "Bresenham";
            this.Bresenham.Size = new System.Drawing.Size(97, 21);
            this.Bresenham.TabIndex = 14;
            this.Bresenham.TabStop = true;
            this.Bresenham.Text = "Bresenham";
            this.Bresenham.UseVisualStyleBackColor = true;
            this.Bresenham.CheckedChanged += new System.EventHandler(this.Bresenham_CheckedChanged);
            // 
            // DDA
            // 
            this.DDA.AutoSize = true;
            this.DDA.Location = new System.Drawing.Point(56, 24);
            this.DDA.Name = "DDA";
            this.DDA.Size = new System.Drawing.Size(57, 21);
            this.DDA.TabIndex = 13;
            this.DDA.TabStop = true;
            this.DDA.Text = "DDA";
            this.DDA.UseVisualStyleBackColor = true;
            this.DDA.CheckedChanged += new System.EventHandler(this.DDA_CheckedChanged);
            // 
            // R2Box
            // 
            this.R2Box.Location = new System.Drawing.Point(482, 118);
            this.R2Box.Name = "R2Box";
            this.R2Box.Size = new System.Drawing.Size(116, 24);
            this.R2Box.TabIndex = 12;
            // 
            // R1Box
            // 
            this.R1Box.Location = new System.Drawing.Point(482, 75);
            this.R1Box.Name = "R1Box";
            this.R1Box.Size = new System.Drawing.Size(116, 24);
            this.R1Box.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(439, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "R2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "R1";
            // 
            // y2Box
            // 
            this.y2Box.Location = new System.Drawing.Point(238, 112);
            this.y2Box.Name = "y2Box";
            this.y2Box.Size = new System.Drawing.Size(100, 24);
            this.y2Box.TabIndex = 7;
            // 
            // y1Box
            // 
            this.y1Box.Location = new System.Drawing.Point(76, 112);
            this.y1Box.Name = "y1Box";
            this.y1Box.Size = new System.Drawing.Size(100, 24);
            this.y1Box.TabIndex = 6;
            // 
            // x2Box
            // 
            this.x2Box.Location = new System.Drawing.Point(238, 75);
            this.x2Box.Name = "x2Box";
            this.x2Box.Size = new System.Drawing.Size(100, 24);
            this.x2Box.TabIndex = 5;
            // 
            // x1Box
            // 
            this.x1Box.BackColor = System.Drawing.SystemColors.Window;
            this.x1Box.Location = new System.Drawing.Point(76, 75);
            this.x1Box.Name = "x1Box";
            this.x1Box.Size = new System.Drawing.Size(100, 24);
            this.x1Box.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "X2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "X1";
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Location = new System.Drawing.Point(12, 211);
            this.pic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(636, 506);
            this.pic.TabIndex = 11;
            this.pic.TabStop = false;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv.Location = new System.Drawing.Point(654, 211);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 26;
            this.dgv.Size = new System.Drawing.Size(698, 499);
            this.dgv.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.scale_y);
            this.groupBox2.Controls.Add(this.scale_x);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.angle);
            this.groupBox2.Controls.Add(this.textBox_Bersinham_trans_y);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_Bersinham_trans_x);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.Clipping);
            this.groupBox2.Controls.Add(this.ScalBox);
            this.groupBox2.Controls.Add(this.RotaBox);
            this.groupBox2.Controls.Add(this.TransBox);
            this.groupBox2.Location = new System.Drawing.Point(654, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(698, 193);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(526, 127);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(156, 25);
            this.button8.TabIndex = 25;
            this.button8.Text = "Set Polygn";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(526, 98);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(156, 23);
            this.button7.TabIndex = 24;
            this.button7.Text = "Scan Line";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(526, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Boundary";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(526, 69);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(156, 23);
            this.button6.TabIndex = 23;
            this.button6.Text = "Flood";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(526, 11);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "Picture Draw";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(200, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Sy Scalling";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Sx Scalling";
            // 
            // scale_y
            // 
            this.scale_y.Location = new System.Drawing.Point(274, 119);
            this.scale_y.Name = "scale_y";
            this.scale_y.Size = new System.Drawing.Size(91, 24);
            this.scale_y.TabIndex = 19;
            // 
            // scale_x
            // 
            this.scale_x.Location = new System.Drawing.Point(274, 75);
            this.scale_x.Name = "scale_x";
            this.scale_x.Size = new System.Drawing.Size(91, 24);
            this.scale_x.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(404, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Angle";
            // 
            // angle
            // 
            this.angle.Location = new System.Drawing.Point(386, 118);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(80, 24);
            this.angle.TabIndex = 16;
            // 
            // textBox_Bersinham_trans_y
            // 
            this.textBox_Bersinham_trans_y.Location = new System.Drawing.Point(66, 119);
            this.textBox_Bersinham_trans_y.Name = "textBox_Bersinham_trans_y";
            this.textBox_Bersinham_trans_y.Size = new System.Drawing.Size(91, 24);
            this.textBox_Bersinham_trans_y.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "X";
            // 
            // textBox_Bersinham_trans_x
            // 
            this.textBox_Bersinham_trans_x.Location = new System.Drawing.Point(66, 76);
            this.textBox_Bersinham_trans_x.Name = "textBox_Bersinham_trans_x";
            this.textBox_Bersinham_trans_x.Size = new System.Drawing.Size(91, 24);
            this.textBox_Bersinham_trans_x.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(542, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Excute";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Clipping
            // 
            this.Clipping.AutoSize = true;
            this.Clipping.Location = new System.Drawing.Point(358, 24);
            this.Clipping.Name = "Clipping";
            this.Clipping.Size = new System.Drawing.Size(76, 21);
            this.Clipping.TabIndex = 3;
            this.Clipping.TabStop = true;
            this.Clipping.Text = "Clipping";
            this.Clipping.UseVisualStyleBackColor = true;
            this.Clipping.CheckedChanged += new System.EventHandler(this.Clipping_CheckedChanged);
            // 
            // ScalBox
            // 
            this.ScalBox.AutoSize = true;
            this.ScalBox.Location = new System.Drawing.Point(261, 24);
            this.ScalBox.Name = "ScalBox";
            this.ScalBox.Size = new System.Drawing.Size(73, 21);
            this.ScalBox.TabIndex = 2;
            this.ScalBox.TabStop = true;
            this.ScalBox.Text = "Scalling";
            this.ScalBox.UseVisualStyleBackColor = true;
            // 
            // RotaBox
            // 
            this.RotaBox.AutoSize = true;
            this.RotaBox.Location = new System.Drawing.Point(154, 23);
            this.RotaBox.Name = "RotaBox";
            this.RotaBox.Size = new System.Drawing.Size(81, 21);
            this.RotaBox.TabIndex = 1;
            this.RotaBox.TabStop = true;
            this.RotaBox.Text = "Rotation";
            this.RotaBox.UseVisualStyleBackColor = true;
            // 
            // TransBox
            // 
            this.TransBox.AutoSize = true;
            this.TransBox.Location = new System.Drawing.Point(29, 23);
            this.TransBox.Name = "TransBox";
            this.TransBox.Size = new System.Drawing.Size(95, 21);
            this.TransBox.TabIndex = 0;
            this.TransBox.TabStop = true;
            this.TransBox.Text = "Translation";
            this.TransBox.UseVisualStyleBackColor = true;
            this.TransBox.CheckedChanged += new System.EventHandler(this.TransBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1357, 716);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Bresenham;
        private System.Windows.Forms.RadioButton DDA;
        private System.Windows.Forms.TextBox R2Box;
        private System.Windows.Forms.TextBox R1Box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox y2Box;
        private System.Windows.Forms.TextBox y1Box;
        private System.Windows.Forms.TextBox x2Box;
        private System.Windows.Forms.TextBox x1Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.RadioButton elipse;
        private System.Windows.Forms.RadioButton Circle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Clipping;
        private System.Windows.Forms.RadioButton ScalBox;
        private System.Windows.Forms.RadioButton RotaBox;
        private System.Windows.Forms.RadioButton TransBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox angle;
        private System.Windows.Forms.TextBox textBox_Bersinham_trans_y;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Bersinham_trans_x;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox scale_y;
        private System.Windows.Forms.TextBox scale_x;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
    }
}

