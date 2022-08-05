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

        public static List<int> GetGrayScaleList()
        {
            Bitmap img = new Bitmap(Environment.CurrentDirectory + "\\Pictures\\download.png");
            List<int> values = new List<int>();

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color color = img.GetPixel(i, j);
                    int grayscale = (int)((0.299 * color.R) + (0.587 * color.G) + (0.114 * color.B));
                    values.Add(grayscale);
                }
            }
            values.Sort();

            return values;
        }

        public static int GetGrayScale(int i, int j)
        {
            int grayscale;

            using (Bitmap img = new Bitmap(Environment.CurrentDirectory + "\\Pictures\\download.png"))
            {
                Color color = img.GetPixel(i, j);
                grayscale = (int)((0.299 * color.R) + (0.587 * color.G) + (0.114 * color.B));
            }

            return grayscale;
        }

        public static char GrayScaleToChar(List<int> values, int colorCount, int grayscale, string charLine)
        {
            double charNum = (double)colorCount / charLine.Length;
            int nunInList = values.Distinct().ToList().IndexOf(grayscale);

            

            //
            //192 / 96
            //255 / 255 / 96
            //96
            //
            //@M/BH/EN/R#/KW/XD/FP/QA/SU/Zb/de/hx/*8/Gm/&0/4L/OV/Yk/pq/5T/ag/ns/69/ow/z$/CI/u2/3J/cf/ry/%1/v7/l+/it/[]/ {/}?/j|/()=/~!/-//<>/\"/^_/';/,:/`./             //
            return charLine[(int)(nunInList / charNum)];
        }
    }
}
