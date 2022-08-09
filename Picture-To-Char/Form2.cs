using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Picture_To_Char
{
    public partial class Form2 : Form
    {
        VideoCaptureDevice webCam;
        public Form2()
        {
            InitializeComponent();

            FilterInfoCollection filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            webCam = new VideoCaptureDevice(filterInfo[0].MonikerString);
            webCam.Start();
            webCam.NewFrame += WebCam_NewFrame1;
        }

        private void WebCam_NewFrame1(object sender, NewFrameEventArgs eventArgs)
        {
            int scale = 1;

            Bitmap image;

            if (scale == 1)
            {
                image = new Bitmap(eventArgs.Frame);
            }
            else
            {
                image = new Bitmap(eventArgs.Frame.Width / scale, eventArgs.Frame.Height / scale);
                Graphics g = Graphics.FromImage(image);
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                // Draw image with new width and height  
                g.DrawImage(image, 0, 0, image.Width / scale, image.Height / scale);
                g.Dispose();
            }
            


            List<double> values = TaskUtils.GetGrayScaleList(image);
            string charLine = Files.GetCharLine(Environment.CurrentDirectory + "\\Data\\ASCII.txt");

            Files.WriteToTXT(values, charLine, Environment.CurrentDirectory + "\\Data\\LiveText.txt", image);
            richTextBox1.ZoomFactor = 0.1f;

            ReadFromFile(richTextBox1, Environment.CurrentDirectory + "\\Data\\LiveText.txt");
            richTextBox1.Clear();

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (webCam.IsRunning)
            {
                webCam.Stop();
            }
        }

        public static void ReadFromFile(RichTextBox textBox, string path)
        {
            using (StreamReader read = new StreamReader(path))
            {
                string line;
                textBox.Multiline = true;
                while (read.ReadLine() != null)
                {
                    line = read.ReadLine();

                    textBox.AppendText(line);
                    textBox.AppendText("\n");
                }
            }
            textBox.Update();

        }
    }
}
