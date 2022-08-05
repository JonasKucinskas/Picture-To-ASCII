using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picture_To_Char
{
    internal class Files
    {
        public static string GetCharLine(string filePath)
        {
            string line;

            using (StreamReader read = new StreamReader(filePath))
            {
                line = read.ReadLine();
            }

            return line; 
        }

        public static void WriteToTXT(List<double> values, string charLine, string path, Bitmap image)
        {
            using (StreamWriter write = new StreamWriter(path, false))
            {
                for (int i = 0; i < image.Height; i++)
                {
                    for (int j = 0; j < image.Width; j++)
                    {
                        Color color = image.GetPixel(j, i);
                        int grayscale = (int)((0.299 * color.R) + (0.587 * color.G) + (0.114 * color.B));

                        double charNum = (double)values.Count() / charLine.Length;
                        int numInList = values.IndexOf(grayscale);
                        write.Write(charLine[(int)(numInList / charNum)]);
                    }
                    write.Write("\n");
                }
            }
        }
    }
}
