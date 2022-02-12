using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecstAddetor
{
    class FileEdditor
    {
        string filePath = "";
        public FileEdditor(string filePath)
        {
            this.filePath = filePath;
        }
        public List<string> readFile()
        {
            List<string> lines = new List<string>();
            try
            {
                StreamReader sr = new StreamReader(filePath);
                string line = sr.ReadLine();
                while (line != null)
                {
                    lines.Add(line);
                    line = sr.ReadLine();

                }
                sr.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
            return lines;

        }
        void Writetext(string text)
        {
            StreamWriter sw = new StreamWriter(filePath);
            sw.WriteLine(text);
            sw.Close();
        }
        public void WriteFile(string text)
        {
            try
            {
                Writetext(text);

            }
            catch(Exception e)

            {
                MessageBox.Show("Exception:" + e.Message);
            }
        }
        public void WriteFileAs(string text, string newFilePath)
        {
            try
            {
                filePath = newFilePath;
                Writetext(text);
            }
            catch(Exception e)
            {
                MessageBox.Show("Exception:" + e.Message);
            }
        }


    }
}
