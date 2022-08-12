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
        public Form1()
        {
            InitializeComponent();
        }

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

            int scale = Properties.Settings.Default.pictureScale;

            Bitmap picture = new Bitmap(filePath);
            Bitmap resizedPic = TaskUtils.resizedPicture(picture, scale);

            //b.Save(@"C:\Users\Gaming\Desktop\image.jpeg", ImageFormat.Jpeg);

            List<double> values = TaskUtils.GetGrayScaleList(resizedPic);
            string charLine = Files.GetCharLine(charPath);

            Files.WriteToTXT(values, charLine, txtPath, resizedPic, false);
            Process.Start(txtPath);//opens txt file to view.
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            //Process.Start(Environment.CurrentDirectory + "\\Data\\LiveText.txt");
        }

        private void SettingsWebcamDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.webcamIndex = SettingsWebcamDropDown.SelectedIndex;
        }

        private void settingsToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            //Set webCam selection ui.
            FilterInfoCollection filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo webCam in filterInfoCollection)
            {
                if (!SettingsWebcamDropDown.Items.Contains(webCam.Name))
                    SettingsWebcamDropDown.Items.Add(webCam.Name);
                SettingsWebcamDropDown.SelectedIndex = Properties.Settings.Default.webcamIndex;

            }
            //

            videoScaleSelectorTextBox.Text = Properties.Settings.Default.videoScale.ToString();
            pictureScale_TextBox.Text = Properties.Settings.Default.pictureScale.ToString();

        }

        private void webcamScaleSelected_keydown(object sender, KeyEventArgs e)
        {
            videoScaleSelectorTextBox.ForeColor = Color.Black;

            if (e.KeyCode == Keys.Enter)
            {
                if (Convert.ToInt32(videoScaleSelectorTextBox.Text) >= 1)
                {
                    Properties.Settings.Default.videoScale = Convert.ToInt32(videoScaleSelectorTextBox.Text);
                }
                else
                {
                    videoScaleSelectorTextBox.ForeColor = Color.Red;
                    videoScaleSelectorTextBox.Text = "Wrong input";
                }
            }
        }

        private void pictureScale_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            pictureScale_TextBox.ForeColor = Color.Black;

            if (e.KeyCode == Keys.Enter)
            {
                if (Convert.ToInt32(videoScaleSelectorTextBox.Text) >= 1)
                {
                    Properties.Settings.Default.pictureScale = Convert.ToInt32(pictureScale_TextBox.Text);
                }
                else
                {
                    pictureScale_TextBox.ForeColor = Color.Red;
                    pictureScale_TextBox.Text = "Wrong input";
                }
            }
        }
    }
}
