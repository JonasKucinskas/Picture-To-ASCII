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
        int videoScale = Properties.Settings.Default.videoScale;

        public Form2()
        {
            InitializeComponent();

            FilterInfoCollection filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            try
            {
                webCam = new VideoCaptureDevice(filterInfo[Properties.Settings.Default.webcamIndex].MonikerString);
                webCam.Start();
                webCam.NewFrame += WebCam_NewFrame1;
            }
            catch
            {
                MessageBox.Show("No WebCam detected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void WebCam_NewFrame1(object sender, NewFrameEventArgs eventArgs)
        {


            Bitmap image = new Bitmap(eventArgs.Frame);
            Bitmap resizedPic = TaskUtils.resizedPicture(image, videoScale);

            List<double> values = TaskUtils.GetGrayScaleList(resizedPic);
            string charLine = Files.GetCharLine(Environment.CurrentDirectory + "\\Data\\ASCII.txt");

            Files.WriteToTXT(values, charLine, Environment.CurrentDirectory + "\\Data\\LiveText.txt", resizedPic, true);
            richTextBox1.ZoomFactor = 3.0f;

            Files.DisplayTextFromFile(richTextBox1, Environment.CurrentDirectory + "\\Data\\LiveText.txt");
            richTextBox1.Clear();

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (webCam.IsRunning)
            {
                webCam.Stop();
            }
        }
    }
}
