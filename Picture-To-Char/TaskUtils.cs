using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Image = System.Drawing.Image;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Xml.Linq;
using System.Xml;

namespace Picture_To_Char
{
    internal class TaskUtils
    {
        /// <summary>
        /// Gets list of all gray scale values of image.
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public static List<double> GetGrayScaleList(Bitmap image)
        {
            List<double> values = new List<double>();
            
            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    Color color = image.GetPixel(j, i);
                    double grayscale = (int)((0.299 * color.R) + (0.587 * color.G) + (0.114 * color.B));

                    if (!values.Contains(grayscale))
                    {
                        values.Add(grayscale);
                    }
                }
            }

            values.Sort();
            return values;
        }

        public static char GetChar(List<double> values, string charLine, Color color)
        {
            int grayscale = (int)((0.299 * color.R) + (0.587 * color.G) + (0.114 * color.B));//Fancy formula to convert colour to grayscale value.
            double charNum = (double)values.Count() / charLine.Length;//this is probably wrong, but it works for now.
            int numInList = values.IndexOf(grayscale);//
            char character = charLine[(int)(numInList / charNum)];//

            return character;
        }

        public static Bitmap resizedPicture(Bitmap image, int scale)
        {
            Bitmap b = new Bitmap(image.Width / scale, image.Height / scale / 2);
            Graphics g = Graphics.FromImage(b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height  
            g.DrawImage(image, 0, 0, image.Width / scale, image.Height / scale / 2);
            g.Dispose();
            return b;
        }

        static Image stringToImage(string inputString)
        {
            Bitmap bitmap = new Bitmap(1, 1);
            Font font = new Font("Consolas", 8, FontStyle.Regular, GraphicsUnit.Pixel);
            Graphics graphics = Graphics.FromImage(bitmap);
            int width = (int)graphics.MeasureString(inputString, font).Width;
            int height = (int)graphics.MeasureString(inputString, font).Height;
            bitmap = new Bitmap(bitmap, new Size(width, height));
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            graphics.DrawString(inputString, font, new SolidBrush(Color.FromArgb(0, 0, 0)), 0, 0);
            graphics.Flush();
            graphics.Dispose();
            return bitmap;
        }

        public static void DisplayFrame(PictureBox pictureBox, List<double> values, string charLine, Bitmap image)
        {
            string frame = "";
            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    Color color = image.GetPixel(j, i);

                    frame += GetChar(values, charLine, color); ;
                }

                if (i < image.Height - 1)//-1 to fix blank row at the end of the file. 
                {
                    frame += "\n";
                }
            }
            /*
            if (pictureBox.InvokeRequired && pictureBox.IsDisposed == false)
            {
                pictureBox.Invoke(new MethodInvoker(delegate { pictureBox.Image = stringToImage(frame); }));
            }
            */
            pictureBox.Image = stringToImage(frame);
            //textBox.AppendText(frame);
        }
    }
}
