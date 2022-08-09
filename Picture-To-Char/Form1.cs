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
            int scale = 3;

            Bitmap image = new Bitmap(filePath);
            


            Bitmap b = new Bitmap(image.Width / scale, image.Height / scale);
            Graphics g = Graphics.FromImage(b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height  
            g.DrawImage(image, 0, 0, image.Width / scale, image.Height / scale);
            g.Dispose();

            //b.Save(@"C:\Users\Gaming\Desktop\image.jpeg", ImageFormat.Jpeg);
            

            List<double> values = TaskUtils.GetGrayScaleList(b);
            string charLine = Files.GetCharLine(charPath);

            Files.WriteToTXT(values, charLine, txtPath, b);
            Process.Start(txtPath);//opens txt file to view.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();




            //Process.Start(Environment.CurrentDirectory + "\\Data\\LiveText.txt");
        }
    }
}
