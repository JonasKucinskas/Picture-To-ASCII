using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

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
    }
}
