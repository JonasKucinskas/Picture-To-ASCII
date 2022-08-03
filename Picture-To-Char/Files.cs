using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picture_To_Char
{
    internal class Files
    {
        public static string GetCharLine()
        {
            string line;

            using (StreamReader read =  new StreamReader(@"C:\Users\Gaming\Desktop\program\c#\Picture-To-Char\Picture-To-Char\NewFolder1\ASCII.txt"))
            {
                line = read.ReadLine();
            }

            return line; 
        }

        public static void WriteToTXT(int colorCount, string charLine, string path, int height, int width)
        {
            using (StreamWriter write = new StreamWriter(path, false))
            {
                for (int i = 0; i < width; i++)
                {
                    write.Write("\n");
                    for (int j = 0; j < height; j++)
                    {
                        double grayscale = TaskUtils.GetGrayScale(i, j);

                        write.Write(TaskUtils.GrayScaleToChar(colorCount, grayscale, charLine));
                    }
                }
            }
        }
    }
}
