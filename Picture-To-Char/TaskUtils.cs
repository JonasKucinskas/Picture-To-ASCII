using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Picture_To_Char
{
    internal class TaskUtils
    {
        /// <summary>
        /// Gets list of all gray scale values of image.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="scale">scale for conversion to character. if scale is 1: 1*1 pixel = 1 character. If scale is 3 : 3*3 pixels = 1 character, etc.</param>
        /// <returns></returns>
        public static List<double> GetGrayScaleList(Bitmap image)
        {
            List<double> values = new List<double>();
            //List<double> tempGrayScale;
            //////
            //
            //

            /*
            for (int i = 0; i < image.Height; i+=scale)
            {

                for (int j = 0; j < image.Width; j+=scale)
                {
                    tempGrayScale = new List<double>();
                    for (int k = i; k < i+scale; k++)
                    {
                        for (int l = j; l < j+scale; l++)
                        {
                            if (i + scale < image.Height && j + scale < image.Width)
                            {
                                Color color = image.GetPixel(l, k);
                                double grayscale = (int)((0.299 * color.R) + (0.587 * color.G) + (0.114 * color.B));
                                tempGrayScale.Add(grayscale);
                            }
                        }
                    }

                    if (tempGrayScale.Count > 0)
                    {
                        double grayScaleAvg = tempGrayScale.Average();

                        if (!values.Contains(grayScaleAvg))
                        {
                            values.Add(grayScaleAvg);
                        }
                    }
                }
            }
            */
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
    }
}
