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

                        char character = TaskUtils.GetChar(values, charLine, color);

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

        public static void SetFrame(RichTextBox textbox, List<double> values, string charLine, Bitmap image)
        {
            string frame = "";
            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    Color color = image.GetPixel(j, i);

                    frame += TaskUtils.GetChar(values, charLine, color); ;
                }

                if (i < image.Height - 1)//-1 to fix blank row at the end of the file. 
                {
                    frame += "\n";
                }
            }

            if (textbox.InvokeRequired && textbox.IsDisposed == false)
            {
                textbox.Invoke(new MethodInvoker(delegate { textbox.Text = frame; }));
            }

        }

        public static void DisplayTextFromFile(RichTextBox textBox, string path)
        {
            using (StreamReader read = new StreamReader(path))
            {
                string line;
                string frame = "";

                while (read.ReadLine() != null)
                {
                    line = read.ReadLine();

                    frame += line;
                    frame += "\n";
                    //textBox.AppendText(line);
                    //textBox.AppendText("\n");
                }
                textBox.Text = frame;
                //textBox.AppendText(frame);
            }
        }
    }
}
