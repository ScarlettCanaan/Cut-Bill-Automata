namespace Hough_Digital_Image_Process_
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
            this.components = new System.ComponentModel.Container();
            this.button_open = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Horizontal = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Vertical = new System.Windows.Forms.Button();
            this.button_Difference = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Prewitt = new System.Windows.Forms.Button();
            this.button_Sobel = new System.Windows.Forms.Button();
            this.button_EdgeEnhance = new System.Windows.Forms.Button();
            this.imageBox3 = new Emgu.CV.UI.ImageBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Hough = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(19, 13);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(75, 28);
            this.button_open.TabIndex = 0;
            this.button_open.Text = "打开图像";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(204, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "原始图像";
            this.label1.Visible = false;
            // 
            // button_Horizontal
            // 
            this.button_Horizontal.Location = new System.Drawing.Point(6, 20);
            this.button_Horizontal.Name = "button_Horizontal";
            this.button_Horizontal.Size = new System.Drawing.Size(75, 24);
            this.button_Horizontal.TabIndex = 3;
            this.button_Horizontal.Text = "Horizontal";
            this.button_Horizontal.UseVisualStyleBackColor = true;
            this.button_Horizontal.Visible = false;
            this.button_Horizontal.Click += new System.EventHandler(this.button_Horizontal_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(111, 13);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(286, 391);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(403, 13);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(320, 391);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(534, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "边缘检测";
            this.label2.Visible = false;
            // 
            // button_Vertical
            // 
            this.button_Vertical.Location = new System.Drawing.Point(6, 50);
            this.button_Vertical.Name = "button_Vertical";
            this.button_Vertical.Size = new System.Drawing.Size(75, 23);
            this.button_Vertical.TabIndex = 5;
            this.button_Vertical.Text = "Vertical";
            this.button_Vertical.UseVisualStyleBackColor = true;
            this.button_Vertical.Visible = false;
            this.button_Vertical.Click += new System.EventHandler(this.button_Vertical_Click);
            // 
            // button_Difference
            // 
            this.button_Difference.Location = new System.Drawing.Point(6, 79);
            this.button_Difference.Name = "button_Difference";
            this.button_Difference.Size = new System.Drawing.Size(75, 23);
            this.button_Difference.TabIndex = 6;
            this.button_Difference.Text = "Difference";
            this.button_Difference.UseVisualStyleBackColor = true;
            this.button_Difference.Visible = false;
            this.button_Difference.Click += new System.EventHandler(this.button_Difference_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Prewitt);
            this.groupBox1.Controls.Add(this.button_Sobel);
            this.groupBox1.Controls.Add(this.button_EdgeEnhance);
            this.groupBox1.Controls.Add(this.button_Horizontal);
            this.groupBox1.Controls.Add(this.button_Difference);
            this.groupBox1.Controls.Add(this.button_Vertical);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(93, 201);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "边缘检测";
            this.groupBox1.Visible = false;
            // 
            // button_Prewitt
            // 
            this.button_Prewitt.Location = new System.Drawing.Point(7, 167);
            this.button_Prewitt.Name = "button_Prewitt";
            this.button_Prewitt.Size = new System.Drawing.Size(75, 23);
            this.button_Prewitt.TabIndex = 9;
            this.button_Prewitt.Text = "Prewitt";
            this.button_Prewitt.UseVisualStyleBackColor = true;
            this.button_Prewitt.Visible = false;
            this.button_Prewitt.Click += new System.EventHandler(this.button_Prewitt_Click);
            // 
            // button_Sobel
            // 
            this.button_Sobel.Location = new System.Drawing.Point(7, 138);
            this.button_Sobel.Name = "button_Sobel";
            this.button_Sobel.Size = new System.Drawing.Size(75, 23);
            this.button_Sobel.TabIndex = 8;
            this.button_Sobel.Text = "Sobel";
            this.button_Sobel.UseVisualStyleBackColor = true;
            this.button_Sobel.Visible = false;
            this.button_Sobel.Click += new System.EventHandler(this.button_Sobel_Click);
            // 
            // button_EdgeEnhance
            // 
            this.button_EdgeEnhance.Location = new System.Drawing.Point(7, 109);
            this.button_EdgeEnhance.Name = "button_EdgeEnhance";
            this.button_EdgeEnhance.Size = new System.Drawing.Size(75, 23);
            this.button_EdgeEnhance.TabIndex = 7;
            this.button_EdgeEnhance.Text = "EdgeEnhance";
            this.button_EdgeEnhance.UseVisualStyleBackColor = true;
            this.button_EdgeEnhance.Visible = false;
            this.button_EdgeEnhance.Click += new System.EventHandler(this.button_EdgeEnhance_Click);
            // 
            // imageBox3
            // 
            this.imageBox3.Location = new System.Drawing.Point(729, 13);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(300, 391);
            this.imageBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox3.TabIndex = 2;
            this.imageBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(838, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "倾斜校正";
            this.label3.Visible = false;
            // 
            // button_Hough
            // 
            this.button_Hough.Location = new System.Drawing.Point(19, 296);
            this.button_Hough.Name = "button_Hough";
            this.button_Hough.Size = new System.Drawing.Size(75, 32);
            this.button_Hough.TabIndex = 10;
            this.button_Hough.Text = "倾斜校正";
            this.button_Hough.UseVisualStyleBackColor = true;
            this.button_Hough.Visible = false;
            this.button_Hough.Click += new System.EventHandler(this.button_Hough_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(19, 344);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 32);
            this.button_Save.TabIndex = 11;
            this.button_Save.Text = "保存图像";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Visible = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(128, 55);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Hough);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imageBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_open);
            this.Name = "Form1";
            this.Text = "图像倾斜校正";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Horizontal;
        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Vertical;
        private System.Windows.Forms.Button button_Difference;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_EdgeEnhance;
        private Emgu.CV.UI.ImageBox imageBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Sobel;
        private System.Windows.Forms.Button button_Prewitt;
        private System.Windows.Forms.Button button_Hough;
        private System.Windows.Forms.Button button_Save;
    }
}

