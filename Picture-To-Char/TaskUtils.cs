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

        public static List<double> GetGrayScaleList()
        {
            Bitmap img = new Bitmap(Environment.CurrentDirectory + "\\Pictures\\download.png");
            List<double> values = new List<double>();

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color color = img.GetPixel(i, j);
                    double grayscale = (0.299 * color.R) + (0.587 * color.G) + (0.114 * color.B);
                    values.Add(grayscale);
                }
            }
            values.Sort();

            return values;
        }

        public static double GetGrayScale(int i, int j)
        {
            double grayscale;

            using (Bitmap img = new Bitmap(Environment.CurrentDirectory + "\\Pictures\\download.png"))
            {
                Color color = img.GetPixel(i, j);
                grayscale = (0.299 * color.R) + (0.587 * color.G) + (0.114 * color.B);
            }

            return grayscale;
        }

        public static char GrayScaleToChar(int colorCount, double grayscale, string charLine)
        {
            int charNum = (int)(colorCount / grayscale);

            //
            //192 / 96
            //255 / 255 / 96
            //96
            //
            //@M/BH/EN/R#/KW/XD/FP/QA/SU/Zb/de/hx/*8/Gm/&0/4L/OV/Yk/pq/5T/ag/ns/69/ow/z$/CI/u2/3J/cf/ry/%1/v7/l+/it/[]/ {/}?/j|/()=/~!/-//<>/\"/^_/';/,:/`./             //
            return charLine[charNum];
        }
    }
}
