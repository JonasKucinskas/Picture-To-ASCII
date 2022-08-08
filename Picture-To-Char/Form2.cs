using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            Bitmap image = new Bitmap(eventArgs.Frame);
            List<double> values = TaskUtils.GetGrayScaleList(image);
            string charLine = Files.GetCharLine(Environment.CurrentDirectory + "\\Data\\ASCII.txt");

            Files.WriteToTXT(values, charLine, Environment.CurrentDirectory + "\\Data\\LiveText.txt", image);
            //ReadFromFile(Environment.CurrentDirectory + "\\Data\\LiveText.txt");
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (webCam.IsRunning)
            {
                webCam.Stop();
            }
        }

        public static void ReadFromFile(string path)
        {
            Form2 form = new Form2();

            using (StreamReader read = new StreamReader(path))
            {
                string line;
                while (read.ReadLine() != null)
                {
                    line = read.ReadLine();

                    form.richTextBox1.AppendText(line);
                }
            }
        }
    }
}
