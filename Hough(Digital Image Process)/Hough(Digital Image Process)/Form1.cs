using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace Hough_Digital_Image_Process_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Image<Bgr, Byte> Source;        //Source image
        Image<Bgr, Byte> Edge_detection;//edge image
        Image<Bgr, Byte> Hough;         //Hough line image
        Image<Bgr, Byte> Undo;

        private void button_open_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Users\\Canaan\\Documents\\GitHub\\embeding\\Hough(Digital Image Process)\\Hough(Digital Image Process)";
            openFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|All valid files (*.bmp/*.jpg)|*.bmp/*.jpg";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.groupBox1.Visible = true;
                this.button_Horizontal.Visible = true;
                this.button_Vertical.Visible = true;
                this.button_Difference.Visible = true;
                this.button_EdgeEnhance.Visible = true;
                this.button_Prewitt.Visible = true;
                this.button_Sobel.Visible = true;
                this.button_Save.Visible = true;
                //this.AutoScroll = true;
                this.label1.Visible = true;
                //MessageBox.Show(this.openFileDialog1.FileName);
                Source = new Image<Bgr, Byte>(this.openFileDialog1.FileName);
                //this.AutoScrollMinSize = new Size((int)(Source.Width), (int)(Source.Height));
                for (int i = this.Size.Width; i <= 423; i+=6)
                {
                    this.Size = new Size(i, 476);                    
                }

                this.imageBox1.Image = Source;
            }    
        }

        private void button_Horizontal_Click(object sender, EventArgs e)
        {
                Undo = Source.Clone();
                Edge_detection = new Image<Bgr, byte>(Tilt_Correction_Process.EdgeDetectHorizontal(Source.ToBitmap()));
                this.imageBox2.Image = Edge_detection;
                this.label2.Visible = true;
                this.button_Hough.Visible = true;
                for (int i = this.Size.Width; i <= 751; i+=6)
                {
                    this.Size = new Size(i, 476);
                }
                
        }

        private void button_Vertical_Click(object sender, EventArgs e)
        {
            Undo = Source.Clone();
            Edge_detection = new Image<Bgr, byte>(Tilt_Correction_Process.EdgeDetectVertical(Source.ToBitmap()));
            this.imageBox2.Image = Edge_detection;
            this.label2.Visible = true;
            this.button_Hough.Visible = true;
            for (int i = this.Size.Width; i <= 751; i += 6)
            {
                this.Size = new Size(i, 476);
            }
        }

        private void button_Difference_Click(object sender, EventArgs e)
        {
            ValueSetting set = new ValueSetting();
            set.nValue = 0;

            if (set.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Undo = Source.Clone();
                Edge_detection = new Image<Bgr, byte>(Tilt_Correction_Process.EdgeDetectDifference(Source.ToBitmap(), (byte)set.nValue));
                this.imageBox2.Image = Edge_detection;
                this.label2.Visible = true;
                this.button_Hough.Visible = true;
                for (int i = this.Size.Width; i <= 751; i += 6)
                {
                    this.Size = new Size(i, 476);
                }
            }
        }

        private void button_EdgeEnhance_Click(object sender, EventArgs e)
        {
            ValueSetting set = new ValueSetting();
            set.nValue = 0;

            if (set.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Undo = Source.Clone();
                Edge_detection = new Image<Bgr, byte>(Tilt_Correction_Process.EdgeEnhance(Source.ToBitmap(), (byte)set.nValue));
                this.imageBox2.Image = Edge_detection;
                this.label2.Visible = true;
                this.button_Hough.Visible = true;
                for (int i = this.Size.Width; i <= 751; i += 6)
                {
                    this.Size = new Size(i, 476);
                }
            }
        }

        private void button_Sobel_Click(object sender, EventArgs e)
        {
            ValueSetting set = new ValueSetting();
            set.nValue = 0;

            if (set.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Undo = Source.Clone();
                Edge_detection = new Image<Bgr, byte>(
                    Tilt_Correction_Process.EdgeDetectConvolution(
                    Source.ToBitmap(), 
                    Tilt_Correction_Process.EDGE_DETECT_SOBEL, 
                    (byte)set.nValue
                    )
                    );
                this.imageBox2.Image = Edge_detection;
                this.label2.Visible = true;
                this.button_Hough.Visible = true;
                for (int i = this.Size.Width; i <= 751; i += 6)
                {
                    this.Size = new Size(i, 476);
                }
            }
        }

        private void button_Prewitt_Click(object sender, EventArgs e)
        {
            ValueSetting set = new ValueSetting();
            set.nValue = 0;

            if (set.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Undo = Source.Clone();
                Edge_detection = new Image<Bgr, byte>(
                    Tilt_Correction_Process.EdgeDetectConvolution(
                    Source.ToBitmap(), 
                    Tilt_Correction_Process.EDGE_DETECT_PREWITT, 
                    (byte)set.nValue
                    )
                    );
                this.imageBox2.Image = Edge_detection;
                this.label2.Visible = true;
                this.button_Hough.Visible = true;
                for (int i = this.Size.Width; i <= 751; i += 6)
                {
                    this.Size = new Size(i, 476);
                }
            }
        }

        private void button_Hough_Click(object sender, EventArgs e)
        {
            Undo = Source.Clone();
            //Hough = new Image<Bgr, byte>(Tilt_Correction_Process.hough_line(this.imageBox2.Image.Bitmap, 10));
            double Angle = Tilt_Correction_Process.hough_line(this.imageBox2.Image.Bitmap, 10);
            MessageBox.Show(Angle.ToString());
            Hough = new Image<Bgr, byte>(Tilt_Correction_Process.BitmapRotate(Source.ToBitmap(), -(float)Angle, Color.Black));
            //TextureBrush myBrush = new TextureBrush(this.Source.ToBitmap());
            //myBrush.RotateTransform(Angle);
            //g.FillRectangle(myBrush, 0, 0, this.imageBox1.Width, this.imageBox1.Height);
            this.imageBox3.Image = Hough;
            this.label3.Visible = true;
            for (int i = this.Size.Width; i <= 1050; i += 6)
            {
                this.Size = new Size(i, 476);
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {

        }

    }
}
