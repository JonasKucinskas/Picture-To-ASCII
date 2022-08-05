using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_To_Char
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "\\Pictures";
            string charPath = Environment.CurrentDirectory + "\\Data\\ASCII.txt";
            string txtPath = Environment.CurrentDirectory + "\\Data\\text.txt";

            OpenFileDialog dialog = new OpenFileDialog();

            string filePath = "";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
                //File.Copy(filePath, Path.Combine(path, fileName));
            }

            Bitmap image = new Bitmap(filePath);
            List<double> values = TaskUtils.GetGrayScaleList(image);

            double lightestValue = values[0];
            double darkestValue = values[values.Count - 1];

            string charLine = Files.GetCharLine(charPath);

            Files.WriteToTXT(values, charLine, txtPath, image);
        }
    }
}
