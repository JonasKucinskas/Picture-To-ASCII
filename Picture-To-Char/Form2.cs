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
                webCam.VideoResolution = webCam.VideoCapabilities[Properties.Settings.Default.webCamResolutionIndex];
                //new VideoCaptureDevice(infoCollection[Properties.Settings.Default.webcamIndex].MonikerString);
                webCam.Start();
                //webCam.VideoResolution = webCam.VideoCapabilities[5];
                webCam.NewFrame += WebCam_NewFrame1;
            }
            catch
            {
                MessageBox.Show("No WebCam detected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string charLine = Files.GetCharLine(Environment.CurrentDirectory + "\\Data\\ASCII.txt");
        private void WebCam_NewFrame1(object sender, NewFrameEventArgs eventArgs)
        {

            Bitmap image;
            if (videoScale > 1)
            {
                image = TaskUtils.resizedPicture(eventArgs.Frame, videoScale);
            }
            else image = eventArgs.Frame;



            List<double> values = TaskUtils.GetGrayScaleList(image);
            //Files.WriteToTXT(values, charLine, Environment.CurrentDirectory + "\\Data\\LiveText.txt", image);

            Files.SetFrame(richTextBox1, values, charLine, image);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (webCam != null)
            {
                if (webCam.IsRunning)//Close webcam object
                {
                    webCam.SignalToStop();
                    webCam = null;
                }
            }

        }
    }
}
