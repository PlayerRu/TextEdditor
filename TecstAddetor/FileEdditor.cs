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



    }
}
