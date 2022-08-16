using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
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

        VideoCaptureDevice webCam;
        public Form1()
        {
            InitializeComponent();
            
            FilterInfoCollection filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            webCam = new VideoCaptureDevice(filterInfo[Properties.Settings.Default.webcamIndex].MonikerString);

            foreach (var item in webCam.VideoCapabilities)
            {
                ResolutionComboBox.Items.Add(item.FrameSize);
            }

            webCam = null;

            foreach (FilterInfo webCam in filterInfo)
            {
                SelectWebCamComboBox.Items.Add(webCam.Name);
            }

            SelectWebCamComboBox.SelectedIndex = Properties.Settings.Default.webcamIndex;
            videoDownScaleTextBox.Text = Properties.Settings.Default.videoScale.ToString();
            PictureDownScaleTextBox.Text = Properties.Settings.Default.pictureScale.ToString();
            ResolutionComboBox.SelectedIndex = Properties.Settings.Default.webCamResolutionIndex;
        }

        private void WebcamButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void PictureButton_Click(object sender, EventArgs e)
        {
            string charPath = Environment.CurrentDirectory + "\\Data\\ASCII.txt";
            string txtPath = Environment.CurrentDirectory + "\\Data\\text.txt";

            OpenFileDialog dialog = new OpenFileDialog();

            string filePath = "";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }

            int scale = Properties.Settings.Default.pictureScale;
            Bitmap resizedPic = TaskUtils.resizedPicture(new Bitmap(filePath), scale);

            //b.Save(@"C:\Users\Gaming\Desktop\image.jpeg", ImageFormat.Jpeg);

            List<double> values = TaskUtils.GetGrayScaleList(resizedPic);
            string charLine = Files.GetCharLine(charPath);

            Files.WriteToTXT(values, charLine, txtPath, resizedPic);
            Process.Start(txtPath);//opens txt file to view.
        }

        private void ResolutionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.webCamResolutionIndex = ResolutionComboBox.SelectedIndex;
        }

        private void videoDownScaleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.videoScale = Convert.ToInt32(videoDownScaleTextBox.Text);
                Properties.Settings.Default.Save();

            }
            catch
            {
                videoDownScaleTextBox.ForeColor = Color.Red;
                videoDownScaleTextBox.Text = "Wrong input";
            }
        }

        private void PictureDownScaleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PictureDownScaleTextBox.ForeColor = Color.Black;
                Properties.Settings.Default.pictureScale = Convert.ToInt32(PictureDownScaleTextBox.Text);
                Properties.Settings.Default.Save();

            }
            catch
            {
                PictureDownScaleTextBox.ForeColor = Color.Red;
                PictureDownScaleTextBox.Text = "Wrong input";
            }
        }

        private void SelectWebCamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.webcamIndex = SelectWebCamComboBox.SelectedIndex;
            Properties.Settings.Default.Save();
        }
    }
}
