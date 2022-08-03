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

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //Path.GetFileName(dialog.FileName))
                string filePath = dialog.FileName;//Gets directory for all word files.
                string fileName = Path.GetFileName(filePath);//get filename from path
                File.Copy(filePath, Path.Combine(path, fileName));
            }

            List<double> values = TaskUtils.GetGrayScaleList();

            double lightestValue = values[0];
            double darkestValue = values[values.Count - 1];

            string line = Files.GetCharLine();
            int charPerColor = values.Count / line.Length;


            Files.WriteToTXT(values.Distinct().Count(), line, path + "\\text.txt", 376, 457);


        }
    }
}
