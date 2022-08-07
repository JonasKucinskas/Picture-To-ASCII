using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<double> values;
        string charLine = Files.GetCharLine(Environment.CurrentDirectory + "\\Data\\ASCII.txt");
        Bitmap image;

        private void button2_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "\\Pictures";
            string charPath = Environment.CurrentDirectory + "\\Data\\ASCII.txt";
            string txtPath = Environment.CurrentDirectory + "\\Data\\text.txt";

            OpenFileDialog dialog = new OpenFileDialog();

            string filePath = "";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }

            image = new Bitmap(filePath);
            values = TaskUtils.GetGrayScaleList(image);
            

            Files.WriteToTXT(values, charLine, txtPath, image);
            Process.Start(txtPath);//opens txt file to view.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilterInfoCollection filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            VideoCaptureDevice webCam = new VideoCaptureDevice(filterInfo[0].MonikerString);
            webCam.NewFrame += WebCam_NewFrame;
            webCam.Start();

            //Process.Start(Environment.CurrentDirectory + "\\Data\\LiveText.txt");
        }

        FileInfo file = new FileInfo(Environment.CurrentDirectory + "\\Data\\LiveText.txt");
        private void WebCam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            image = new Bitmap(eventArgs.Frame);
            values = TaskUtils.GetGrayScaleList(image);
            charLine = Files.GetCharLine(Environment.CurrentDirectory + "\\Data\\ASCII.txt");

            Files.WriteToTXT(values, charLine, Environment.CurrentDirectory + "\\Data\\LiveText.txt", image);
            file.Refresh();
        }
    }
}
