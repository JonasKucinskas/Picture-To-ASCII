using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_To_Char
{
    internal class Files
    {
        public static string GetCharLine(string filePath)
        {
            using (StreamReader read = new StreamReader(filePath))
            {
                return read.ReadLine();
            }
        }

        public static void WriteToTXT(List<double> values, string charLine, string filePath, Bitmap image)
        {
            using (StreamWriter write = new StreamWriter(filePath, false))
            {
                for (int i = 0; i < image.Height; i++)
                {
                    for (int j = 0; j < image.Width; j++)
                    {
                        Color color = image.GetPixel(j, i);

                        char character = GetChar(values, charLine, color);

                        //Write character three times to compensate for width difference.
                        //AA 
                        //A
                        //two characters next to each other take less space than two rows.

                        string tripleChar = string.Format("{0}{0}{0}", character);

                        write.Write(tripleChar);
                    }

                    if (i < image.Height - 1)//-1 to fix blank row at the end of the file. 
                    {
                        write.Write("\n");
                    }
                }
            }
        }

        public static char GetChar(List<double> values, string charLine, Color color)
        {
            int grayscale = (int)((0.299 * color.R) + (0.587 * color.G) + (0.114 * color.B));

            double charNum = (double)values.Count() / charLine.Length;//this is probably wrong, but it works for now.
            int numInList = values.IndexOf(grayscale);//
            char character = charLine[(int)(numInList / charNum)];//

            return character;
        }

        public static void ProcessFrame(Bitmap image, string charLine, List<double> values, PictureBox picBox)
        {
            Image mainImage = new Bitmap(1, 1);
            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    Color color = image.GetPixel(j, i);
                    char character = GetChar(values, charLine, color);
                    string tripleChar = string.Format("{0}{0}{0}", character);
                    

                }
            }

            picBox.Image = mainImage;

        }

        
    }
}
