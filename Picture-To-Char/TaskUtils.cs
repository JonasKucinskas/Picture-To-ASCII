using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Picture_To_Char
{
    internal class TaskUtils
    {
        public static List<double> GetGrayScaleList(Bitmap image)
        {
            List<double> values = new List<double>();

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color color = image.GetPixel(i, j);
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
